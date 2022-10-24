using Lab04_Bai4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Bai4
{
    public partial class frmThongTinDonHang : Form
    {
        SanPhamDbContext context = new SanPhamDbContext();
        public frmThongTinDonHang()
        {
            InitializeComponent();
        }

        private void BrindGrid(List<Invoice> listInvoice)
        {
            
            dataGridView1.Rows.Clear();
            int stt = 0;
            foreach (var item in listInvoice)
            {
                decimal sum = 0;
                List<Order> listOrder = context.Order.Where(p => p.InvoiceNo == item.InvoiceNo).ToList();
                foreach (Order i in listOrder)
                {
                    sum = sum + i.Quantity * i.Price;
                }
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = ++stt;
                dataGridView1.Rows[index].Cells[1].Value = item.InvoiceNo;
                dataGridView1.Rows[index].Cells[2].Value = item.OrderDate;
                dataGridView1.Rows[index].Cells[3].Value = item.DeliveryDate;
                dataGridView1.Rows[index].Cells[4].Value =sum.ToString();
            }

            txtTong.Text = listInvoice.Count.ToString();
        }

        private void frmThongTinDonHang_Load(object sender, EventArgs e)
        {
            List<Invoice> listInvoice = context.Invoice.Where(p => p.DeliveryDate == System.DateTime.Now).ToList();
            BrindGrid(listInvoice);
        }

        

        private void dtpNgayNhan_ValueChanged(object sender, EventArgs e)
        {
            List<Invoice> listInvoice = context.Invoice.Where(p => p.DeliveryDate < dtpNgayGiao1.Value && p.DeliveryDate < dtpNgayGiao2.Value).ToList();
            BrindGrid(listInvoice);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Invoice> listInvoice = context.Invoice.Where(p => p.DeliveryDate.Month == System.DateTime.Now.Month).ToList();
            BrindGrid(listInvoice);
        }
    }
}
