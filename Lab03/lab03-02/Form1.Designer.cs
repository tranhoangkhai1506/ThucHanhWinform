namespace lab03_02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStripNew = new System.Windows.Forms.ToolStripButton();
            this.tStripbtnSave = new System.Windows.Forms.ToolStripButton();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnB = new System.Windows.Forms.ToolStripButton();
            this.btnI = new System.Windows.Forms.ToolStripButton();
            this.btnU = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripNew1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripSave1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripNew,
            this.tStripbtnSave,
            this.cmbFonts,
            this.cmbSize,
            this.btnB,
            this.btnI,
            this.btnU});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStripNew
            // 
            this.tStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripNew.Image = ((System.Drawing.Image)(resources.GetObject("tStripNew.Image")));
            this.tStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripNew.Name = "tStripNew";
            this.tStripNew.Size = new System.Drawing.Size(29, 25);
            this.tStripNew.Text = "toolStripButton1";
            this.tStripNew.Click += new System.EventHandler(this.tStripNew_Click);
            // 
            // tStripbtnSave
            // 
            this.tStripbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tStripbtnSave.Image")));
            this.tStripbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripbtnSave.Name = "tStripbtnSave";
            this.tStripbtnSave.Size = new System.Drawing.Size(29, 25);
            this.tStripbtnSave.Text = "toolStripButton2";
            this.tStripbtnSave.Click += new System.EventHandler(this.tStripbtnSave_Click);
            // 
            // cmbFonts
            // 
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 28);
            this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.cmbFonts_SelectedIndexChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 28);
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // btnB
            // 
            this.btnB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(29, 25);
            this.btnB.Text = "toolStripButton3";
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnI
            // 
            this.btnI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnI.Image = ((System.Drawing.Image)(resources.GetObject("btnI.Image")));
            this.btnI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(29, 25);
            this.btnI.Text = "toolStripButton4";
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnU
            // 
            this.btnU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnU.Image = ((System.Drawing.Image)(resources.GetObject("btnU.Image")));
            this.btnU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(29, 25);
            this.btnU.Text = "toolStripButton5";
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripNew1,
            this.tStripOpen,
            this.tStripSave1,
            this.tStripExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.fileToolStripMenuItem.Text = "Hệ Thống";
            // 
            // tStripNew1
            // 
            this.tStripNew1.Image = ((System.Drawing.Image)(resources.GetObject("tStripNew1.Image")));
            this.tStripNew1.Name = "tStripNew1";
            this.tStripNew1.Size = new System.Drawing.Size(299, 26);
            this.tStripNew1.Text = "Tạo văn bản mới             Ctrl+N";
            this.tStripNew1.Click += new System.EventHandler(this.tStripNew1_Click);
            // 
            // tStripOpen
            // 
            this.tStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("tStripOpen.Image")));
            this.tStripOpen.Name = "tStripOpen";
            this.tStripOpen.Size = new System.Drawing.Size(299, 26);
            this.tStripOpen.Text = "Mở tập tin";
            this.tStripOpen.Click += new System.EventHandler(this.tStripOpen_Click);
            // 
            // tStripSave1
            // 
            this.tStripSave1.Image = ((System.Drawing.Image)(resources.GetObject("tStripSave1.Image")));
            this.tStripSave1.Name = "tStripSave1";
            this.tStripSave1.Size = new System.Drawing.Size(299, 26);
            this.tStripSave1.Text = "Lưu nội dung văn bản     Ctrl+S";
            this.tStripSave1.Click += new System.EventHandler(this.tStripSave1_Click);
            // 
            // tStripExit
            // 
            this.tStripExit.Name = "tStripExit";
            this.tStripExit.Size = new System.Drawing.Size(299, 26);
            this.tStripExit.Text = "Thoát";
            this.tStripExit.Click += new System.EventHandler(this.tStripExit_Click);
            // 
            // menuDinhDang
            // 
            this.menuDinhDang.Name = "menuDinhDang";
            this.menuDinhDang.Size = new System.Drawing.Size(92, 24);
            this.menuDinhDang.Text = "Định dạng";
            this.menuDinhDang.Click += new System.EventHandler(this.menuDinhDang_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 59);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 393);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tStripNew;
        private System.Windows.Forms.ToolStripButton tStripbtnSave;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.ToolStripButton btnB;
        private System.Windows.Forms.ToolStripButton btnI;
        private System.Windows.Forms.ToolStripButton btnU;
        private System.Windows.Forms.ToolStripMenuItem menuDinhDang;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem tStripNew1;
        private System.Windows.Forms.ToolStripMenuItem tStripOpen;
        private System.Windows.Forms.ToolStripMenuItem tStripSave1;
        private System.Windows.Forms.ToolStripMenuItem tStripExit;
    }
}

