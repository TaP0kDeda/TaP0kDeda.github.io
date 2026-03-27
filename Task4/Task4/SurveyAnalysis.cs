using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Task4
{
    public partial class SurveyAnalysis : Form
    {
        private ArrayRegion arrayReg = new ArrayRegion();
        int count = 1;
        public SurveyAnalysis()
        {
            InitializeComponent();
        }

        private void SurveyApplyButton_Click(object sender, EventArgs e)
        {
            string name = RegionNameText.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название области.", "Ошибка");
                return;
            }
            if (!int.TryParse(PeopleText.Text, out int population) || population <= 0)
            {
                MessageBox.Show("Введите корректное население (тыс. чел.).", "Ошибка");
                return;
            }
            if (!int.TryParse(OffenceText.Text, out int crimes) || crimes < 0)
            {
                MessageBox.Show("Введите корректное количество преступлений.", "Ошибка");
                return;
            }

            arrayReg.Add(new Region(name, population, crimes));
            UpdateDataGridView();
            ClearInputFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arrayReg.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.", "Предупреждение");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                DefaultExt = "txt"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                arrayReg.SaveToFile(sfd.FileName);
                MessageBox.Show("Данные сохранены.", "Успех");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    arrayReg.LoadFromFile(ofd.FileName);
                    UpdateDataGridView();
                    MessageBox.Show($"Загружено {arrayReg.Count} записей.", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки файла: " + ex.Message, "Ошибка");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arrayReg.Count == 0)
            {
                MessageBox.Show("Нет данных для поиска.", "Предупреждение");
                return;
            }
            var best = arrayReg.GetHighestCrimePercent();
            MessageBox.Show($"Область с наибольшим уровнем преступности:\n{best.Name}\n" +
                            $"Уровень преступности: {best.CrimeRatePercent:F2}%",
                            "Результат поиска");
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var region in arrayReg.GetAll())
            {
                dataGridView1.Rows.Add(
                    region.Name,
                    region.Population,
                    region.Crimes,
                    $"{region.CrimeRatePercent:F2}%"
                );
            }
        }

        private void UpdateChart()
        {

            chart.Series.Clear();
            if (arrayReg.Count == 0) return;

            Series series = new Series("Уровень преступности")
            {
                ChartType = SeriesChartType.Column
            };
            series.IsValueShownAsLabel = true;
            series.Color = Color.SteelBlue;
            series.BorderColor = Color.DarkBlue;
            series.BorderWidth = 1;
            foreach (var region in arrayReg.GetAll())
            {
                series.Points.AddXY(count, region.CrimeRatePercent);
                series.Points[count-1].AxisLabel = region.Name;
                count++;
                
            }

            chart.ChartAreas[0].AxisX.Title = "Область";
            chart.ChartAreas[0].AxisY.Title = "Уровень преступности, %";
            chart.Series.Add(series);
            chart.Titles.Clear();
            chart.Titles.Add($"Уровень преступности по областям");
        }

        private void ClearInputFields()
        {
            RegionNameText.Clear();
            PeopleText.Clear();
            OffenceText.Clear();
            RegionNameText.Focus();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Diagramm)
            {
                UpdateChart();
            }
        }

        private void SurveyAnalysis_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            chart.ChartAreas.Clear();
            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);
            chart.Legends.Clear();
        }
    }
}
