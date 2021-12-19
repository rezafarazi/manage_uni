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
    public partial class Add_remove : Form
    {
        public Add_remove()
        {
            InitializeComponent();
        }


        string cls_Selection_id;

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string dit=User_Data_cls.reuturn_cls_ditalis(textBox1.Text);
            if (dit.Equals("1"))
            {
                MessageBox.Show("تعداد ظرفیت کلاس تکمیل است");
                return;
            }
            if (dit.Equals(""))
            {
                MessageBox.Show("چنین کلاسی وجود ندارد");
                return;
            }

            string[] cls_dit = dit.Split('-');

            panel1.Visible = true;

            label2.Text = "نام درس    "+cls_dit[1];
            label3.Text = "نام استاد    " + cls_dit[7]+"  "+cls_dit[8];
            label4.Text = "واحد    " + cls_dit[2];
            label5.Text = "ظرفیت    " + cls_dit[6];
            cls_Selection_id=textBox1.Text;
            
        }




        private void Add_remove_Load(object sender, EventArgs e)
        {
            refresh();
        }



        public void refresh()
        {
            dataGridView1.DataSource = User_Data_cls.UntisDataSet().Tables[0];

            dataGridView1.Columns[0].HeaderText = "نام درس";
            dataGridView1.Columns[1].HeaderText = "تعداد واحد درس";
            dataGridView1.Columns[2].HeaderText = "نمره درس";
            dataGridView1.Columns[3].HeaderText = "نام استاد";
            dataGridView1.Columns[4].HeaderText = "نام خانوادگی استاد";
            dataGridView1.Columns[5].HeaderText = "تعداد اخذ کنندگان";
            dataGridView1.Columns[6].HeaderText = "ظرفیت کلاس";
            dataGridView1.Columns[7].HeaderText = "تاریخ";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            User_Data_cls.add_lesson(cls_Selection_id);
            refresh();
        }




        private void button3_Click(object sender, EventArgs e)
        {
            User_Data_cls.remove_lesson(cls_Selection_id);
            refresh();

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label2.Text = "نام درس    " + dataGridView1.Rows[1].Cells[e.ColumnIndex].Value.ToString();
                label3.Text = "نام استاد    " + dataGridView1.Rows[7].Cells[e.ColumnIndex].Value.ToString() + "  " + dataGridView1.Rows[8].Cells[e.ColumnIndex].Value.ToString();
                label4.Text = "واحد    " + dataGridView1.Rows[2].Cells[e.ColumnIndex].Value.ToString();
                label5.Text = "ظرفیت    " + dataGridView1.Rows[5].Cells[e.ColumnIndex].Value.ToString();
                cls_Selection_id = dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
            }
            catch (Exception Error)
            {
            }
        }




    }
}
