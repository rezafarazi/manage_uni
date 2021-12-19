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
    public partial class Mgmt : Form
    {
        public Mgmt()
        {
            InitializeComponent();
        }

        private void Mgmt_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(User_Data_cls.Lessons_For_Teacher(User_Data_cls.id));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            panel1.Visible = true;
            listBox2.Items.AddRange(User_Data_cls.Lessons_For_Teacher_num(listBox1.SelectedItem.ToString()));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            panel1.Visible = false;
        }

        private void Mgmt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            User_Data_cls.update_number(listBox2.SelectedValue.ToString(), float.Parse(textBox1.Text));
            textBox1.Clear();
        }

    }
}
