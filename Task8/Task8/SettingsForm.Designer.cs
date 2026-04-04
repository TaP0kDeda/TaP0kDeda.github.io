namespace Task8
{
    partial class SettingsForm
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
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRocketColor = new System.Windows.Forms.Button();
            this.btnLargeColor = new System.Windows.Forms.Button();
            this.btnSmallColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(167, 23);
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(62, 20);
            this.numTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Максимальное время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цель сбора";
            // 
            // numTarget
            // 
            this.numTarget.Location = new System.Drawing.Point(167, 63);
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(62, 20);
            this.numTarget.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сложность игры";
            // 
            // btnRocketColor
            // 
            this.btnRocketColor.Location = new System.Drawing.Point(61, 144);
            this.btnRocketColor.Name = "btnRocketColor";
            this.btnRocketColor.Size = new System.Drawing.Size(137, 31);
            this.btnRocketColor.TabIndex = 6;
            this.btnRocketColor.Text = "Цвет корабля";
            this.btnRocketColor.UseVisualStyleBackColor = true;
            // 
            // btnLargeColor
            // 
            this.btnLargeColor.Location = new System.Drawing.Point(61, 218);
            this.btnLargeColor.Name = "btnLargeColor";
            this.btnLargeColor.Size = new System.Drawing.Size(137, 31);
            this.btnLargeColor.TabIndex = 7;
            this.btnLargeColor.Text = "Цвет больших";
            this.btnLargeColor.UseVisualStyleBackColor = true;
            // 
            // btnSmallColor
            // 
            this.btnSmallColor.Location = new System.Drawing.Point(61, 181);
            this.btnSmallColor.Name = "btnSmallColor";
            this.btnSmallColor.Size = new System.Drawing.Size(137, 31);
            this.btnSmallColor.TabIndex = 8;
            this.btnSmallColor.Text = "Цвет малых";
            this.btnSmallColor.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(167, 107);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cmbDifficulty.TabIndex = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 314);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSmallColor);
            this.Controls.Add(this.btnLargeColor);
            this.Controls.Add(this.btnRocketColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTime);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRocketColor;
        private System.Windows.Forms.Button btnLargeColor;
        private System.Windows.Forms.Button btnSmallColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDifficulty;
    }
}