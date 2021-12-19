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
    public partial class root : Form
    {
        public root()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Data_cls.update_student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            panel1.Visible = false;
            clear();
        }


        public void clear()
        {
            TextBox[] textboxs = {textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8 ,textBox9,textBox10,textBox11};

            for (int i = 0; i < textboxs.Length; i++)
            {
                textboxs[i].Clear();
                textboxs[i].TextAlign=HorizontalAlignment.Center;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clear();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            clear();
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            User_Data_cls.insert_new_teacher(textBox5.Text,textBox6.Text,textBox7.Text,button3.Text);
            panel2.Visible = false;
            clear();
        }






        private void root_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "*.pdf|*.pdf";
                op.ShowDialog();
                button3.Text = op.FileName;
            }
            catch
            {
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(User_Data_cls.teachers());
            clear();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }


        private void root_Load(object sender, EventArgs e)
        {
            
        }



        private void button5_Click(object sender, EventArgs e)
        {
            User_Data_cls.insert_new_class(textBox8.Text, numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString(),(comboBox1.SelectedIndex+1).ToString());
            clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {

            User_Data_cls.insert_student(textBox9.Text, textBox10.Text, textBox11.Text);
            clear();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clear();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

    }
}
