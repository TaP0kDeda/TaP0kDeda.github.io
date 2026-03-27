namespace Task4
{
    partial class SurveyAnalysis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            Survey = new TabPage();
            OffenceText = new TextBox();
            PeopleText = new TextBox();
            SurveyApplyButton = new Button();
            OffenceLabel = new Label();
            PeopleLabel = new Label();
            RegionNameLabel = new Label();
            RegionNameText = new TextBox();
            Tablet = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Diagramm = new TabPage();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            Survey.SuspendLayout();
            Tablet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Diagramm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Survey);
            tabControl1.Controls.Add(Tablet);
            tabControl1.Controls.Add(Diagramm);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 429);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // Survey
            // 
            Survey.Controls.Add(OffenceText);
            Survey.Controls.Add(PeopleText);
            Survey.Controls.Add(SurveyApplyButton);
            Survey.Controls.Add(OffenceLabel);
            Survey.Controls.Add(PeopleLabel);
            Survey.Controls.Add(RegionNameLabel);
            Survey.Controls.Add(RegionNameText);
            Survey.Location = new Point(4, 24);
            Survey.Name = "Survey";
            Survey.Padding = new Padding(3);
            Survey.Size = new Size(671, 401);
            Survey.TabIndex = 0;
            Survey.Text = "Опрос";
            Survey.UseVisualStyleBackColor = true;
            // 
            // OffenceText
            // 
            OffenceText.Location = new Point(44, 208);
            OffenceText.Name = "OffenceText";
            OffenceText.Size = new Size(231, 23);
            OffenceText.TabIndex = 8;
            // 
            // PeopleText
            // 
            PeopleText.Location = new Point(44, 131);
            PeopleText.Name = "PeopleText";
            PeopleText.Size = new Size(231, 23);
            PeopleText.TabIndex = 7;
            // 
            // SurveyApplyButton
            // 
            SurveyApplyButton.Location = new Point(57, 289);
            SurveyApplyButton.Name = "SurveyApplyButton";
            SurveyApplyButton.Size = new Size(203, 54);
            SurveyApplyButton.TabIndex = 6;
            SurveyApplyButton.Text = "Отправить";
            SurveyApplyButton.UseVisualStyleBackColor = true;
            SurveyApplyButton.Click += SurveyApplyButton_Click;
            // 
            // OffenceLabel
            // 
            OffenceLabel.AutoSize = true;
            OffenceLabel.Location = new Point(44, 190);
            OffenceLabel.Name = "OffenceLabel";
            OffenceLabel.Size = new Size(225, 15);
            OffenceLabel.TabIndex = 5;
            OffenceLabel.Text = "Зарегистрированных правонарушений";
            // 
            // PeopleLabel
            // 
            PeopleLabel.AutoSize = true;
            PeopleLabel.Location = new Point(44, 113);
            PeopleLabel.Name = "PeopleLabel";
            PeopleLabel.Size = new Size(141, 15);
            PeopleLabel.TabIndex = 4;
            PeopleLabel.Text = "Кол-во населения (тыс.)";
            // 
            // RegionNameLabel
            // 
            RegionNameLabel.AutoSize = true;
            RegionNameLabel.Location = new Point(44, 39);
            RegionNameLabel.Name = "RegionNameLabel";
            RegionNameLabel.Size = new Size(107, 15);
            RegionNameLabel.TabIndex = 3;
            RegionNameLabel.Text = "Название области";
            // 
            // RegionNameText
            // 
            RegionNameText.Location = new Point(44, 57);
            RegionNameText.Name = "RegionNameText";
            RegionNameText.Size = new Size(231, 23);
            RegionNameText.TabIndex = 0;
            // 
            // Tablet
            // 
            Tablet.Controls.Add(button3);
            Tablet.Controls.Add(button2);
            Tablet.Controls.Add(button1);
            Tablet.Controls.Add(dataGridView1);
            Tablet.Location = new Point(4, 24);
            Tablet.Name = "Tablet";
            Tablet.Padding = new Padding(3);
            Tablet.Size = new Size(671, 401);
            Tablet.TabIndex = 1;
            Tablet.Text = "Таблица";
            Tablet.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(459, 263);
            button3.Name = "button3";
            button3.Size = new Size(193, 63);
            button3.TabIndex = 3;
            button3.Text = "Поиск наибольшей преступности";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(459, 161);
            button2.Name = "button2";
            button2.Size = new Size(193, 63);
            button2.TabIndex = 2;
            button2.Text = "Загрузить из файла";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(459, 61);
            button1.Name = "button1";
            button1.Size = new Size(193, 63);
            button1.TabIndex = 1;
            button1.Text = "Сохранить в файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 44;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(440, 395);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название региона";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Кол-во населения (тыс.)";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Кол-во правонарушений";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Процент преступности";
            Column4.Name = "Column4";
            // 
            // Diagramm
            // 
            Diagramm.Controls.Add(chart);
            Diagramm.Location = new Point(4, 24);
            Diagramm.Name = "Diagramm";
            Diagramm.Size = new Size(671, 401);
            Diagramm.TabIndex = 2;
            Diagramm.Text = "Диаграмма";
            Diagramm.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(3, 3);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(665, 398);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // SurveyAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 428);
            Controls.Add(tabControl1);
            Name = "SurveyAnalysis";
            Text = "Анализ опроса";
            Load += SurveyAnalysis_Load;
            tabControl1.ResumeLayout(false);
            Survey.ResumeLayout(false);
            Survey.PerformLayout();
            Tablet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Diagramm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Survey;
        private TabPage Tablet;
        private TabPage Diagramm;
        private Label RegionNameLabel;
        private TextBox RegionNameText;
        private Label OffenceLabel;
        private Label PeopleLabel;
        private Button SurveyApplyButton;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox OffenceText;
        private TextBox PeopleText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
