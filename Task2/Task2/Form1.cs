namespace Task2
{
    public partial class Form1 : Form
    {
        private List<int> numbers = new List<int>();
        bool FileState = false;
        bool OptionState = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountNumbers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileContent = File.ReadAllText(openFileDialog.FileName);

                        LoadNumbersFromText(fileContent);

                        label2.Text = "Файл загружен. Нажмите 'Обработать'.";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            FileState = true;
            if (OptionState == true)
            {
                button1.Enabled = true;
            }
        }
        private void LoadNumbersFromText(string text)
        {
            numbers.Clear();
            char[] delimiters = new char[] { ' ', '\t', ',', ';', '\n', '\r' };

            string[] tokens = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                numbers.Add(Convert.ToInt32(token));
            }
        }
        private void CountNumbers()
        {
            label2.Text = "";
            foreach (int num in numbers)
            {
                richTextBox1.Text += Notation.CountNotation(comboBox1.SelectedIndex + 2, num) + " ";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionState = true;
            if (FileState == true)
            {
                button1.Enabled = true;
            }
        }
    }
}
