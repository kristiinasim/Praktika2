using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    static class Program
    {
        public static string path;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            path = @"D:\#Games and Apps\GITHUB\Praktika2\Triangle\Inventory.txt";
            File.Delete(path);
            string tekst = " ";
            File.AppendAllText(path, tekst);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Tehnika());
=======
            Application.Run(new Toit());
>>>>>>> master
        }
    }
}
