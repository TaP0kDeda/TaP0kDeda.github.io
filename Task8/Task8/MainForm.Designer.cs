namespace Task8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripButton();
            this.exitMenuItem = new System.Windows.Forms.ToolStripButton();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripButton();
            this.resultsMenuItem = new System.Windows.Forms.ToolStripButton();
            this.helpMenuItem = new System.Windows.Forms.ToolStripButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.ToolStrip();
            this.scoreLabel = new System.Windows.Forms.ToolStripLabel();
            this.timeLabel = new System.Windows.Forms.ToolStripLabel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.spawnTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.exitMenuItem,
            this.settingsMenuItem,
            this.resultsMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(535, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "toolStrip1";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newGameMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameMenuItem.Image")));
            this.newGameMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(73, 22);
            this.newGameMenuItem.Text = "Новая игра";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuItem.Image")));
            this.exitMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Выход из игры";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsMenuItem.Image")));
            this.settingsMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(71, 22);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // resultsMenuItem
            // 
            this.resultsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resultsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resultsMenuItem.Image")));
            this.resultsMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resultsMenuItem.Name = "resultsMenuItem";
            this.resultsMenuItem.Size = new System.Drawing.Size(73, 22);
            this.resultsMenuItem.Text = "Результаты";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpMenuItem.Image")));
            this.helpMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(57, 22);
            this.helpMenuItem.Text = "Справка";
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(0, 28);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(634, 494);
            this.gamePanel.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreLabel,
            this.timeLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 525);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(535, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "toolStrip2";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 22);
            this.scoreLabel.Text = "toolStripLabel1";
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(86, 22);
            this.timeLabel.Text = "toolStripLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 550);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "Летящая ракета";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuStrip;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.ToolStrip statusStrip;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ToolStripButton newGameMenuItem;
        private System.Windows.Forms.ToolStripButton helpMenuItem;
        private System.Windows.Forms.ToolStripButton exitMenuItem;
        private System.Windows.Forms.ToolStripButton settingsMenuItem;
        private System.Windows.Forms.ToolStripButton resultsMenuItem;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer spawnTimer;
        private System.Windows.Forms.ToolStripLabel scoreLabel;
        private System.Windows.Forms.ToolStripLabel timeLabel;
    }
}

