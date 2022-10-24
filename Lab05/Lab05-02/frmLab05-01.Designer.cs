namespace Lab05_02
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioXemGiaoHang = new System.Windows.Forms.RadioButton();
            this.radioXemBaoGia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 211);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioXemGiaoHang);
            this.groupBox1.Controls.Add(this.radioXemBaoGia);
            this.groupBox1.Location = new System.Drawing.Point(145, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xuat Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioXemGiaoHang
            // 
            this.radioXemGiaoHang.AutoSize = true;
            this.radioXemGiaoHang.Location = new System.Drawing.Point(130, 73);
            this.radioXemGiaoHang.Name = "radioXemGiaoHang";
            this.radioXemGiaoHang.Size = new System.Drawing.Size(160, 20);
            this.radioXemGiaoHang.TabIndex = 1;
            this.radioXemGiaoHang.Text = "Xem Phieu Giao Hang";
            this.radioXemGiaoHang.UseVisualStyleBackColor = true;
            // 
            // radioXemBaoGia
            // 
            this.radioXemBaoGia.AutoSize = true;
            this.radioXemBaoGia.Checked = true;
            this.radioXemBaoGia.Location = new System.Drawing.Point(130, 30);
            this.radioXemBaoGia.Name = "radioXemBaoGia";
            this.radioXemBaoGia.Size = new System.Drawing.Size(207, 20);
            this.radioXemBaoGia.TabIndex = 0;
            this.radioXemBaoGia.TabStop = true;
            this.radioXemBaoGia.Text = "Xem Bang Bao Gia San Pham";
            this.radioXemBaoGia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioXemGiaoHang;
        private System.Windows.Forms.RadioButton radioXemBaoGia;
    }
}

