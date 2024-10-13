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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void frm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            webBrowser1.Navigate(path + "\\texts\\собаки.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeView1.SelectedNode.Text;
            int sqq = treeView1.SelectedNode.Index;

            if (st1 == "Вступ") webBrowser1.Navigate(path + "\\texts\\вступ.htm");
            if (st1 == "Гітари") webBrowser1.Navigate(path + "\\texts\\гітара.htm");
            if (st1 == "Акустична гітара") webBrowser1.Navigate(path + "\\texts\\акустична_гітара.htm");
            if (st1 == "Електрогітара") webBrowser1.Navigate(path + "\\texts\\електрогітара.htm");
            if (st1 == "Електроакустична гітара") webBrowser1.Navigate(path + "\\texts\\електроакустична_гітара.htm");
            if (st1 == "Класична гітара") webBrowser1.Navigate(path + "\\texts\\класична_гітара.htm");
            if (st1 == "Найкращі гітаристи світу") webBrowser1.Navigate(path + "\\texts\\найкращі_гітаристи.htm");
            if (st1 == "Бі Бі Кінг") webBrowser1.Navigate(path + "\\texts\\кінг.htm");
            if (st1 == "Ерік Клептон") webBrowser1.Navigate(path + "\\texts\\клептон.htm");
            if (st1 == "Джимі Гендрікс") webBrowser1.Navigate(path + "\\texts\\гендрікс.htm");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LightSeaGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
    }
}
