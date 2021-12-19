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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        /*********Teacher_Button_CLICKED*****************/
        private void button2_Click(object sender, EventArgs e)
        {
            if (check())
            {

                Check_db_User ch = new Check_db_User(textBox1.Text.Trim(), textBox2.Text.Trim(),"");

                if (Check_db_User.bl)
                {
                    this.Hide();
                    new Mgmt().Show();
                }
                else
                {
                    errorProvider1.SetError(textBox1, "مقادیر ورودی نا درست");
                    errorProvider1.SetError(textBox2, "مقادیر ورودی نا درست");
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
        }


        /*********Student_Button_CLICKED*****************/
        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {

                Check_db_User ch = new Check_db_User(textBox1.Text.Trim(), textBox2.Text.Trim());

                if (Check_db_User.bl)
                {
                    this.Hide();
                    new Main_Page_Student().Show();
                }
                else
                {
                    errorProvider1.SetError(textBox1, "مقادیر ورودی نا درست");
                    errorProvider1.SetError(textBox2, "مقادیر ورودی نا درست");
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
        }



        /*********CHECK FILL FILDES*****************/
        public bool check()
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                return true;
            }
            else
            {
                if (textBox1.Text.Trim() == "")
                {
                    errorProvider1.SetError(textBox1, "لطفا مقدار را پر کنید");
                }
                if (textBox2.Text.Trim() == "")
                {
                    errorProvider1.SetError(textBox2, "لطفا مقدار را پر کنید");
                }
            }
            return false;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (check())
            {

                Check_db_User ch = new Check_db_User(textBox1.Text.Trim(), textBox2.Text.Trim(),0);

                if (Check_db_User.bl)
                {
                    this.Hide();
                    new root().Show();
                }
                else
                {
                    errorProvider1.SetError(textBox1, "مقادیر ورودی نا درست");
                    errorProvider1.SetError(textBox2, "مقادیر ورودی نا درست");
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
        }



    }
}
