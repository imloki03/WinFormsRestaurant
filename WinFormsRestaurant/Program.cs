using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Methods methods = new Methods();
            //methods.scheduleShift(5);
            //Employee_Class employee = new Employee_Class();
            //MessageBox.Show("" + employee.getEmID(2));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WorkStation());
        }
    }
}
