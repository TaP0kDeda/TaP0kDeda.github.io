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
    public partial class AdminForm : Form
    {
        private TestData _data;
        private int _currentLevel = 1;

        public AdminForm()
        {
            InitializeComponent();
            LoadData();
            UpdateDisplay();
            UpdateFilePathLabel();
        }
        private void LoadData()
        {
            _data = XmlDataManager.LoadData();
            if (_data == null)
            {
                this.Close();
                return;
            }

            if (_data.Themes.Count == 0)
            {
                _data.Themes.Add(new Theme { Name = "Природные достопримечательности России и Европы" });
                for (int i = 1; i <= 3; i++)
                {
                    _data.Themes[0].Levels.Add(new Level { Difficulty = i });
                }
            }
        }

        private void UpdateFilePathLabel()
        {
            string path = XmlDataManager.GetCurrentFilePath();
            lblFilePath.Text = $"Текущий файл: {path}";
        }

        private void UpdateDisplay()
        {
            cmbLevel.Items.Clear();
            for (int i = 1; i <= 3; i++)
            {
                cmbLevel.Items.Add($"Уровень {i}");
            }
            if (cmbLevel.Items.Count > 0)
                cmbLevel.SelectedIndex = _currentLevel - 1;

            UpdateQuestionsList();
        }

        private void UpdateQuestionsList()
        {
            lstQuestions.Items.Clear();
            var questions = XmlDataManager.GetQuestions(_data, _currentLevel);

            for (int i = 0; i < questions.Count; i++)
            {
                var q = questions[i];
                lstQuestions.Items.Add($"{i + 1}. {q.Text} (правильный ответ: {q.Answers[q.CorrectAnswerIndex].Text})");
            }

            lblCount.Text = $"Всего вопросов: {questions.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Добавить вопрос";
            inputForm.Size = new System.Drawing.Size(500, 400);
            inputForm.StartPosition = FormStartPosition.CenterParent;

            Label lblQuestion = new Label() { Text = "Текст вопроса:", Top = 10, Left = 10, Width = 100 };
            TextBox txtQuestion = new TextBox() { Top = 35, Left = 10, Width = 460, Multiline = true, Height = 60 };

            Label lblImage = new Label() { Text = "Изображение:", Top = 105, Left = 10, Width = 100 };
            TextBox txtImage = new TextBox() { Top = 130, Left = 10, Width = 400 };
            Button btnBrowse = new Button() { Text = "Обзор...", Top = 130, Left = 420, Width = 50 };

            Label lblCorrect = new Label() { Text = "Правильный ответ:", Top = 165, Left = 10, Width = 120 };
            TextBox txtCorrect = new TextBox() { Top = 190, Left = 10, Width = 460 };

            Label lblWrong = new Label() { Text = "Неправильные ответы:", Top = 225, Left = 10, Width = 150 };
            TextBox txtWrong = new TextBox() { Top = 250, Left = 10, Width = 400 };
            Button btnAddWrong = new Button() { Text = "Добавить", Top = 250, Left = 420, Width = 50 };
            ListBox lstWrong = new ListBox() { Top = 280, Left = 10, Width = 460, Height = 80 };

            Button btnSave = new Button() { Text = "Сохранить", Top = 370, Left = 10, Width = 100 };
            Button btnCancel = new Button() { Text = "Отмена", Top = 370, Left = 120, Width = 100 };

            btnBrowse.Click += (s, ev) =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = ofd.FileName;
                }
            };

            btnAddWrong.Click += (s, ev) =>
            {
                if (!string.IsNullOrWhiteSpace(txtWrong.Text))
                {
                    lstWrong.Items.Add(txtWrong.Text);
                    txtWrong.Clear();
                }
            };

            Button btnRemoveWrong = new Button() { Text = "Удалить", Top = 370, Left = 220, Width = 100 };
            btnRemoveWrong.Click += (s, ev) =>
            {
                if (lstWrong.SelectedIndex >= 0)
                    lstWrong.Items.RemoveAt(lstWrong.SelectedIndex);
            };

            btnSave.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtQuestion.Text))
                {
                    MessageBox.Show("Введите текст вопроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorrect.Text))
                {
                    MessageBox.Show("Введите правильный ответ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lstWrong.Items.Count < 1)
                {
                    MessageBox.Show("Добавьте хотя бы один неправильный вариант ответа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Question newQuestion = new Question();
                newQuestion.Text = txtQuestion.Text;
                newQuestion.ImagePath = System.IO.Path.GetFileName(txtImage.Text);
                newQuestion.Answers = new System.Collections.Generic.List<Answer>();

                newQuestion.Answers.Add(new Answer { Text = txtCorrect.Text, IsRight = true });
                newQuestion.CorrectAnswerIndex = 0;

                foreach (var item in lstWrong.Items)
                {
                    newQuestion.Answers.Add(new Answer { Text = item.ToString(), IsRight = false });
                }

                Random rnd = new Random();
                for (int i = newQuestion.Answers.Count - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    var temp = newQuestion.Answers[i];
                    newQuestion.Answers[i] = newQuestion.Answers[j];
                    newQuestion.Answers[j] = temp;
                }

                for (int i = 0; i < newQuestion.Answers.Count; i++)
                {
                    if (newQuestion.Answers[i].IsRight)
                    {
                        newQuestion.CorrectAnswerIndex = i;
                        break;
                    }
                }

                XmlDataManager.AddQuestion(_data, _currentLevel, newQuestion);
                UpdateQuestionsList();
                inputForm.Close();

                MessageBox.Show("Вопрос успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnCancel.Click += (s, ev) => inputForm.Close();

            inputForm.Controls.AddRange(new Control[] {
                lblQuestion, txtQuestion,
                lblImage, txtImage, btnBrowse,
                lblCorrect, txtCorrect,
                lblWrong, txtWrong, btnAddWrong, lstWrong, btnRemoveWrong,
                btnSave, btnCancel
            });

            inputForm.ShowDialog();

        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentLevel = cmbLevel.SelectedIndex + 1;
            UpdateQuestionsList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите вопрос для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить выбранный вопрос?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XmlDataManager.RemoveQuestion(_data, _currentLevel, lstQuestions.SelectedIndex);
                UpdateQuestionsList();
                MessageBox.Show("Вопрос удалён", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newHead = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите новый заголовок:", "Редактирование заголовка", _data.Head);
            if (!string.IsNullOrWhiteSpace(newHead))
            {
                _data.Head = newHead;
                XmlDataManager.SaveData(_data);
                MessageBox.Show("Заголовок обновлён", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newDesc = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите новое описание:", "Редактирование описания", _data.Description);
            if (!string.IsNullOrWhiteSpace(newDesc))
            {
                _data.Description = newDesc;
                XmlDataManager.SaveData(_data);
                MessageBox.Show("Описание обновлено", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
