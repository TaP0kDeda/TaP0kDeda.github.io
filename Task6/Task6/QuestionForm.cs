using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class QuestionForm : Form
    {
        private List<Question> _allQuestions;
        private List<Question> _sessionQuestions; 
        private int _currentIndex = 0;
        private int _score = 0;
        private int _questionCount = 5;
        private System.Windows.Forms.Timer _timer;
        private int _timeLeft = 30;
        private int _level;
        private Random _random = new Random();

        public QuestionForm(List<Question> questions, int level)
        {
            InitializeComponent();
            _allQuestions = questions;
            _level = level;
            SelectRandomQuestions();
            SetupTimer();
            ShowCurrentQuestion();
        }
        private void SelectRandomQuestions()
        {
            _sessionQuestions = _allQuestions
                .OrderBy(x => _random.Next())
                .Take(_questionCount)
                .ToList();
        }

        private void SetupTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }



        private void btnAnswer_Click(object sender, EventArgs e)
        {
            _timer.Stop();

            if (cmbAnswers.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите вариант ответа", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _timer.Start();
                return;
            }

            var q = _sessionQuestions[_currentIndex];
            bool isCorrect = (cmbAnswers.SelectedIndex == q.CorrectAnswerIndex);

            if (isCorrect)
            {
                MessageBox.Show("Правильно!", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _score += 100;
            }
            else
            {
                MessageBox.Show($"Неправильно.\nПравильный ответ: {q.Answers[q.CorrectAnswerIndex].Text}",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            NextQuestion(isCorrect);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTimer.Text = $"Осталось: {_timeLeft} сек";

            if (_timeLeft <= 0)
            {
                _timer.Stop();
                MessageBox.Show("Время вышло! Ответ не засчитан.",
                    "Время истекло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NextQuestion(false);
            }
        }

        private void ShowCurrentQuestion()
        {
            if (_currentIndex >= _sessionQuestions.Count)
            {
                EndGame();
                return;
            }

            _timer.Stop();
            _timeLeft = 30;
            lblTimer.Text = $"Осталось: {_timeLeft} сек";

            var q = _sessionQuestions[_currentIndex];

            lblQuestion.Text = q.Text;

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", q.ImagePath);
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                lblNoImage.Text = "";
            }
            else
            {
                pictureBox.Image = null;
                if (!string.IsNullOrEmpty(q.ImagePath))
                    lblNoImage.Text = $"Изображение не найдено: {q.ImagePath}";
                else
                    lblNoImage.Text = "";
            }

            cmbAnswers.Items.Clear();
            foreach (var answer in q.Answers)
            {
                cmbAnswers.Items.Add(answer.Text);
            }
            cmbAnswers.SelectedIndex = -1;

            _timer.Start();
        }

        private void NextQuestion(bool answered)
        {
            _currentIndex++;

            if (_currentIndex < _sessionQuestions.Count)
            {
                ShowCurrentQuestion();
            }
            else
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            _timer.Stop();
            MainForm f2 = new MainForm();
            int maxScore = _sessionQuestions.Count * 100;
            int percentage = (int)((double)_score / maxScore * 100);

            string message = $"Игра окончена!\n\n" +
                           $"Правильных ответов: {_score / 100} из {_sessionQuestions.Count}\n" +
                           $"Набрано баллов: {_score} из {maxScore}\n" +
                           $"Результат: {percentage}%\n\n";

            if (percentage >= 80 && _level < 3)
            {
                message += $"Поздравляем! Вы набрали {percentage}% и разблокировали уровень {_level + 1}!";
                if (_level == 1)
                {
                    f2.NumericMax = 2;
                }
                if (_level == 2)
                {
                    f2.NumericMax = 3;
                }
            }
            else if (percentage < 80 && _level < 3)
            {
                message += $"Для перехода на следующий уровень необходимо 80%. Попробуйте ещё раз.";
            }
            else if (_level == 3)
            {
                message += $"Вы завершили максимальный уровень сложности!";
                f2.NumericMax = 3;
            }
            f2.Show();
            MessageBox.Show(message, "Результаты тестирования",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
