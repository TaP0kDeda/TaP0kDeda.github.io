namespace Task3
{
    partial class Settings
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
            groupBox1 = new GroupBox();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Location = new Point(24, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Скорость";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(16, 34);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(245, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(24, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 144);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Форма кисти";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 105);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(68, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Квадрат";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Ромб";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(16, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Эллипс";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(116, 300);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Выбрать цвет";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(88, 433);
            button1.Name = "button1";
            button1.Size = new Size(141, 35);
            button1.TabIndex = 3;
            button1.Text = "Cброс настроек";
            button1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 480);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Settings";
            Text = "Form1";
            Load += Settings_Load;
            Paint += Settings_Paint;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button button1;
        private ColorDialog colorDialog1;
    }
}