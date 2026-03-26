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
            tabControl1 = new TabControl();
            Survey = new TabPage();
            SurveyApplyButton = new Button();
            OffenceLabel = new Label();
            PeopleLabel = new Label();
            RegionNameLabel = new Label();
            OffenceText = new NumericUpDown();
            PeopleText = new NumericUpDown();
            RegionNameText = new TextBox();
            Tablet = new TabPage();
            Diagramm = new TabPage();
            tabControl1.SuspendLayout();
            Survey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OffenceText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PeopleText).BeginInit();
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
            // 
            // Survey
            // 
            Survey.Controls.Add(SurveyApplyButton);
            Survey.Controls.Add(OffenceLabel);
            Survey.Controls.Add(PeopleLabel);
            Survey.Controls.Add(RegionNameLabel);
            Survey.Controls.Add(OffenceText);
            Survey.Controls.Add(PeopleText);
            Survey.Controls.Add(RegionNameText);
            Survey.Location = new Point(4, 24);
            Survey.Name = "Survey";
            Survey.Padding = new Padding(3);
            Survey.Size = new Size(671, 401);
            Survey.TabIndex = 0;
            Survey.Text = "Опрос";
            Survey.UseVisualStyleBackColor = true;
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
            // OffenceText
            // 
            OffenceText.Location = new Point(44, 208);
            OffenceText.Name = "OffenceText";
            OffenceText.Size = new Size(231, 23);
            OffenceText.TabIndex = 2;
            // 
            // PeopleText
            // 
            PeopleText.Location = new Point(44, 131);
            PeopleText.Name = "PeopleText";
            PeopleText.Size = new Size(231, 23);
            PeopleText.TabIndex = 1;
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
            Tablet.Location = new Point(4, 24);
            Tablet.Name = "Tablet";
            Tablet.Padding = new Padding(3);
            Tablet.Size = new Size(671, 401);
            Tablet.TabIndex = 1;
            Tablet.Text = "Таблица";
            Tablet.UseVisualStyleBackColor = true;
            // 
            // Diagramm
            // 
            Diagramm.Location = new Point(4, 24);
            Diagramm.Name = "Diagramm";
            Diagramm.Size = new Size(671, 478);
            Diagramm.TabIndex = 2;
            Diagramm.Text = "Диаграмма";
            Diagramm.UseVisualStyleBackColor = true;
            // 
            // SurveyAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 428);
            Controls.Add(tabControl1);
            Name = "SurveyAnalysis";
            Text = "Анализ опроса";
            tabControl1.ResumeLayout(false);
            Survey.ResumeLayout(false);
            Survey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OffenceText).EndInit();
            ((System.ComponentModel.ISupportInitialize)PeopleText).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Survey;
        private TabPage Tablet;
        private TabPage Diagramm;
        private Label RegionNameLabel;
        private NumericUpDown OffenceText;
        private NumericUpDown PeopleText;
        private TextBox RegionNameText;
        private Label OffenceLabel;
        private Label PeopleLabel;
        private Button SurveyApplyButton;
    }
}
