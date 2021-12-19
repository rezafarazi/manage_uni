using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shamsi_pour_CSharp_Project
{
    public partial class Ditalis_Student : Form
    {
        public Ditalis_Student()
        {
            InitializeComponent();
        }

        //SELECT * FROM Pyment WHERE Pyment.Student_id=10

        private void Ditalis_Student_Load(object sender, EventArgs e)
        {

            DataGrid_Money.DataSource = User_Data_cls.moneydataset().Tables[0];

            DataGrid_Number.DataSource = User_Data_cls.NumbersDataSet().Tables[0];

            Avg_lable.Text = "معدل کل";
            string avg=User_Data_cls.AVG_Student();
            if(avg.Equals(null))
            {
                Avg_lable.Text+=":\t"+"0";
            }
            else
            {
                Avg_lable.Text+=":\t"+avg;
            }

            persain_fildes_headers();

        }


        public void persain_fildes_headers()
        {
            DataGrid_Money.Columns[0].HeaderText = "مقدار واریزی";
            DataGrid_Money.Columns[1].HeaderText = "تاریخ واریز";

            DataGrid_Number.Columns[0].HeaderText = "نام درس";
            DataGrid_Number.Columns[1].HeaderText = "تعداد واحد";
            DataGrid_Number.Columns[2].HeaderText = "نمره";
            DataGrid_Number.Columns[3].HeaderText = "نام استاد";
            DataGrid_Number.Columns[4].HeaderText = "نام خانوادگی استاد";
            DataGrid_Number.Columns[5].HeaderText = "تاریخ اخذ درس";
        }


    }
}
