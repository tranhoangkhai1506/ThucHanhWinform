using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai03
{
    public partial class frmRapChieuPhim : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int thanhToan = 0;
        public frmRapChieuPhim()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Ban Muon Thoat?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGhe1_Click(object sender, EventArgs e)
        {
            Button bnt = (Button) sender;
            if(bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                 MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe2_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                 MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe3_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                 MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe4_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                 MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe5_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe6_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe7_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe8_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe9_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe10_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe11_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe12_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe13_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhe14_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            if (bnt.BackColor != Color.Yellow)
            {
                if (bnt.BackColor == Color.White)
                {
                    bnt.BackColor = Color.Blue;
                    DanhSachChon.Add(bnt);
                }
                else
                {
                    bnt.BackColor = Color.White;
                    DanhSachChon.Remove(bnt);
                }
            }
            else
            {
                MessageBox.Show("Ghe Da Duoc Ban!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (Button bnt in DanhSachChon)
            {
                int dayGhe = Int32.Parse(bnt.Text);
                if(dayGhe <= 5)
                {
                    bnt.BackColor = Color.Yellow;
                    thanhToan += 5000;
                }
                if (5 < dayGhe  && dayGhe <= 10)
                {
                    bnt.BackColor = Color.Yellow;
                    thanhToan += 6500;
                }
                if (10 < dayGhe && dayGhe <= 15)
                {
                    bnt.BackColor = Color.Yellow;
                    thanhToan +=  8000;
                }
            }

            txtThanhTien.Text = thanhToan.ToString();
            thanhToan = 0;
            DanhSachChon = new List<Button>();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach(Button bnt in DanhSachChon)
            {
                bnt.BackColor = Color.White;
            }
            txtThanhTien.Text = "";
            DanhSachChon = new List<Button>();
        }

        private void frmRapChieuPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
