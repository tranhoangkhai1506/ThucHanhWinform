using Lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmTimKiem : Form
    {

        SinhVienContextDB context = new SinhVienContextDB();

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
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
            cmbKhoa.Text = "";
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
            foreach (var item in listSinhVien)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            cmbKhoa.ResetText();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Student> listStudents = context.Student.ToList();
            dataGridView1.Rows.Clear();
            int flag = -1;
            int dem = 0;
            foreach (var item in listStudents)
            {

                if (item.StudentID == txtMaSV.Text && item.FullName == txtHoTen.Text && item.FacultyID == (int)(cmbKhoa.SelectedIndex) + 1)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                    dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                    dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                    dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
                    flag = 1;
                    dem++;
                }
                else if ((item.StudentID == txtMaSV.Text && item.FullName == txtHoTen.Text) || (item.FullName == txtHoTen.Text && item.FacultyID == (int)(cmbKhoa.SelectedIndex) + 1) || (item.StudentID == txtMaSV.Text && item.FacultyID == (int)(cmbKhoa.SelectedIndex) + 1))
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                    dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                    dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                    dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
                    flag = 1;
                    dem++;
                }

                else if ((txtMaSV.Text == item.StudentID && txtHoTen.Text == "" && cmbKhoa.Text == "") || (txtMaSV.Text == "" && txtHoTen.Text == item.FullName && cmbKhoa.Text == "") || (txtMaSV.Text == "" && txtHoTen.Text == "" && (int)(cmbKhoa.SelectedIndex) + 1 == item.FacultyID))
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                    dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                    dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                    dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
                    flag = 1;
                    dem++;
                }
            }
            if (flag == -1)
                MessageBox.Show("Không có sinh viên cần tìm", "Thông báo", MessageBoxButtons.OK);
            textBox3.Text = dem.ToString();
        }
    

        private void outputTimKiem(List<Student> listTim)
        {
            dataGridView1.Rows.Clear();
            if(listTim.Count > 0)
            {
                dataGridView1.Rows.Clear();
                BrindGrid(listTim);
            }
            else
            {
                MessageBox.Show("KHONG TIM THAY!");
            }
        }
    }
}
