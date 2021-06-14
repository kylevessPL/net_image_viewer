namespace ImageEditor.Forms
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homogenityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilatationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openImageToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.saveImageToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.adjustToWindow = new System.Windows.Forms.ToolStripButton();
            this.copyToClipboardToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.pasteFromClipboardToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.viewToolStripMenuItem, this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.loadToolStripMenuItem, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.zoomInToolStripMenuItem, this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.colorsToolStripMenuItem, this.edgeDetectorsToolStripMenuItem, this.morphologyToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.grayscaleToolStripMenuItem, this.sepiaToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.colorsToolStripMenuItem.Text = "Color";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // edgeDetectorsToolStripMenuItem
            // 
            this.edgeDetectorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.homogenityToolStripMenuItem, this.differenceToolStripMenuItem, this.sobelToolStripMenuItem});
            this.edgeDetectorsToolStripMenuItem.Name = "edgeDetectorsToolStripMenuItem";
            this.edgeDetectorsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.edgeDetectorsToolStripMenuItem.Text = "Edge Detectors";
            // 
            // homogenityToolStripMenuItem
            // 
            this.homogenityToolStripMenuItem.Name = "homogenityToolStripMenuItem";
            this.homogenityToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.homogenityToolStripMenuItem.Text = "Homogenity";
            this.homogenityToolStripMenuItem.Click += new System.EventHandler(this.homogenityToolStripMenuItem_Click);
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.differenceToolStripMenuItem.Text = "Difference";
            this.differenceToolStripMenuItem.Click += new System.EventHandler(this.differenceToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.erosionToolStripMenuItem, this.dilatationToolStripMenuItem, this.openingToolStripMenuItem, this.closingToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // dilatationToolStripMenuItem
            // 
            this.dilatationToolStripMenuItem.Name = "dilatationToolStripMenuItem";
            this.dilatationToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.dilatationToolStripMenuItem.Text = "Dilatation";
            this.dilatationToolStripMenuItem.Click += new System.EventHandler(this.dilatationToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openImageToolbarButton, this.saveImageToolbarButton, this.zoomInToolbarButton, this.zoomOutToolbarButton, this.adjustToWindow, this.copyToClipboardToolbarButton, this.pasteFromClipboardToolbarButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openImageToolbarButton
            // 
            this.openImageToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openImageToolbarButton.Image = ((System.Drawing.Image) (resources.GetObject("openImageToolbarButton.Image")));
            this.openImageToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openImageToolbarButton.Name = "openImageToolbarButton";
            this.openImageToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.openImageToolbarButton.Text = "Open Image";
            this.openImageToolbarButton.Click += new System.EventHandler(this.openImageToolbarButton_Click);
            // 
            // saveImageToolbarButton
            // 
            this.saveImageToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveImageToolbarButton.Image = ((System.Drawing.Image) (resources.GetObject("saveImageToolbarButton.Image")));
            this.saveImageToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveImageToolbarButton.Name = "saveImageToolbarButton";
            this.saveImageToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.saveImageToolbarButton.Text = "Save Image";
            this.saveImageToolbarButton.Click += new System.EventHandler(this.saveImageToolbarButton_Click);
            // 
            // zoomInToolbarButton
            // 
            this.zoomInToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolbarButton.Image = ((System.Drawing.Image) (resources.GetObject("zoomInToolbarButton.Image")));
            this.zoomInToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolbarButton.Name = "zoomInToolbarButton";
            this.zoomInToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolbarButton.Text = "Zoom In";
            this.zoomInToolbarButton.Click += new System.EventHandler(this.zoomInToolbarButton_Click);
            // 
            // zoomOutToolbarButton
            // 
            this.zoomOutToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolbarButton.Image = ((System.Drawing.Image) (resources.GetObject("zoomOutToolbarButton.Image")));
            this.zoomOutToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolbarButton.Name = "zoomOutToolbarButton";
            this.zoomOutToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolbarButton.Text = "Zoom Out";
            this.zoomOutToolbarButton.Click += new System.EventHandler(this.zoomOutToolbarButton_Click);
            // 
            // adjustToWindow
            // 
            this.adjustToWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adjustToWindow.Image = ((System.Drawing.Image) (resources.GetObject("adjustToWindow.Image")));
            this.adjustToWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adjustToWindow.Name = "adjustToWindow";
            this.adjustToWindow.Size = new System.Drawing.Size(23, 22);
            this.adjustToWindow.Text = "Adjust to Window";
            this.adjustToWindow.Click += new System.EventHandler(this.adjustToWindow_Click);
            // 
            // copyToClipboardToolbarButton
            // 
            this.copyToClipboardToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToClipboardToolbarButton.Image = ((System.Drawing.Image) (resources.GetObject("copyToClipboardToolbarButton.Image")));
            this.copyToClipboardToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToClipboardToolbarButton.Name = "copyToClipboardToolbarButton";
            this.copyToClipboardToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.copyToClipboardToolbarButton.Text = "Copy to Clipboard";
            this.copyToClipboardToolbarButton.Click += new System.EventHandler(this.copyToClipboardToolbarButton_Click);
            // 
            // pasteFromClipboardToolbarButton
            // 
            this.pasteFromClipboardToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteFromClipboardToolbarButton.Image = ((System.Drawing.Image) (resources.GetObject("pasteFromClipboardToolbarButton.Image")));
            this.pasteFromClipboardToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteFromClipboardToolbarButton.Name = "pasteFromClipboardToolbarButton";
            this.pasteFromClipboardToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.pasteFromClipboardToolbarButton.Text = "Paste from Clipboard";
            this.pasteFromClipboardToolbarButton.Click += new System.EventHandler(this.pasteFromClipboardToolbarButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 382);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 382);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ImageViewer";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ToolStripButton adjustToWindow;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStripButton copyToClipboardToolbarButton;
        
        private System.Windows.Forms.ToolStripButton pasteFromClipboardToolbarButton;

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.ToolStripButton zoomOutToolbarButton;

        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton zoomInToolbarButton;

        private System.Windows.Forms.ToolStripButton saveImageToolbarButton;

        private System.Windows.Forms.ToolStripButton openImageToolbarButton;

        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilatationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem homogenityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem edgeDetectorsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}