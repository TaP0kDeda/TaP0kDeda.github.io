namespace Task7
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
            toolStrip1 = new ToolStrip();
            fileDropDown = new ToolStripDropDownButton();
            saveDropDown = new ToolStripMenuItem();
            importDropDown = new ToolStripMenuItem();
            newFileDropDown = new ToolStripMenuItem();
            aboutButton = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            newFileButton = new ToolStripButton();
            importButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cutButton = new ToolStripButton();
            copyButton = new ToolStripButton();
            parseButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            backButton = new ToolStripButton();
            forwardButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            mouseButton = new ToolStripButton();
            squareButton = new ToolStripButton();
            rectangleButton = new ToolStripButton();
            crossButton = new ToolStripButton();
            pButton = new ToolStripButton();
            panelCanvas = new Panel();
            colorDialog1 = new ColorDialog();
            colorButton = new Button();
            widthCombo = new ComboBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gainsboro;
            toolStrip1.Items.AddRange(new ToolStripItem[] { fileDropDown, aboutButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // fileDropDown
            // 
            fileDropDown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileDropDown.DropDownItems.AddRange(new ToolStripItem[] { saveDropDown, importDropDown, newFileDropDown });
            fileDropDown.Image = (Image)resources.GetObject("fileDropDown.Image");
            fileDropDown.ImageTransparentColor = Color.Magenta;
            fileDropDown.Name = "fileDropDown";
            fileDropDown.Size = new Size(49, 22);
            fileDropDown.Text = "Файл";
            // 
            // saveDropDown
            // 
            saveDropDown.Name = "saveDropDown";
            saveDropDown.Size = new Size(162, 22);
            saveDropDown.Text = "Сохранить";
            // 
            // importDropDown
            // 
            importDropDown.Name = "importDropDown";
            importDropDown.Size = new Size(162, 22);
            importDropDown.Text = "Импортировать";
            // 
            // newFileDropDown
            // 
            newFileDropDown.Name = "newFileDropDown";
            newFileDropDown.Size = new Size(162, 22);
            newFileDropDown.Text = "Новый файл";
            // 
            // aboutButton
            // 
            aboutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            aboutButton.Image = (Image)resources.GetObject("aboutButton.Image");
            aboutButton.ImageTransparentColor = Color.Magenta;
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(57, 22);
            aboutButton.Text = "Справка";
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = Color.Gainsboro;
            toolStrip2.Items.AddRange(new ToolStripItem[] { newFileButton, importButton, saveButton, toolStripSeparator1, cutButton, copyButton, parseButton, toolStripSeparator2, backButton, forwardButton, toolStripSeparator3, mouseButton, squareButton, rectangleButton, crossButton, pButton });
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(0);
            toolStrip2.Size = new Size(800, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // newFileButton
            // 
            newFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newFileButton.Image = (Image)resources.GetObject("newFileButton.Image");
            newFileButton.ImageTransparentColor = Color.Magenta;
            newFileButton.Name = "newFileButton";
            newFileButton.Size = new Size(23, 22);
            newFileButton.Text = "toolStripButton1";
            // 
            // importButton
            // 
            importButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            importButton.Image = (Image)resources.GetObject("importButton.Image");
            importButton.ImageTransparentColor = Color.Magenta;
            importButton.Name = "importButton";
            importButton.Size = new Size(23, 22);
            importButton.Text = "toolStripButton2";
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(23, 22);
            saveButton.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // cutButton
            // 
            cutButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutButton.Image = (Image)resources.GetObject("cutButton.Image");
            cutButton.ImageTransparentColor = Color.Magenta;
            cutButton.Name = "cutButton";
            cutButton.Size = new Size(23, 22);
            cutButton.Text = "toolStripButton1";
            // 
            // copyButton
            // 
            copyButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyButton.Image = (Image)resources.GetObject("copyButton.Image");
            copyButton.ImageTransparentColor = Color.Magenta;
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(23, 22);
            copyButton.Text = "toolStripButton2";
            // 
            // parseButton
            // 
            parseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            parseButton.Image = (Image)resources.GetObject("parseButton.Image");
            parseButton.ImageTransparentColor = Color.Magenta;
            parseButton.Name = "parseButton";
            parseButton.Size = new Size(23, 22);
            parseButton.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // backButton
            // 
            backButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.ImageTransparentColor = Color.Magenta;
            backButton.Name = "backButton";
            backButton.Size = new Size(23, 22);
            backButton.Text = "toolStripButton1";
            // 
            // forwardButton
            // 
            forwardButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.ImageTransparentColor = Color.Magenta;
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(23, 22);
            forwardButton.Text = "toolStripButton2";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // mouseButton
            // 
            mouseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mouseButton.Image = (Image)resources.GetObject("mouseButton.Image");
            mouseButton.ImageTransparentColor = Color.Magenta;
            mouseButton.Name = "mouseButton";
            mouseButton.Size = new Size(23, 22);
            mouseButton.Text = "toolStripButton1";
            // 
            // squareButton
            // 
            squareButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            squareButton.Image = (Image)resources.GetObject("squareButton.Image");
            squareButton.ImageTransparentColor = Color.Magenta;
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(23, 22);
            squareButton.Text = "toolStripButton1";
            // 
            // rectangleButton
            // 
            rectangleButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rectangleButton.Image = (Image)resources.GetObject("rectangleButton.Image");
            rectangleButton.ImageTransparentColor = Color.Magenta;
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(23, 22);
            rectangleButton.Text = "toolStripButton1";
            // 
            // crossButton
            // 
            crossButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            crossButton.Image = (Image)resources.GetObject("crossButton.Image");
            crossButton.ImageTransparentColor = Color.Magenta;
            crossButton.Name = "crossButton";
            crossButton.Size = new Size(23, 22);
            crossButton.Text = "toolStripButton1";
            // 
            // pButton
            // 
            pButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pButton.Image = (Image)resources.GetObject("pButton.Image");
            pButton.ImageTransparentColor = Color.Magenta;
            pButton.Name = "pButton";
            pButton.Size = new Size(23, 22);
            pButton.Text = "toolStripButton1";
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = SystemColors.Window;
            panelCanvas.Location = new Point(0, 53);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(800, 344);
            panelCanvas.TabIndex = 2;
            // 
            // colorButton
            // 
            colorButton.Location = new Point(9, 405);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(119, 36);
            colorButton.TabIndex = 3;
            colorButton.Text = "Выбор цвета";
            colorButton.UseVisualStyleBackColor = true;
            // 
            // widthCombo
            // 
            widthCombo.FormattingEnabled = true;
            widthCombo.Items.AddRange(new object[] { "1px", "2px", "3px", "4px", "5px" });
            widthCombo.Location = new Point(237, 413);
            widthCombo.Name = "widthCombo";
            widthCombo.Size = new Size(121, 23);
            widthCombo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 416);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 5;
            label1.Text = "Ширина контура:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(widthCombo);
            Controls.Add(colorButton);
            Controls.Add(panelCanvas);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "Упрощенный векторный редактор";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStrip toolStrip2;
        private ToolStripDropDownButton fileDropDown;
        private ToolStripMenuItem saveDropDown;
        private ToolStripMenuItem importDropDown;
        private ToolStripMenuItem newFileDropDown;
        private ToolStripButton aboutButton;
        private ToolStripButton newFileButton;
        private ToolStripButton importButton;
        private ToolStripButton saveButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cutButton;
        private ToolStripButton copyButton;
        private ToolStripButton parseButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton backButton;
        private ToolStripButton forwardButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton mouseButton;
        private ToolStripButton squareButton;
        private ToolStripButton rectangleButton;
        private ToolStripButton crossButton;
        private ToolStripButton pButton;
        private Panel panelCanvas;
        private ColorDialog colorDialog1;
        private Button colorButton;
        private ComboBox widthCombo;
        private Label label1;
    }
}
