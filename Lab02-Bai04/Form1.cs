using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai04
{
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }

        float tongSoTien = 0;

        public int Check(string index)
        {

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == index)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtTenTaiKhoan.Text == "" || txtSoTien.Text == "" || txtSoTaiKhoan.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Đầy Đầy Đủ Thông Tin!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (Check(txtSoTaiKhoan.Text) == -1)
                    {
                        ListViewItem lvi = new ListViewItem(txtSoTaiKhoan.Text);
                        lvi.SubItems.Add(txtTenTaiKhoan.Text);
                        lvi.SubItems.Add(txtDiaChi.Text);
                        lvi.SubItems.Add(txtSoTien.Text);
                        listView1.Items.Add(lvi);

                        tongSoTien += float.Parse(txtSoTien.Text);

                        MessageBox.Show("Thêm Thành Công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (i == Check(txtSoTaiKhoan.Text))
                            {
                                tongSoTien = (tongSoTien - float.Parse(listView1.Items[i].SubItems[3].Text) + float.Parse(txtSoTien.Text));

                                listView1.Items[i].SubItems[0].Text = txtSoTaiKhoan.Text;
                                listView1.Items[i].SubItems[1].Text = txtTenTaiKhoan.Text;
                                listView1.Items[i].SubItems[2].Text = txtDiaChi.Text;
                                listView1.Items[i].SubItems[3].Text = txtSoTien.Text;

                                MessageBox.Show("Cập Nhật Thành Công!", "THÔNG BÁO", MessageBoxButtons.OK);
                            }
                        }
                    } 
                }
                txtSoTien.Clear();
                txtTenTaiKhoan.Clear();
                txtDiaChi.Clear();
                txtSoTaiKhoan.Clear();

                txtTongTien.Text = tongSoTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = 120;
            listView1.Columns[1].Width = 120;
            listView1.Columns[2].Width = 120;
            listView1.Columns[3].Width = 120;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtSoTaiKhoan.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTenTaiKhoan.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtSoTien.Text = listView1.SelectedItems[0].SubItems[3].Text; 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (i == Check(txtSoTaiKhoan.Text))
                    {
                        flag = true;
                        DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            tongSoTien = tongSoTien - float.Parse(listView1.Items[i].SubItems[3].Text);
                            listView1.Items[i].Remove();                           
                        }
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Không Tìm Thấy Số Tài Khoản Cần Xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                txtTongTien.Text = tongSoTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Ban Muon Thoat?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
