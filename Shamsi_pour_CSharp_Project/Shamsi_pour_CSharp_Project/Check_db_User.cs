using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Shamsi_pour_CSharp_Project
{
    class Check_db_User
    {

        //string url = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30";

        public static bool bl=false;

        public static string str = "";

        public Check_db_User(string id,string national_id)
        {
            string queryString = "SELECT * FROM Student;";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ids, name, family, national_ids;

                    str = "";

                    ids= reader.GetInt32(0)+"";
                    name = reader.GetString(1);
                    family = reader.GetString(2);
                    national_ids = reader.GetString(3);

                    str += ids + "-" + national_ids;

                    

                    if (id.Trim().Equals(ids) && national_ids.Trim().Equals(national_id)) 
                    {

                        bl = true;

                        User_Data_cls.id = id;
                        User_Data_cls.name = name;
                        User_Data_cls.family = family;
                        User_Data_cls.national_id = national_id;

                        break;
                    }


                }
                reader.Close();
            }

        }






        public Check_db_User(string id, string national_id,string ss)
        {
            string queryString = "SELECT * FROM Teacher;";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ids, name, family, national_ids;

                    str = "";

                    ids = reader.GetValue(0) + "";
                    name = reader.GetValue(1) + "";
                    family = reader.GetValue(2) + "";
                    national_ids = reader.GetValue(4)+"";

                    str += ids + "-" + national_ids;



                    if (id.Trim().Equals(ids) && national_ids.Trim().Equals(national_id))
                    {

                        bl = true;

                        User_Data_cls.id = id;
                        User_Data_cls.name = name;
                        User_Data_cls.family = family;
                        User_Data_cls.national_id = national_id;

                        break;
                    }


                }
                reader.Close();
            }

        }




        public Check_db_User(string id, string national_id, byte ssss)
        {
            string queryString = "SELECT * FROM root;";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ids, password;

                    str = "";

                    ids = reader.GetInt32(0) + "";
                    password = reader.GetString(1);

                    str += ids + "-" + password;



                    if (id.Trim().Equals(ids) && password.Trim().Equals(national_id))
                    {

                        bl = true;

                        break;
                    }


                }
                reader.Close();
            }

        }



    }
}
