using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dlyZheni
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
        }
    }

    static class GVN
    {
        public static string connection = @"Data Source=123.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    static class Users_table
    {
        public static string main = "chtliks";
        public static string Id = "Id";
        public static string NameInfo = "NameInfo ";

    }
    static class Photo_table
    {
        public static string main = "Photos";
        public static string Id = "Id";
        public static string Photo1 = "Photo1";
        public static string Photo2 = "Photo2";
    }
    static class Login_table
    {
        public static string main = "login";
        public static string Id = "Id";
        public static string Login = "Login";
        public static string Password = "Password";

    }
}
