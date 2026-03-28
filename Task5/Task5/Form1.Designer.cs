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
            tabControl1 = new TabControl();
            Dictonary = new TabPage();
            DeleteButton = new Button();
            AddButton = new Button();
            DictonaryLabel = new TextBox();
            DictonaryWordLabel = new Label();
            RichDictonary = new RichTextBox();
            WordMorph = new TabPage();
            FindButton = new Button();
            FindWordmorph = new Button();
            WordmorphTextbox = new TextBox();
            WordmorphLabel = new Label();
            RichWordmorph = new RichTextBox();
            tabControl1.SuspendLayout();
            Dictonary.SuspendLayout();
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
            tabControl1.Size = new Size(672, 512);
            tabControl1.TabIndex = 0;
            // 
            // Dictonary
            // 
            Dictonary.Controls.Add(FindButton);
            Dictonary.Controls.Add(DeleteButton);
            Dictonary.Controls.Add(AddButton);
            Dictonary.Controls.Add(DictonaryLabel);
            Dictonary.Controls.Add(DictonaryWordLabel);
            Dictonary.Controls.Add(RichDictonary);
            Dictonary.Location = new Point(4, 24);
            Dictonary.Name = "Dictonary";
            Dictonary.Padding = new Padding(3);
            Dictonary.Size = new Size(664, 484);
            Dictonary.TabIndex = 0;
            Dictonary.Text = "Словарь";
            Dictonary.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(82, 136);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(148, 41);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(82, 77);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(148, 41);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // DictonaryLabel
            // 
            DictonaryLabel.Location = new Point(23, 37);
            DictonaryLabel.Name = "DictonaryLabel";
            DictonaryLabel.Size = new Size(256, 23);
            DictonaryLabel.TabIndex = 2;
            // 
            // DictonaryWordLabel
            // 
            DictonaryWordLabel.AutoSize = true;
            DictonaryWordLabel.Location = new Point(23, 19);
            DictonaryWordLabel.Name = "DictonaryWordLabel";
            DictonaryWordLabel.Size = new Size(86, 15);
            DictonaryWordLabel.TabIndex = 1;
            DictonaryWordLabel.Text = "Введите слово";
            DictonaryWordLabel.Click += label1_Click;
            // 
            // RichDictonary
            // 
            RichDictonary.Location = new Point(338, 6);
            RichDictonary.Name = "RichDictonary";
            RichDictonary.Size = new Size(320, 472);
            RichDictonary.TabIndex = 0;
            RichDictonary.Text = "";
            // 
            // WordMorph
            // 
            WordMorph.Controls.Add(FindWordmorph);
            WordMorph.Controls.Add(WordmorphTextbox);
            WordMorph.Controls.Add(WordmorphLabel);
            WordMorph.Controls.Add(RichWordmorph);
            WordMorph.Location = new Point(4, 24);
            WordMorph.Name = "WordMorph";
            WordMorph.Padding = new Padding(3);
            WordMorph.Size = new Size(664, 484);
            WordMorph.TabIndex = 1;
            WordMorph.Text = "Работа со словоморфами";
            WordMorph.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(82, 194);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(148, 41);
            FindButton.TabIndex = 5;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = true;
            // 
            // FindWordmorph
            // 
            FindWordmorph.Location = new Point(74, 77);
            FindWordmorph.Name = "FindWordmorph";
            FindWordmorph.Size = new Size(148, 41);
            FindWordmorph.TabIndex = 7;
            FindWordmorph.Text = "Найти словоморфы";
            FindWordmorph.UseVisualStyleBackColor = true;
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
            // RichWordmorph
            // 
            RichWordmorph.Location = new Point(330, 6);
            RichWordmorph.Name = "RichWordmorph";
            RichWordmorph.Size = new Size(320, 472);
            RichWordmorph.TabIndex = 4;
            RichWordmorph.Text = "";
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
            WordMorph.ResumeLayout(false);
            WordMorph.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Dictonary;
        private TabPage WordMorph;
        private Label DictonaryWordLabel;
        private RichTextBox RichDictonary;
        private TextBox DictonaryLabel;
        private Button DeleteButton;
        private Button AddButton;
        private Button FindButton;
        private Button FindWordmorph;
        private TextBox WordmorphTextbox;
        private Label WordmorphLabel;
        private RichTextBox RichWordmorph;
    }
}
