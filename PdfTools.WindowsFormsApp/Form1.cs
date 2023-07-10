using PayamHannan.PdfTools;
using PayamHannan.PdfTools.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfTools.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetPath()
        {
            var path = string.Empty;
            var fdlg = new OpenFileDialog();
            fdlg.Title = "SelectFile";
            fdlg.InitialDirectory = @"c:\\";

            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
                path = fdlg.FileName;
            return path;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetPath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            var STR = PdfToText.pdfText(textBox1.Text);
            MessageBox.Show(STR);
        }
    }
}
