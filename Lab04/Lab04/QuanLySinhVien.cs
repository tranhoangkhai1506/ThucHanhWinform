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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class QuanLySinhVien : Form
    {
        SinhVienContextDB context = new SinhVienContextDB();
        
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                List<Student> listSinhVien = context.Student.ToList();
                List<Faculty> listKhoa = context.Faculty.ToList();
                FillFacultyCmbKhoa(listKhoa);
                BrindGrid(listSinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       
        }

        private void FillFacultyCmbKhoa(List<Faculty> listKhoa)
        {
            this.cmbKhoa.DataSource = listKhoa;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";
        }

        private void BrindGrid(List<Student> listSinhVien)
        {
            dataGridView1.Rows.Clear();
            foreach(var item in listSinhVien)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        public bool kiemTra(string ma)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().CompareTo(ma) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHo.Text != "" && txtDiemTB.Text != "" && txtMa.Text != "")
                {
                    if (kiemTra(txtMa.Text) == true)
                    {
                        List<Faculty> listKhoa = context.Faculty.ToList();
                        Faculty faculty = listKhoa.FirstOrDefault(p => p.FacultyName == cmbKhoa.Text);
                        int maKhoa = faculty.FacultyID;
                        Student sv = new Student() { StudentID = txtMa.Text, FullName = txtHo.Text, FacultyID = maKhoa, AverageScore = double.Parse(txtDiemTB.Text) };
                        context.Student.Add(sv);
                        context.SaveChanges();
                        List<Student> listSinhVien = context.Student.ToList();
                        BrindGrid(listSinhVien);
                        MessageBox.Show("THEM THANH CONG!"); 
                    }
                    else
                    {
                        MessageBox.Show("MA DA CO!");
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

            txtMa.Text = "";
            txtHo.Text = "";
            txtDiemTB.Text = "";
            cmbKhoa.DisplayMember = "CNTT";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Student dbUpdate = context.Student.FirstOrDefault(p => p.StudentID == txtMa.Text);
                if (dbUpdate != null)
                {
                    if (txtHo.Text != "" && txtDiemTB.Text != "" && txtMa.Text != "")
                    {
                        List<Faculty> listKhoa = context.Faculty.ToList();
                        Faculty faculty = listKhoa.FirstOrDefault(p => p.FacultyName == cmbKhoa.Text);
                        int maKhoa = faculty.FacultyID;
                        dbUpdate.StudentID = txtMa.Text;
                        dbUpdate.FullName = txtHo.Text;
                        dbUpdate.FacultyID = maKhoa;
                        dbUpdate.AverageScore = double.Parse(txtDiemTB.Text);
                        context.SaveChanges();
                        List<Student> listSinhVien = context.Student.ToList();
                        BrindGrid(listSinhVien);
                        MessageBox.Show("SUA THANH CONG!");
                    }
                    else
                    {
                        MessageBox.Show("VUI LONG NHAP DAY DU THONG TIN!");
                    }
                }
                else
                {
                    MessageBox.Show("KHONG TIM THAY SINH VIEN CO MA: "+ txtMa.Text);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            try
            {
                Student dbDelete = context.Student.FirstOrDefault(p => p.StudentID == txtMa.Text);
                if (dbDelete != null)
                {
                    if (txtMa.Text != "")
                    {
                        DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            context.Student.Remove(dbDelete);
                            context.SaveChanges();
                            List<Student> listSinhVien = context.Student.ToList();
                            BrindGrid(listSinhVien);
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
                    MessageBox.Show("KHONG TIM THAY SINH VIEN CO MA: " + txtMa.Text);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Ban Muon Thoat?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtMa.Text = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                txtHo.Text = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                cmbKhoa.Text = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                txtDiemTB.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmFaculty frmFac = new frmFaculty();
            frmFac.Show();
        }

        private void btnCapNhatDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> listSinhVien = context.Student.ToList();
                List<Faculty> listKhoa = context.Faculty.ToList();
                FillFacultyCmbKhoa(listKhoa);
                BrindGrid(listSinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty frmFac = new frmFaculty();
            frmFac.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmFaculty frmFac = new frmFaculty();
            frmFac.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }
    }
}
