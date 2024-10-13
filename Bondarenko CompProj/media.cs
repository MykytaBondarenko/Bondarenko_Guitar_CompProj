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
    public partial class media : Form
    {
        public media()
        {
            InitializeComponent();
        }

        bool video = false;
        int nump, count;
        string path;

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkGreen;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Indigo;
        }

        private void label4_MouseHover_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.LightSeaGreen;
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string st;
            int k;
            ltB1.Items.Clear();
            ltB2.Items.Clear();
            path = Application.StartupPath;

            try
            {
                string[] dirs = Directory.GetFiles(path + "\\video");
                foreach (string fname in dirs)
                {
                    ltB1.Items.Add(fname);
                    int dl = path.Length;
                    st = fname.Remove(0, dl);
                    k = st.LastIndexOf("\\");
                    st = st.Remove(0, k + 1);
                    k = st.IndexOf(".");
                    st = st.Substring(0, k);
                    ltB2.Items.Add(st);
                }
            }

            catch (Exception ee)
            {
                ltB2.Items.Add("The process failed: " + ee.ToString());
            }
            video = true;
            axWindowsMediaPlayer1.BringToFront();
        }

        private void ltB2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (video == false) timer1.Start();
            else timer1.Stop();
            axWindowsMediaPlayer1.URL = (string)ltB1.Items[ltB2.SelectedIndex];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void ltB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            nump = nump + 1;
            if (nump <= count) pictureBox1.Load(path + "\\photo1\\" + nump.ToString() + ".png");
            else nump = 0;
        }

        private void media_Load(object sender, EventArgs e)
        {
            nump = 0;
            path = Application.StartupPath;
            string[] mal = Directory.GetFiles(path + "\\photo1");
            count = mal.Count() - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st;
            int k;
            ltB1.Items.Clear();
            ltB2.Items.Clear();
            path = Application.StartupPath;

            try
            {
                string[] dirs = Directory.GetFiles(path + "\\music");
                foreach (string fname in dirs)
                {
                    ltB1.Items.Add(fname);
                    int p = fname.LastIndexOf("\\");
                    st = fname.Remove(0, p + 1);
                    k = st.IndexOf(".");
                    st = st.Substring(0, k);
                    ltB2.Items.Add(st);
                }
            }

            catch (Exception ee)
            {
                ltB2.Items.Add("The process failed: " + ee.ToString());
            }
            video = false;
            pictureBox1.Load(path + "\\photo1\\" + "1.png");
            pictureBox1.BringToFront();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Interval = 1000;
        }
    }
}
