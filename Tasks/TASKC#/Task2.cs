using System;

namespace ZagEng_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region login

            string userName;
            string pass;

            bool isContinue = true;

            do
            {
                Console.Write("Enter Username : ");
                userName = Console.ReadLine();

                Console.Write("Enter Password : ");
                pass = Console.ReadLine();

                bool res = Sys.IsAdmin(userName, pass);
                Console.WriteLine(res ? "Hi Admin" : "Not Admin");

                if (!res)
                {
                    isContinue = false;
                    break;
                }

                // ===== Feature Toggle =====
                Console.Write("Enable Login (1/0): ");
                int.TryParse(Console.ReadLine(), out int l);

                Console.Write("Enable Export (1/0): ");
                int.TryParse(Console.ReadLine(), out int x);

                Console.Write("Enable AdminPanel (1/0): ");
                int.TryParse(Console.ReadLine(), out int p);

                Console.WriteLine("\n=== Features Status ===");

                Console.WriteLine($"Login : {Sys.Login(l)}");
                Console.WriteLine($"Export : {Sys.Export(x)}");
                Console.WriteLine($"AdminPanel : {Sys.AdminPanel(p)}");

                isContinue = false;

            } while (isContinue);

            #endregion
        }
    }

    class Sys
    {
        // Feature State
        public static bool IsEnabled { get; set; }

        #region Login

        const string _userName = "admin";
        const string _password = "admin";

        public static bool IsAdmin(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return false;

            if (userName != _userName || password != _password)
                return false;

            return true;
        }

        #endregion

        #region Features

        public static bool Login(int status)
        {
            IsEnabled = (status == 1);
            return IsEnabled;
        }

        public static bool Export(int status)
        {
            return (status == 1);
        }

        public static bool AdminPanel(int status)
        {
            return (status == 1);
        }

        #endregion
    }
}
