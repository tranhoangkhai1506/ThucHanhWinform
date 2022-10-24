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
using System.Windows.Forms.VisualStyles;

namespace lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filename = "";
        private string fontName = "Tahoma";
        private float fontSize = 14f;
        private FontStyle fontStyle = FontStyle.Regular;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }

            for (int i = 8; i < 73; i += 2)
            {
                cmbSize.Items.Add(i);
            }

            cmbFonts.Text = fontName;
            cmbSize.Text = fontSize.ToString();
            richTextBox.Font = new Font(fontName, fontSize, fontStyle);
        }

        private void menuDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowApply = true;
            dlg.ShowEffects = true;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.ForeColor = dlg.Color;
                richTextBox.Font      = dlg.Font;
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = cmbFonts.Text;
            richTextBox.SelectionFont = new Font(fontName, fontSize, fontStyle);
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = float.Parse(cmbSize.Text);
            richTextBox.SelectionFont = new Font(fontName, fontSize, fontStyle);
        }

        private void tStripNew_Click(object sender, EventArgs e)
        {
            fontName = "Tahoma";
            fontSize = 14f;
            fontStyle = FontStyle.Regular;

            richTextBox.Text = "";
            cmbFonts.Text = fontName;
            cmbSize.Text = fontSize.ToString();
            richTextBox.Font = new Font(fontName, fontSize, fontStyle);
            filename = "";
        }

        private void tStripNew1_Click(object sender, EventArgs e)
        {
            fontName = "Tahoma";
            fontSize = 14f;
            fontStyle = FontStyle.Regular;

            richTextBox.Text = "";
            cmbFonts.Text = fontName;
            cmbSize.Text = fontSize.ToString();
            richTextBox.Font = new Font(fontName, fontSize, fontStyle);
            filename = "";
        }

        private void tStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text| *.txt | RTF File | *.rtf";
            dlg.DefaultExt = "*.rtf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename = dlg.FileName;
                richTextBox.LoadFile(filename);
            }
        }

        private void tStripbtnSave_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                    richTextBox.SaveFile(filename);
                }
            }
            else
            {
                richTextBox.SaveFile(filename);
                MessageBox.Show(String.Format("Saved file: {0}", filename));
            }
        }

        private void tStripSave1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.rtf";
            save.Filter = "RTF Files|*.rtf";

            if (filename == "")
            {
                if (save.ShowDialog() == DialogResult.OK && save.FileName.Length > 0)
                {
                    richTextBox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                richTextBox.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        private void tStripExit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Ban Muon Thoat?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void btnB_Click(object sender, EventArgs e)
        {
            fontStyle = FontStyle.Bold;
            richTextBox.SelectionFont = new Font(fontName, fontSize, fontStyle);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            fontStyle = FontStyle.Italic;
            richTextBox.SelectionFont = new Font(fontName, fontSize, fontStyle);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            fontStyle = FontStyle.Underline;
            richTextBox.SelectionFont = new Font(fontName, fontSize, fontStyle);
        }
    }
}
