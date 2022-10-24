namespace Lab05_03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioTheoNgay = new System.Windows.Forms.RadioButton();
            this.radioTheoThang = new System.Windows.Forms.RadioButton();
            this.radioTuNgay = new System.Windows.Forms.RadioButton();
            this.dtpXemTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTheoThang = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTuNgay2);
            this.groupBox1.Controls.Add(this.dtpTuNgay1);
            this.groupBox1.Controls.Add(this.dtpTheoThang);
            this.groupBox1.Controls.Add(this.dtpXemTheoNgay);
            this.groupBox1.Controls.Add(this.radioTuNgay);
            this.groupBox1.Controls.Add(this.radioTheoThang);
            this.groupBox1.Controls.Add(this.radioTheoNgay);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Don Hang";
            // 
            // radioTheoNgay
            // 
            this.radioTheoNgay.AutoSize = true;
            this.radioTheoNgay.Location = new System.Drawing.Point(133, 39);
            this.radioTheoNgay.Name = "radioTheoNgay";
            this.radioTheoNgay.Size = new System.Drawing.Size(126, 20);
            this.radioTheoNgay.TabIndex = 1;
            this.radioTheoNgay.TabStop = true;
            this.radioTheoNgay.Text = "Xem Theo Ngay";
            this.radioTheoNgay.UseVisualStyleBackColor = true;
            // 
            // radioTheoThang
            // 
            this.radioTheoThang.AutoSize = true;
            this.radioTheoThang.Location = new System.Drawing.Point(133, 77);
            this.radioTheoThang.Name = "radioTheoThang";
            this.radioTheoThang.Size = new System.Drawing.Size(120, 20);
            this.radioTheoThang.TabIndex = 2;
            this.radioTheoThang.TabStop = true;
            this.radioTheoThang.Text = "Xem theo thang";
            this.radioTheoThang.UseVisualStyleBackColor = true;
            // 
            // radioTuNgay
            // 
            this.radioTuNgay.AutoSize = true;
            this.radioTuNgay.Location = new System.Drawing.Point(133, 116);
            this.radioTuNgay.Name = "radioTuNgay";
            this.radioTuNgay.Size = new System.Drawing.Size(101, 20);
            this.radioTuNgay.TabIndex = 3;
            this.radioTuNgay.TabStop = true;
            this.radioTuNgay.Text = "Xem tu ngay";
            this.radioTuNgay.UseVisualStyleBackColor = true;
            // 
            // dtpXemTheoNgay
            // 
            this.dtpXemTheoNgay.Location = new System.Drawing.Point(267, 39);
            this.dtpXemTheoNgay.Name = "dtpXemTheoNgay";
            this.dtpXemTheoNgay.Size = new System.Drawing.Size(177, 22);
            this.dtpXemTheoNgay.TabIndex = 4;
            // 
            // dtpTheoThang
            // 
            this.dtpTheoThang.Location = new System.Drawing.Point(267, 77);
            this.dtpTheoThang.Name = "dtpTheoThang";
            this.dtpTheoThang.Size = new System.Drawing.Size(177, 22);
            this.dtpTheoThang.TabIndex = 5;
            // 
            // dtpTuNgay1
            // 
            this.dtpTuNgay1.Location = new System.Drawing.Point(267, 116);
            this.dtpTuNgay1.Name = "dtpTuNgay1";
            this.dtpTuNgay1.Size = new System.Drawing.Size(177, 22);
            this.dtpTuNgay1.TabIndex = 6;
            // 
            // dtpTuNgay2
            // 
            this.dtpTuNgay2.Location = new System.Drawing.Point(498, 116);
            this.dtpTuNgay2.Name = "dtpTuNgay2";
            this.dtpTuNgay2.Size = new System.Drawing.Size(177, 22);
            this.dtpTuNgay2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay1;
        private System.Windows.Forms.DateTimePicker dtpTheoThang;
        private System.Windows.Forms.DateTimePicker dtpXemTheoNgay;
        private System.Windows.Forms.RadioButton radioTuNgay;
        private System.Windows.Forms.RadioButton radioTheoThang;
        private System.Windows.Forms.RadioButton radioTheoNgay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

