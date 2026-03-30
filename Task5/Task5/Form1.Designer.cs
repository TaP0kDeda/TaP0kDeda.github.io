namespace Task5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            Dictonary = new TabPage();
            listBoxWords = new ListBox();
            statusLabel = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            FindButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            DictonaryText = new TextBox();
            DictonaryWordLabel = new Label();
            WordMorph = new TabPage();
            button1 = new Button();
            listBoxResults = new ListBox();
            FindWordmorph = new Button();
            WordmorphTextbox = new TextBox();
            WordmorphLabel = new Label();
            tabControl1.SuspendLayout();
            Dictonary.SuspendLayout();
            toolStrip1.SuspendLayout();
            WordMorph.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Dictonary);
            tabControl1.Controls.Add(WordMorph);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(670, 512);
            tabControl1.TabIndex = 0;
            // 
            // Dictonary
            // 
            Dictonary.Controls.Add(listBoxWords);
            Dictonary.Controls.Add(statusLabel);
            Dictonary.Controls.Add(toolStrip1);
            Dictonary.Controls.Add(FindButton);
            Dictonary.Controls.Add(DeleteButton);
            Dictonary.Controls.Add(AddButton);
            Dictonary.Controls.Add(DictonaryText);
            Dictonary.Controls.Add(DictonaryWordLabel);
            Dictonary.Location = new Point(4, 24);
            Dictonary.Name = "Dictonary";
            Dictonary.Padding = new Padding(3);
            Dictonary.Size = new Size(662, 484);
            Dictonary.TabIndex = 0;
            Dictonary.Text = "Словарь";
            Dictonary.UseVisualStyleBackColor = true;
            // 
            // listBoxWords
            // 
            listBoxWords.FormattingEnabled = true;
            listBoxWords.ItemHeight = 15;
            listBoxWords.Location = new Point(303, 36);
            listBoxWords.Name = "listBoxWords";
            listBoxWords.Size = new Size(351, 439);
            listBoxWords.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(3, 463);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 15);
            statusLabel.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(656, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(71, 22);
            toolStripButton1.Text = "Импорт";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(72, 22);
            toolStripButton2.Text = "Экспорт";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(70, 22);
            toolStripButton3.Text = "Создать";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(71, 22);
            toolStripButton4.Text = "Удалить";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(82, 205);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(148, 41);
            FindButton.TabIndex = 5;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(82, 147);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(148, 41);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(82, 88);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(148, 41);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DictonaryText
            // 
            DictonaryText.Location = new Point(23, 48);
            DictonaryText.Name = "DictonaryText";
            DictonaryText.Size = new Size(256, 23);
            DictonaryText.TabIndex = 2;
            // 
            // DictonaryWordLabel
            // 
            DictonaryWordLabel.AutoSize = true;
            DictonaryWordLabel.Location = new Point(23, 30);
            DictonaryWordLabel.Name = "DictonaryWordLabel";
            DictonaryWordLabel.Size = new Size(86, 15);
            DictonaryWordLabel.TabIndex = 1;
            DictonaryWordLabel.Text = "Введите слово";
            DictonaryWordLabel.Click += label1_Click;
            // 
            // WordMorph
            // 
            WordMorph.Controls.Add(button1);
            WordMorph.Controls.Add(listBoxResults);
            WordMorph.Controls.Add(FindWordmorph);
            WordMorph.Controls.Add(WordmorphTextbox);
            WordMorph.Controls.Add(WordmorphLabel);
            WordMorph.Location = new Point(4, 24);
            WordMorph.Name = "WordMorph";
            WordMorph.Padding = new Padding(3);
            WordMorph.Size = new Size(662, 484);
            WordMorph.TabIndex = 1;
            WordMorph.Text = "Работа со словоморфами";
            WordMorph.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(74, 133);
            button1.Name = "button1";
            button1.Size = new Size(148, 43);
            button1.TabIndex = 9;
            button1.Text = "Поиск по Левенштейну";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(330, 6);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(324, 469);
            listBoxResults.TabIndex = 8;
            // 
            // FindWordmorph
            // 
            FindWordmorph.Location = new Point(74, 77);
            FindWordmorph.Name = "FindWordmorph";
            FindWordmorph.Size = new Size(148, 41);
            FindWordmorph.TabIndex = 7;
            FindWordmorph.Text = "Найти словоморфы";
            FindWordmorph.UseVisualStyleBackColor = true;
            FindWordmorph.Click += FindWordmorph_Click;
            // 
            // WordmorphTextbox
            // 
            WordmorphTextbox.Location = new Point(15, 37);
            WordmorphTextbox.Name = "WordmorphTextbox";
            WordmorphTextbox.Size = new Size(256, 23);
            WordmorphTextbox.TabIndex = 6;
            // 
            // WordmorphLabel
            // 
            WordmorphLabel.AutoSize = true;
            WordmorphLabel.Location = new Point(15, 19);
            WordmorphLabel.Name = "WordmorphLabel";
            WordmorphLabel.Size = new Size(86, 15);
            WordmorphLabel.TabIndex = 5;
            WordmorphLabel.Text = "Введите слово";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 506);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Работа со словарем";
            tabControl1.ResumeLayout(false);
            Dictonary.ResumeLayout(false);
            Dictonary.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            WordMorph.ResumeLayout(false);
            WordMorph.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Dictonary;
        private TabPage WordMorph;
        private Label DictonaryWordLabel;
        private TextBox DictonaryText;
        private Button DeleteButton;
        private Button AddButton;
        private Button FindButton;
        private Button FindWordmorph;
        private TextBox WordmorphTextbox;
        private Label WordmorphLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private Label statusLabel;
        private ListBox listBoxWords;
        private Button button1;
        private ListBox listBoxResults;
    }
}
