
namespace Bondarenko_CompProj
{
    partial class frm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Вступ", 3, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Акустична гітара", 3, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Електрогітара", 3, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Електроакустична гітара", 3, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Класична гітара", 3, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Гітари", 3, 2, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Бі Бі Кінг", 3, 2);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ерік Клептон", 3, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Джимі Гендрікс", 3, 2);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Найкращі гітаристи світу", 3, 2, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "Узел0";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Вступ";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "Узел2";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Акустична гітара";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "Узел3";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Електрогітара";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "Узел0";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Електроакустична гітара";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "Узел1";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Класична гітара";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "Узел1";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Гітари";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "Узел5";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Бі Бі Кінг";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "Узел6";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Ерік Клептон";
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "Узел2";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Джимі Гендрікс";
            treeNode10.ImageIndex = 3;
            treeNode10.Name = "Узел4";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "Найкращі гітаристи світу";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(330, 533);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tr4.png");
            this.imageList1.Images.SetKeyName(1, "tr6.png");
            this.imageList1.Images.SetKeyName(2, "icon1.png");
            this.imageList1.Images.SetKeyName(3, "icon2.png");
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(348, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(722, 679);
            this.webBrowser1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Меню";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // frm3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm3";
            this.Text = "frm3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
    }
}