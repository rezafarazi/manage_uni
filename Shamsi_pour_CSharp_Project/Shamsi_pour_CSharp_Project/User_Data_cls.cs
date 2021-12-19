using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;

namespace Shamsi_pour_CSharp_Project
{
    class User_Data_cls
    {

        public static string id { get; set; }
        public static string name { get; set; }
        public static string family { get; set; }
        public static string national_id { get; set; }



        public static DataSet moneydataset()
        {
            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlDataAdapter sqladaptor = new SqlDataAdapter("SELECT Value,Date FROM Pyment WHERE Pyment.Student_id=" + User_Data_cls.id + ";", connection))
                {

                    DataSet ds = new DataSet();

                    sqladaptor.Fill(ds);

                    return ds;
                }

            }
        }




        public static DataSet NumbersDataSet()
        {
            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlDataAdapter sqladaptor = new SqlDataAdapter("SELECT Lessons.name,Lessons.Unit,Chosen_Unit.number,Teacher.name,Teacher.family,Chosen_Unit.Date FROM Chosen_Unit INNER JOIN Lessons ON Chosen_Unit.Lesson_id=Lessons.Id INNER JOIN Teacher ON Lessons.Teacher_id=Teacher.Id WHERE Chosen_Unit.student_id="+User_Data_cls.id+";", connection))
                {

                    DataSet ds = new DataSet();

                    sqladaptor.Fill(ds);

                    return ds;
                }

            }
        }




        public static string AVG_Student()
        {
            string queryString = "SELECT AVG(Chosen_Unit.number) From Chosen_Unit WHERE Chosen_Unit.student_id="+User_Data_cls.id+";";

            string avg = "";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetValue(0);
                }
                reader.Close();
            }

            return avg;

        }





        public static int Money_Val()
        {
            string queryString = "SELECT SUM(Lessons.Unit) FROM Chosen_Unit JOIN Lessons ON Chosen_Unit.Lesson_id=Lessons.Id WHERE Chosen_Unit.student_id=" + User_Data_cls.id + ";";

            string Count = "";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetValue(0);
                }
                reader.Close();
            }

            try
            {
                return int.Parse(Count) * 5000;
            }
            catch
            {
                return 0;
            }
        }





        public static void pyment(int value)
        {

            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("INSERT INTO Pyment(Student_id,Value,Date) VALUES(@Student_id,@Value,@Date);", connection))
                {
                    /***********Iranian Jalali Date******/
                    PersianCalendar p = new System.Globalization.PersianCalendar();
                    DateTime date = new DateTime();
                    date = DateTime.Parse(DateTime.Now.ToShortDateString());
                    int year = p.GetYear(date);
                    int month = p.GetMonth(date);
                    int day = p.GetDayOfMonth(date);
                    string str_date = string.Format("{0}/{1}/{2}", year, month, day);
                    /***********Iranian Jalali Date******/




                    com.Parameters.AddWithValue("@Student_id", User_Data_cls.id);
                    com.Parameters.AddWithValue("@Value", value);
                    com.Parameters.AddWithValue("@Date", str_date);

                    com.ExecuteNonQuery();

                }

            }

        }





        public static DataSet UntisDataSet()
        {
            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlDataAdapter sqladaptor = new SqlDataAdapter("SELECT Lessons.name,Lessons.Unit,Chosen_Unit.number,Teacher.name,Teacher.family,Lessons.Count_member,Lessons.Count_all,Chosen_Unit.Date FROM Chosen_Unit INNER JOIN Lessons ON Chosen_Unit.Lesson_id=Lessons.Id INNER JOIN Teacher ON Lessons.Teacher_id=Teacher.Id WHERE Chosen_Unit.student_id=" + User_Data_cls.id + ";", connection))
                {

                    DataSet ds = new DataSet();

                    sqladaptor.Fill(ds);

                    return ds;
                }

            }
        }




        /************************Add And Remove****************/
        public static string reuturn_cls_ditalis(string cls_id)
        {
            string queryString = "SELECT * FROM Lessons Join Teacher ON Lessons.Teacher_id=Teacher.Id WHERE Lessons.id="+cls_id+";";

            string Dits = "";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Dits += reader.GetValue(i) + "-";
                    }

                    if(reader.GetValue(4).Equals(reader.GetValue(5)))
                    {
                        Dits="1";
                    }
                }
                reader.Close();
            }

            return Dits;
        }




        public static void add_lesson(string lesson_id)
        {

            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("INSERT INTO Chosen_Unit(Student_id,Lesson_id,Date) VALUES(@Student_id,@less,@Date);", connection))
                {

                    /***********Iranian Jalali Date******/
                    PersianCalendar p = new System.Globalization.PersianCalendar();
                    DateTime date = new DateTime();
                    date = DateTime.Parse(DateTime.Now.ToShortDateString());
                    int year = p.GetYear(date);
                    int month = p.GetMonth(date);
                    int day = p.GetDayOfMonth(date);
                    string str_date =  string.Format("{0}/{1}/{2}", year, month, day);
                    /***********Iranian Jalali Date******/

                    com.Parameters.AddWithValue("@Student_id", User_Data_cls.id);
                    com.Parameters.AddWithValue("@less", lesson_id);
                    com.Parameters.AddWithValue("@Date", str_date);

                    connection.Open();

                    com.ExecuteNonQuery();

                    connection.Close();
                }


            }

        }






        public static void remove_lesson(string lesson_id)
        {

            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("DELETE FROM Chosen_Unit WHERE Chosen_Unit.student_id=" + User_Data_cls.id + " and Chosen_Unit.Lesson_id=" + lesson_id + ";", connection))
                {
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();
                }

            }
        }






        public static string[] teachers()
        {

            string queryString = "SELECT * FROM Teacher;";

            string Dits = "";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Dits += reader.GetValue(1);
                    Dits += reader.GetValue(2);
                    Dits+="-";
                    
                }
                reader.Close();
            }


            return Dits.Split('-');
        }






        public static void insert_new_teacher(string name,string family,string national_id,string resome_addres)
        {
            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("INSERT INTO Teacher(name,family,Resome,National_id) VALUES(@name,@family,@reso,@no);", connection))
                {

                    byte[] file;
                    using (var stream = new FileStream(resome_addres, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            file = reader.ReadBytes((int)stream.Length);
                        }
                    }


                    com.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = name;
                    com.Parameters.Add("@family", SqlDbType.NVarChar, 20).Value = family;
                    com.Parameters.Add("@reso", SqlDbType.VarBinary).Value = file;
                    com.Parameters.Add("@no", SqlDbType.NVarChar, 20).Value = national_id;
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();

                }

            }

        }





        public static void insert_new_class(string name, string unit, string all_count, string cls_name)
        {
            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("INSERT INTO Lessons(name,unit,Count_all,Teacher_id) VALUES(@name,@family,@reso,@no);", connection))
                {

                    com.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = name;
                    com.Parameters.Add("@family", SqlDbType.Int).Value = int.Parse(unit);
                    com.Parameters.Add("@reso", SqlDbType.Int).Value = int.Parse(all_count);
                    com.Parameters.Add("@no", SqlDbType.Int).Value = int.Parse(cls_name);
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();

                }

            }

        }




        public static void update_student(string id,string name,string family,string national_id)
        {

            using (SqlConnection con = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("UPDATE Student SET name=@name,family=@family,national_id=@national_id WHERE id=@id", con))
                {

                    con.Open();

                    com.Parameters.AddWithValue("@name", name);
                    com.Parameters.AddWithValue("@family", family);
                    com.Parameters.AddWithValue("@national_id", national_id);
                    com.Parameters.AddWithValue("@id", id);

                    com.ExecuteNonQuery();

                    con.Close();

                }

            }

        }







        public static string[] Lessons_For_Teacher(string teacher_id)
        {

            string queryString = "SELECT * FROM Lessons WHERE Teacher_id="+id+";";

            string Dits = "";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Dits += reader.GetValue(1);
                    Dits += "-";

                }
                reader.Close();
            }


            return Dits.Split('-');
        }




        public static string[] Lessons_For_Teacher_num(string cls_name)
        {

            string queryString = "SELECT * FROM Chosen_Unit JOIN Lessons ON Chosen_Unit.Lesson_id=Lessons.Id JOIN Student ON Chosen_Unit.student_id=Student.Id WHERE Lessons.name='"+cls_name+"';";

            string Dits = "";

            using (SqlConnection connection = new SqlConnection(Program.url))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Dits += reader.GetValue(11);
                    Dits += "-";

                }
                reader.Close();
            }


            return Dits.Split('-');
        }




        public static void update_number(string stu_id,float num)
        {
            
            using (SqlConnection connection = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("UPDATE Chosen_Unit SET number=@num WHERE student_id="+stu_id+";", connection))
                {
                    com.Parameters.Add("@num",SqlDbType.Float).Value=num;
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();

                }

            }

        }




        public static void insert_student(string name,string family,string natinal_id)
        {

            using (SqlConnection con = new SqlConnection(Program.url))
            {

                using (SqlCommand com = new SqlCommand("INSERT INTO Student(name,family,National_id) VALUES(@name,@family,@national_id);", con))
                {

                    com.Parameters.Add("@name",SqlDbType.NVarChar,24).Value=name;
                    com.Parameters.Add("@family", SqlDbType.NVarChar,36).Value=family;
                    com.Parameters.Add("@national_id",SqlDbType.NChar,10).Value=natinal_id;

                    con.Open();

                    com.ExecuteNonQuery();

                    com.Clone();

                }


            }

        }



    }


}
