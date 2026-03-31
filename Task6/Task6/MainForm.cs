namespace Task6
{
    public partial class MainForm : Form
    {
        private TestData _data;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        public decimal NumericMax
        {
            get { return numericLevel.Maximum; }
            set { numericLevel.Maximum = value; }
        }

        private void LoadData()
        {
            try
            {
                _data = XmlDataManager.LoadData();
                this.Text = _data.Head;
                ChooseLabel.Text += _data.Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            int selectedLevel = (int)numericLevel.Value;

            var questions = XmlDataManager.GetQuestions(_data, selectedLevel);

            if (questions.Count == 0)
            {
                MessageBox.Show($"В уровне {selectedLevel} нет вопросов. " +
                    "Добавьте вопросы через панель администратора.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Запускаем игровую форму
            var gameForm = new QuestionForm(questions, selectedLevel);
            gameForm.Show();
            this.Hide();
        }

        private void UpdateFilePathLabel()
        {
            string path = XmlDataManager.GetCurrentFilePath();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            var result = XmlDataManager.LoadDataFromFile();
            if (result != null)
            {
                _data = result;
                this.Text = _data.Head;
                ChooseLabel.Text = _data.Description;
                UpdateFilePathLabel();
                MessageBox.Show("Файл успешно загружен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
