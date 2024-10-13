using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondarenko_CompProj
{
    public partial class frmMain : Form
    {
        public frmNext Next_form = new frmNext();
        public frmMain()
        {
            InitializeComponent();
            AddOwnedForm(Next_form);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightSeaGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
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
            frm3 third_form = new frm3();
            third_form.StartPosition = FormStartPosition.CenterScreen;
            third_form.ShowDialog();
        }





        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.LightSeaGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.LightSeaGreen;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            media media_player = new media();
            media_player.StartPosition = FormStartPosition.CenterScreen;
            media_player.ShowDialog();
        }
    }
}
