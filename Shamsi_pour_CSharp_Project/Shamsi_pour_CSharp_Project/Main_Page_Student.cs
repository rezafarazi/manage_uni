using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shamsi_pour_CSharp_Project
{
    public partial class Main_Page_Student : Form
    {
        public Main_Page_Student()
        {
            InitializeComponent();
        }

        private void Main_Page_Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Ditalis_Student frm = new Ditalis_Student();
            this.IsMdiContainer = true;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(closee);

        }




        public void closee(object sender, EventArgs e)
        {
            this.IsMdiContainer = false;
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Money frm = new Money();
            this.IsMdiContainer = true;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(closee);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Add_remove frm = new Add_remove();
            this.IsMdiContainer = true;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(closee);
        }



    }
}
