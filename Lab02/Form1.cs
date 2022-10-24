using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);

                float result = number1 + number2;
                txtResult.Text = result.ToString();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);

                float result = number1 - number2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);

                float result = number1 * number2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);

                float result = number1 / number2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK);
            }
        }

    }
}
