namespace Task6
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbLevel = new ComboBox();
            label1 = new Label();
            btnAddQuestion = new Button();
            lblFilePath = new Label();
            lstQuestions = new ListBox();
            splitter1 = new Splitter();
            lblCount = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // cmbLevel
            // 
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(124, 14);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(122, 23);
            cmbLevel.TabIndex = 0;
            cmbLevel.SelectedIndexChanged += cmbLevel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Выбрать уровень:";
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(284, 14);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(247, 49);
            btnAddQuestion.TabIndex = 2;
            btnAddQuestion.Text = "Добавить вопрос";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += button1_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.Location = new Point(12, 45);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(233, 57);
            lblFilePath.TabIndex = 3;
            lblFilePath.Text = " ";
            // 
            // lstQuestions
            // 
            lstQuestions.FormattingEnabled = true;
            lstQuestions.ItemHeight = 15;
            lstQuestions.Location = new Point(13, 112);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(233, 289);
            lstQuestions.TabIndex = 4;
            lstQuestions.SelectedIndexChanged += lstQuestions_SelectedIndexChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 443);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(13, 413);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(10, 15);
            lblCount.TabIndex = 6;
            lblCount.Text = " ";
            // 
            // button1
            // 
            button1.Location = new Point(284, 81);
            button1.Name = "button1";
            button1.Size = new Size(247, 49);
            button1.TabIndex = 7;
            button1.Text = "Удалить вопрос";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(284, 145);
            button2.Name = "button2";
            button2.Size = new Size(247, 49);
            button2.TabIndex = 8;
            button2.Text = "Изменить заголовок";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(284, 214);
            button3.Name = "button3";
            button3.Size = new Size(247, 49);
            button3.TabIndex = 9;
            button3.Text = "Изменить описание";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 443);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblCount);
            Controls.Add(splitter1);
            Controls.Add(lstQuestions);
            Controls.Add(lblFilePath);
            Controls.Add(btnAddQuestion);
            Controls.Add(label1);
            Controls.Add(cmbLevel);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbLevel;
        private Label label1;
        private Button btnAddQuestion;
        private Label lblFilePath;
        private ListBox lstQuestions;
        private Splitter splitter1;
        private Label lblCount;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}