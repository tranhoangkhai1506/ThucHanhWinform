using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai02
{
    public partial class SoanThaoVanBan : Form
    {
        public SoanThaoVanBan()
        {
            InitializeComponent();
        }
        string fileName = "";
        private void đỊNHDẠNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fontDialog.Color;
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void SoanThaoVanBan_Load(object sender, EventArgs e)
        {
            foreach(FontFamily i in new InstalledFontCollection().Families)
            {
                cbFont.Items.Add(i.Name);
            }
            cbFont.SelectedIndex = 0;
            cbSize.SelectedIndex = 1;
            richTextBox1.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.SelectionFont = new Font("Tahoma", 18, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text| *.txt | RTF File | *.rtf";          
            dlg.DefaultExt = "*.rtf";
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName.Length > 0)
            {
                fileName = dlg.FileName;
                richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);  
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (fileName == "")
            {
                if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            }           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Ban Muon Thoat?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbSize_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cbFont.Text, float.Parse(cbSize.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (fileName == "")
            {
                if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void bntB_Click(object sender, EventArgs e)
        {
            if (bntB.Checked)
            {
                richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text), FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text));
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (btnI.Checked)
            {
                richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text), FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text));
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (btnU.Checked)
            {
                richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text), FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text));
            }
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text));
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(cbFont.Text, float.Parse(cbSize.Text));
        }
    }
}
