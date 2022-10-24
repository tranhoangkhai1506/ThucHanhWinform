using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab03_Bai03
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }
        public string Ma { set { this.Ma = value; } get { return txtMa.Text; } }

        public string Ten { set { this.Ten = value; } get { return txtTen.Text; } }

        public string Khoa { set { this.Khoa = value; } get { return cmbKhoa.Text; } }

        public string Diem { set { this.Diem = value; } get { return txtDiem.Text; } }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            cmbKhoa.Items.Add("CNTT");
            cmbKhoa.Items.Add("QTKD");
            cmbKhoa.Items.Add("NNA");
            cmbKhoa.SelectedIndex = 0;
        }
    }
}
