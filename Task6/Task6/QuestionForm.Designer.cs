namespace Task6
{
    partial class QuestionForm
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
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            btnAnswer = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            lblNoImage = new Label();
            lblQuestion = new Label();
            cmbAnswers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(522, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(224, 217);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(38, 92);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(167, 53);
            btnAnswer.TabIndex = 1;
            btnAnswer.Text = "button1";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(38, 242);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(38, 15);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "label1";
            // 
            // lblNoImage
            // 
            lblNoImage.AutoSize = true;
            lblNoImage.Location = new Point(522, 242);
            lblNoImage.Name = "lblNoImage";
            lblNoImage.Size = new Size(38, 15);
            lblNoImage.TabIndex = 3;
            lblNoImage.Text = "label1";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(38, 12);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(38, 15);
            lblQuestion.TabIndex = 4;
            lblQuestion.Text = "label1";
            // 
            // cmbAnswers
            // 
            cmbAnswers.FormattingEnabled = true;
            cmbAnswers.Location = new Point(38, 51);
            cmbAnswers.Name = "cmbAnswers";
            cmbAnswers.Size = new Size(205, 23);
            cmbAnswers.TabIndex = 5;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 278);
            Controls.Add(cmbAnswers);
            Controls.Add(lblQuestion);
            Controls.Add(lblNoImage);
            Controls.Add(lblTimer);
            Controls.Add(btnAnswer);
            Controls.Add(pictureBox);
            Name = "QuestionForm";
            Text = "Тест";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnAnswer;
        private System.Windows.Forms.Timer Timer;
        private Label lblTimer;
        private Label lblNoImage;
        private Label lblQuestion;
        private ComboBox cmbAnswers;
    }
}