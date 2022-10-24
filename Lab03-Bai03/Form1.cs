using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        public int kiemTra(string ma)
        {
            for (int i = 0; i < dvgSinhVien.Rows.Count; i++)
            {
                if (dvgSinhVien.Rows[i].Cells[1].Value.ToString().CompareTo(ma) == 0)
                {
                    return i;
                }
            }
    
            return -1;
        }

        private void themSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSinhVien themSinhVien = new ThemSinhVien();
        
            if (themSinhVien.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dvgSinhVien.Rows.Count; i++)
                {
                    if (kiemTra(themSinhVien.Ma) != -1)
                    {
                        MessageBox.Show("Ma da co");
                    }
                    else

                    {
                        int index = dvgSinhVien.Rows.Add();
                        dvgSinhVien.Rows[index].Cells[0].Value = index + 1;
                        dvgSinhVien.Rows[index].Cells[1].Value = themSinhVien.Ma;
                        dvgSinhVien.Rows[index].Cells[2].Value = themSinhVien.Ten;
                        dvgSinhVien.Rows[index].Cells[3].Value = themSinhVien.Khoa;
                        dvgSinhVien.Rows[index].Cells[4].Value = themSinhVien.Diem;
                    }
                        
                }

            }
        }
            
        
    }
}
