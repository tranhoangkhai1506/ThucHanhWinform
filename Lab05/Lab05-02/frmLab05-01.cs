using Lab05_02.Models;
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

namespace Lab05_02
{
    public partial class Form1 : Form
    {
        ProductDbContext context = new ProductDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            comboBox1.Enabled = true;

            List<Invoice> listInvoice = context.Invoice.ToList();
            List<string> listMaHD = new List<string>();
            foreach (var item in listInvoice)
            {
                listMaHD.Add(item.InvoiceNo);
            }
            comboBox1.DataSource = listMaHD;
            comboBox1.DisplayMember = "InvoiceNo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioXemBaoGia.Checked == true)
            {
                List<Product> listProduct = context.Product.ToList();
                List<ProductReport> listReport = new List<ProductReport>();
                foreach (Product i in listProduct)
                {
                    ProductReport temp = new ProductReport();
                    temp.ProductID = i.ProductID;
                    temp.ProductName = i.ProductName;
                    temp.Unit = i.Unit;
                    temp.BuyPrice = i.BuyPrice.ToString();
                    listReport.Add(temp);
                }

                this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\WinFormC#\\ThucHanh\\Lab05\\Lab05-02\\rptProductReport.rdlc";
                var reportDataSource = new ReportDataSource("ProductDataSet", listReport);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            else
            {
                Invoice invoice = context.Invoice.FirstOrDefault(p => p.InvoiceNo == comboBox1.Text);
                List<Order> listOrder = context.Order.Where(p => p.InvoiceNo == invoice.InvoiceNo).ToList();
                List<OrderReport> listInvoiceReport = new List<OrderReport>();
                if(invoice == null || listOrder.Count() == 0)
                {
                    MessageBox.Show("Khong tim thay don hang!");
                    return;
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("InvoiveNo", invoice.InvoiceNo);
                param[1] = new ReportParameter("DeliveryDatestr", string.Format("Ngay " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));

                foreach (var item in listOrder)
                {
                    OrderReport temp = new OrderReport();
                    temp.ProductID = item.ProductID;
                    temp.ProductName = item.ProductName;
                    temp.Unit = item.Unit;
                    temp.Quantity = item.Quantity.ToString();
                    temp.Price = item.Price.ToString();
                    listInvoiceReport.Add(temp);
                }
                this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

                this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\WinFormC#\\ThucHanh\\Lab05\\Lab05-02\\rptOrderReport.rdlc";

                this.reportViewer1.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("OrderDataSet", listInvoiceReport);
                
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
