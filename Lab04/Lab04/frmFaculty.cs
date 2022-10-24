using Lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmFaculty : Form
    {
        SinhVienContextDB context = new SinhVienContextDB();
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                List<Faculty> listKhoa = context.Faculty.ToList();
                BrindGrid(listKhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BrindGrid(List<Faculty> listKhoa)
        {
            dgvKhoa.Rows.Clear();
            foreach (var item in listKhoa)
            {
                int index = dgvKhoa.Rows.Add();
                dgvKhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dgvKhoa.Rows[index].Cells[1].Value = item.FacultyName;
                dgvKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        public bool kiemTra(string ma)
        {
            for(int i = 0; i < dgvKhoa.Rows.Count; i++)
            {
                if (dgvKhoa.Rows[i].Cells[0].Value.ToString().CompareTo(ma) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text != "" && txtTenKhoa.Text != "" && txtSLGS.Text != "")
                {
                    if (kiemTra(txtMaKhoa.Text) == true)
                    {
                        Faculty khoa = new Faculty() { FacultyID = int.Parse(txtMaKhoa.Text), FacultyName = txtTenKhoa.Text, TotalProfessor = int.Parse(txtSLGS.Text)  };
                        context.Faculty.Add(khoa);
                        context.SaveChanges();
                        List<Faculty> listKhoa = context.Faculty.ToList();
                        BrindGrid(listKhoa);
                        MessageBox.Show("THEM THANH CONG!");
                    }
                    else
                    {
                        int maKhoa = int.Parse(txtMaKhoa.Text);
                        Faculty updataSV = context.Faculty.FirstOrDefault(p => p.FacultyID == maKhoa);

                        updataSV.FacultyID = int.Parse(txtMaKhoa.Text);
                        updataSV.FacultyName = txtTenKhoa.Text;
                        updataSV.TotalProfessor = int.Parse(txtSLGS.Text);
                        context.SaveChanges();
                        List<Faculty> listKhoa = context.Faculty.ToList();
                        BrindGrid(listKhoa);
                        MessageBox.Show("SUA THANH CONG!");

                    }
                }
                else
                {
                    MessageBox.Show("VUI LONG NHAP DAY DU THONG TIN!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtSLGS.Text = "";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maKhoa = int.Parse(txtMaKhoa.Text);
                Faculty dbDelete = context.Faculty.FirstOrDefault(p => p.FacultyID == maKhoa);
                if (dbDelete != null)
                {
                    if (txtMaKhoa.Text != "")
                    {
                        DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            context.Faculty.Remove(dbDelete);
                            context.SaveChanges();
                            List<Faculty> listKhoa = context.Faculty.ToList();
                            BrindGrid(listKhoa);
                            MessageBox.Show("XOA THANH CONG!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("VUI LONG MA SINH VIEN CAN XOA!");
                    }
                }
                else
                {
                    MessageBox.Show("KHONG TIM THAY SINH VIEN CO MA: " + txtMaKhoa.Text);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                txtTenKhoa.Text = (string)dgvKhoa.SelectedRows[0].Cells[1].Value;
                txtSLGS.Text = Convert.ToString(dgvKhoa.SelectedRows[0].Cells[2].Value);
                txtMaKhoa.Text = Convert.ToString(dgvKhoa.SelectedRows[0].Cells[0].Value);
            }
        }
    }
}
