namespace Task3
{
    partial class Circle
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(92, 19);
            label1.Name = "label1";
            label1.Size = new Size(295, 30);
            label1.TabIndex = 0;
            label1.Text = "Программа демонстрирует использования таймера\r\nдля изменения положения фигуры";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(76, 405);
            button1.Name = "button1";
            button1.Size = new Size(146, 51);
            button1.TabIndex = 1;
            button1.Text = "СТАРТ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(261, 405);
            button2.Name = "button2";
            button2.Size = new Size(146, 51);
            button2.TabIndex = 2;
            button2.Text = "НАСТРОЙКИ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Circle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 503);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Circle";
            Text = "Движения круга";
            Paint += Circle_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
