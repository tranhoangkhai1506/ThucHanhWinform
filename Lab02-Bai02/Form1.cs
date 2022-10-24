using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChuyenNganh.SelectedIndex = 0;
        }

        private int GetSelectedRow(string mssv)
        {
            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                if (dgvSinhVien.Rows[i].Cells[0].Value.ToString() == mssv)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvSinhVien.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvSinhVien.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvSinhVien.Rows[selectedRow].Cells[2].Value = rbtnNam.Checked ? "Nam" : "Nữ";
            dgvSinhVien.Rows[selectedRow].Cells[3].Value = float.Parse(txtDTB.Text).ToString();
            dgvSinhVien.Rows[selectedRow].Cells[4].Value = cbChuyenNganh.Text;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if(selectedRow == -1)
                {
                    selectedRow = dgvSinhVien.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("THÊM DỮ LIỆU THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("ĐÃ CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            int tongNam = 0;
            int tongNu = 0;
            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                if (dgvSinhVien.Rows[i].Cells[2].Value.ToString() == "Nam")
                {
                    tongNam++;
                }
                else{
                    tongNu++;
                }
            }
            txtTongNam.Text = tongNam.ToString();
            txtTongNu.Text = tongNu.ToString();

            txtDTB.Clear();
            txtHoTen.Clear();
            txtMSSV.Clear();
            rbtnNu.Checked = true;
            cbChuyenNganh.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int seltectedRow = GetSelectedRow(txtMSSV.Text);
                if(seltectedRow == -1)
                {
                    throw new Exception("Khong Tim Thay Sinh Vien!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban Co Muon Xoa", "Xac Nhan", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgvSinhVien.Rows.RemoveAt(seltectedRow);
                        MessageBox.Show("Da Xoa Thanh Cong", "Thong Bao", MessageBoxButtons.OK);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            int tongNam = 0;
            int tongNu = 0;
            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                if (dgvSinhVien.Rows[i].Cells[2].Value.ToString() == "Nam")
                {
                    tongNam++;
                }
                else
                {
                    tongNu++;
                }
            }
            txtTongNam.Text = tongNam.ToString();
            txtTongNu.Text = tongNu.ToString();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSinhVien.Rows[e.RowIndex];

                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtDTB.Text = row.Cells[3].Value.ToString();

                switch(row.Cells[4].Value.ToString())
                {
                    case "QTKD":
                        cbChuyenNganh.SelectedIndex = 0;
                        break;
                    case "CNTT":
                        cbChuyenNganh.SelectedIndex = 1;
                        break;
                    case "KY THUAT OTO":
                        cbChuyenNganh.SelectedIndex = 2;
                        break;
                    case "NGON NGU ANH":
                        cbChuyenNganh.SelectedIndex = 3;
                        break;
                    case "TAI CHINH NGAN HANG":
                        cbChuyenNganh.SelectedIndex = 4;
                        break;

                }
            }
        }
    }
}
