namespace Task6
{
    partial class MainForm
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
            StartButton = new Button();
            ChooseButton = new Button();
            AdminButton = new Button();
            ChooseLabel = new Label();
            numericLevel = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericLevel).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(42, 89);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(246, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "Начать тест";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ChooseButton
            // 
            ChooseButton.Location = new Point(42, 159);
            ChooseButton.Name = "ChooseButton";
            ChooseButton.Size = new Size(246, 46);
            ChooseButton.TabIndex = 1;
            ChooseButton.Text = "Выбрать файл теста";
            ChooseButton.UseVisualStyleBackColor = true;
            ChooseButton.Click += ChooseButton_Click;
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(42, 446);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(246, 24);
            AdminButton.TabIndex = 2;
            AdminButton.Text = "Панель админа";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // ChooseLabel
            // 
            ChooseLabel.Location = new Point(42, 259);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(246, 137);
            ChooseLabel.TabIndex = 3;
            // 
            // numericLevel
            // 
            numericLevel.Location = new Point(211, 220);
            numericLevel.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericLevel.Name = "numericLevel";
            numericLevel.Size = new Size(58, 23);
            numericLevel.TabIndex = 4;
            numericLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 225);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Уровень сложности:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 482);
            Controls.Add(label1);
            Controls.Add(numericLevel);
            Controls.Add(ChooseLabel);
            Controls.Add(AdminButton);
            Controls.Add(ChooseButton);
            Controls.Add(StartButton);
            Name = "MainForm";
            Text = "Главное меню";
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button ChooseButton;
        private Button AdminButton;
        private Label ChooseLabel;
        private NumericUpDown numericLevel;
        private Label label1;
    }
}
