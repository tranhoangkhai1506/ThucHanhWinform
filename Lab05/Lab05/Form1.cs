using Lab05.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StudentDbContext context = new StudentDbContext();
            List<Student> listStudent = context.Student.ToList();
            List<StudentReport> listReport = new List<StudentReport>();
            foreach (Student i in listStudent)
            {
                StudentReport temp = new StudentReport();
                temp.StudentID = i.StudentID;
                temp.StudentName = i.FullName;
                temp.AverageScore = i.AverageScore.ToString();
                temp.FacultyName = i.Faculty.FacultyName;
                listReport.Add(temp);
            }

            this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\WinFormC#\\ThucHanh\\Lab05\\Lab05\\rptStudentReport.rdlc";
            var reportDataSource = new ReportDataSource("StudentDataSet", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
