using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace μScore
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        public static Sign Sign;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Sign = new Sign());
        }
    }
}
