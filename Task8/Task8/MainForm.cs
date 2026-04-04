using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class MainForm : Form
    {
        private Rocket rocket;
        private List<Meteor> meteors = new List<Meteor>();
        private string currentLogin;
        // Параметры игры
        private GameSettings settings;
        private int currentScore = 0;
        private int remainingTime;
        private bool isGameActive = false;
        public MainForm()
        {
            InitializeComponent();
            LoadDefaultSettings();
            ShowLoginDialog();
            ApplySettings();
            this.newGameMenuItem.Click += NewGameMenuItem_Click;
            this.exitMenuItem.Click += ExitMenuItem_Click;
            this.settingsMenuItem.Click += SettingsMenuItem_Click;
            this.resultsMenuItem.Click += ResultsMenuItem_Click;
            this.helpMenuItem.Click += HelpMenuItem_Click;
            this.KeyDown += MainForm_KeyDown;
            this.gamePanel.Paint += GamePanel_Paint;
        }

        private void LoadDefaultSettings()
        {
            settings = new GameSettings();
        }

        private void ShowLoginDialog()
        {
            using (LoginForm lf = new LoginForm())
            {
                if (lf.ShowDialog() == DialogResult.OK)
                    currentLogin = lf.Login;
                else
                    currentLogin = "Guest";
            }
        }

        private void ApplySettings()
        {
            gamePanel.Invalidate();
        }
        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm sf = new SettingsForm(settings))
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    settings = sf.Settings;
                }
            }
        }

        private void ResultsMenuItem_Click(object sender, EventArgs e)
        {
            using (ResultForm rf = new ResultForm(currentLogin))
            {
                rf.ShowDialog();
            }
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление: стрелки влево/вправо – движение ракеты.\n" +
                            "Enter – собрать мелкий метеорит (при пересечении с ракетой).\n" +
                            "Избегайте крупных метеоритов!\n" +
                            "Соберите заданное количество малых метеоритов до истечения времени.",
                            "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void StartGame()
        {
            StopGame();

            meteors.Clear();
            currentScore = 0;
            remainingTime = settings.TimeSeconds;
            isGameActive = true;
            UpdateStatus();

            int rocketWidth = 40;
            int rocketHeight = 30;
            int startX = gamePanel.Width / 2 - rocketWidth / 2;
            rocket = new Rocket(startX, gamePanel.Height - rocketHeight - 20, rocketWidth, rocketHeight);

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 30;
            gameTimer.Tick += GameTimer_Tick;

            spawnTimer = new System.Windows.Forms.Timer();
            spawnTimer.Interval = settings.SpawnIntervalMs;
            spawnTimer.Tick += SpawnTimer_Tick;

            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;

            gameTimer.Start();
            spawnTimer.Start();
            countdownTimer.Start();

            gamePanel.Invalidate();
        }

        private void StopGame()
        {
            isGameActive = false;
            if (gameTimer != null) gameTimer.Stop();
            if (spawnTimer != null) spawnTimer.Stop();
            if (countdownTimer != null) countdownTimer.Stop();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            for (int i = meteors.Count - 1; i >= 0; i--)
            {
                Meteor m = meteors[i];
                m.Y += m.Speed;
                if (m.Y > gamePanel.Height + 50 || m.Y + m.Size < 0)
                {
                    meteors.RemoveAt(i);
                    continue;
                }
                if (m.Type == MeteorType.Large && rocket.GetBounds().IntersectsWith(m.GetBounds()))
                {
                    EndGame(false);
                    return;
                }
            }

            if (currentScore >= settings.TargetMeteors)
            {
                EndGame(true);
                return;
            }

            gamePanel.Invalidate();
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameActive) return;
            Random rand = new Random();
            MeteorType type = (rand.NextDouble() < settings.LargeMeteorProbability) ? MeteorType.Large : MeteorType.Small;
            int size = (type == MeteorType.Large) ? 35 : 18;
            int x = rand.Next(0, gamePanel.Width - size);
            int y = -size;
            int speed = settings.MeteorBaseSpeed + rand.Next(2, 6);
            meteors.Add(new Meteor(x, y, size, speed, type));
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameActive) return;
            remainingTime--;
            UpdateStatus();
            if (remainingTime <= 0) EndGame(false);
        }

        private void UpdateStatus()
        {
            scoreLabel.Text = $"Собрано: {currentScore} / {settings.TargetMeteors}";
            timeLabel.Text = $"Время: {remainingTime}";
        }

        private void EndGame(bool isWin)
        {
            if (!isGameActive) return;
            isGameActive = false;
            StopGame();

            string message = isWin ? $"Победа! Вы собрали {currentScore} метеоритов!" : $"Поражение! Собрано {currentScore} из {settings.TargetMeteors}.";
            MessageBox.Show(message, "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveResult(isWin);
        }
        private void SaveResult(bool isWin)
        {
            GameResult result = new GameResult
            {
                Login = currentLogin,
                Date = DateTime.Now,
                Score = currentScore,
                Required = settings.TargetMeteors,
                IsWin = isWin
            };

            string file = "results.dat";
            List<GameResult> results = new List<GameResult>();
            if (File.Exists(file))
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    results = (List<GameResult>)bf.Deserialize(fs);
                }
            }
            results.Add(result);
            BinaryFormatter bfOut = new BinaryFormatter();
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                bfOut.Serialize(fs, results);
            }
        }

        private void CollectSmallMeteor()
        {
            if (!isGameActive) return;
            for (int i = meteors.Count - 1; i >= 0; i--)
            {
                Meteor m = meteors[i];
                if (m.Type == MeteorType.Small && rocket.GetBounds().IntersectsWith(m.GetBounds()))
                {
                    meteors.RemoveAt(i);
                    currentScore++;
                    UpdateStatus();
                    if (currentScore >= settings.TargetMeteors) EndGame(true);
                    break;
                }
            }
            gamePanel.Invalidate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameActive) return;
            if (e.KeyCode == Keys.Left)
            {
                rocket.X -= settings.RocketSpeed;
                if (rocket.X < 0) rocket.X = 0;
                gamePanel.Invalidate();
            }
            else if (e.KeyCode == Keys.Right)
            {
                rocket.X += settings.RocketSpeed;
                if (rocket.X + rocket.Width > gamePanel.Width) rocket.X = gamePanel.Width - rocket.Width;
                gamePanel.Invalidate();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                CollectSmallMeteor();
            }
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            if (rocket != null)
                rocket.Draw(e.Graphics, settings.RocketColor);
            foreach (Meteor m in meteors)
            {
                Color color = (m.Type == MeteorType.Large) ? settings.LargeMeteorColor : settings.SmallMeteorColor;
                m.Draw(e.Graphics, color);
            }
        }

    }
    public enum MeteorType { Large, Small }

    public class Rocket
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rocket(int x, int y, int width, int height)
        {
            X = x; Y = y; Width = width; Height = height;
        }

        public Rectangle GetBounds() => new Rectangle(X, Y, Width, Height);

        public void Draw(Graphics g, Color color)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, X, Y + Height / 3, Width, Height * 2 / 3);
                Point[] nose = { new Point(X + Width / 2, Y), new Point(X, Y + Height / 3), new Point(X + Width, Y + Height / 3) };
                g.FillPolygon(brush, nose);
                using (Brush white = new SolidBrush(Color.White))
                    g.FillEllipse(white, X + Width / 2 - 5, Y + Height / 2, 10, 10);
            }
        }
    }

    public class Meteor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; private set; }
        public int Speed { get; set; }
        public MeteorType Type { get; private set; }

        public Meteor(int x, int y, int size, int speed, MeteorType type)
        {
            X = x; Y = y; Size = size; Speed = speed; Type = type;
        }

        public Rectangle GetBounds() => new Rectangle(X, Y, Size, Size);

        public void Draw(Graphics g, Color color)
        {
            using (SolidBrush brush = new SolidBrush(color))
                g.FillEllipse(brush, X, Y, Size, Size);
            using (Brush dark = new SolidBrush(Color.Black))
            {
                g.FillEllipse(dark, X + Size / 4, Y + Size / 4, Size / 6, Size / 6);
                g.FillEllipse(dark, X + Size * 2 / 3, Y + Size / 3, Size / 8, Size / 8);
            }
        }
    }
}
