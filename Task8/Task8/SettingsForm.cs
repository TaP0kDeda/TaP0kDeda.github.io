using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class SettingsForm : Form
    {
        public GameSettings Settings { get; private set; }
        public SettingsForm(GameSettings currentSettings)
        {
            InitializeComponent(); 
            Settings = currentSettings;
            LoadSettings();

            // Подписка на события
            btnSave.Click += btnSave_Click;
            btnRocketColor.Click += btnColor_Click;
            btnLargeColor.Click += btnColor_Click;
            btnSmallColor.Click += btnColor_Click;
        }

        private void LoadSettings()
        {
            numTime.Value = Settings.TimeSeconds;
            numTarget.Value = Settings.TargetMeteors;
            cmbDifficulty.SelectedIndex = (int)Settings.Difficulty-1;
            btnRocketColor.BackColor = Settings.RocketColor;
            btnLargeColor.BackColor = Settings.LargeMeteorColor;
            btnSmallColor.BackColor = Settings.SmallMeteorColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.TimeSeconds = (int)numTime.Value;
            Settings.TargetMeteors = (int)numTarget.Value;
            Settings.Difficulty = (Difficulty)cmbDifficulty.SelectedIndex;
            Settings.RocketColor = btnRocketColor.BackColor;
            Settings.LargeMeteorColor = btnLargeColor.BackColor;
            Settings.SmallMeteorColor = btnSmallColor.BackColor;

            // Обновляем параметры в зависимости от сложности
            switch (Settings.Difficulty)
            {
                case Difficulty.Easy:
                    Settings.MeteorBaseSpeed = 3;
                    Settings.SpawnIntervalMs = 1200;
                    Settings.LargeMeteorProbability = 0.2f;
                    break;
                case Difficulty.Medium:
                    Settings.MeteorBaseSpeed = 5;
                    Settings.SpawnIntervalMs = 800;
                    Settings.LargeMeteorProbability = 0.3f;
                    break;
                case Difficulty.Hard:
                    Settings.MeteorBaseSpeed = 7;
                    Settings.SpawnIntervalMs = 500;
                    Settings.LargeMeteorProbability = 0.4f;
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                    btn.BackColor = cd.Color;
            }
        }
    }
}
