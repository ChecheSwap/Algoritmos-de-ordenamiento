using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subsecsum
{
    static class msg
    {
        public static void ok(string l)
        {
            MessageBox.Show(l, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ok(string l,string m)
        {
            MessageBox.Show(l, m, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void error(string l)
        {
            MessageBox.Show(l, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void danger(string l)
        {
            MessageBox.Show(l, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new central());
            Application.Run(new central());
        }
    }
}
