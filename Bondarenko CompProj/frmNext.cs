using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bondarenko_CompProj
{
    public partial class frmNext : Form
    {
        public frmMain main_form;
        public frmNext()
        {
            InitializeComponent();
            AddOwnedForm(main_form);
        }

        string[] sText;
        string path;
        int Count, n, nMain, p1, p2, p3, p4, p5;

        void LoadPict()
        {
            string st;
            st = nMain.ToString() + ".jpg";
            pctMain.Load(path + st);
            label1.Text = sText[nMain - 1];

            if (n <= Count - 4)
            {
                pct1.Load(path + n.ToString() + ".jpg");
                p1 = n;
                pct2.Load(path + (n + 1).ToString() + ".jpg");
                p2 = n + 1;
                pct3.Load(path + (n + 2).ToString() + ".jpg");
                p3 = n + 2;
                pct4.Load(path + (n + 3).ToString() + ".jpg");
                p4 = n + 3;
                pct5.Load(path + (n + 4).ToString() + ".jpg");
                p5 = n + 4;
            }
            else
            {
                int temp = Count - 4;
                pct1.Load(path + temp.ToString() + ".jpg");
                p1 = temp;
                pct2.Load(path + (temp + 1).ToString() + ".jpg");
                p2 = temp + 1;
                pct3.Load(path + (temp + 2).ToString() + ".jpg");
                p3 = temp + 2;
                pct4.Load(path + (temp + 3).ToString() + ".jpg");
                p4 = temp + 3;
                pct5.Load(path + (temp + 4).ToString() + ".jpg");
                p5 = temp + 4;
            }
            if (n == Count)
            {
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
            }

            if (n == 1)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void frmNext_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + "\\Photo\\";
            pctMain.Load(path + "1.jpg");
            sText = File.ReadAllLines("Photo\\Photo.txt");
            Count = sText.Count();
            nMain = 1;
            n = 1;
            pictureBox1.Visible = false;
            LoadPict();
        }

        private void pct1_Click(object sender, EventArgs e)
        {
            nMain = n;
            pctMain.Load(path + (nMain).ToString() + ".jpg");
            label1.Text = sText[nMain - 1];
        }

        private void pct2_Click(object sender, EventArgs e)
        {
            nMain = n + 1;
            pctMain.Load(path + (nMain).ToString() + ".jpg");
            label1.Text = sText[nMain - 1];
        }

        private void pct3_Click(object sender, EventArgs e)
        {
            nMain = n + 2;
            pctMain.Load(path + (nMain).ToString() + ".jpg");
            label1.Text = sText[nMain - 1];
        }

        private void pct4_Click(object sender, EventArgs e)
        {
            nMain = n + 3;
            pctMain.Load(path + (nMain).ToString() + ".jpg");
            label1.Text = sText[nMain - 1];
        }

        private void pct5_Click(object sender, EventArgs e)
        {
            nMain = n + 4;
            pctMain.Load(path + (nMain).ToString() + ".jpg");
            label1.Text = sText[nMain - 1];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            n++;
            nMain++;
            LoadPict();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            n--;
            nMain--;
            LoadPict();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LightSeaGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmNext_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmNext_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
