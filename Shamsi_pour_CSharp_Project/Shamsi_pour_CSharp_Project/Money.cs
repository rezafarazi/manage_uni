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
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
        }

        private void Money_Load(object sender, EventArgs e)
        {

            Value_Lable_Money.Text = "میزان بدهی شما به دانشگاه مبلغ     " + User_Data_cls.Money_Val() + "       می باشد.";

            if (User_Data_cls.Money_Val().Equals(0))
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
