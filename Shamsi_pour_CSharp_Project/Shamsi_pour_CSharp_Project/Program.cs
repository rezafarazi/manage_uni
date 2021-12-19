using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shamsi_pour_CSharp_Project
{
    static class Program
    {

        //public static string url=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\rezafta\documents\visual studio 2012\Projects\Shamsi_pour_CSharp_Project\Shamsi_pour_CSharp_Project\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
        public static string url = @"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\DataBase.mdf;integrated security=True;MultipleActiveResultSets=True;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}