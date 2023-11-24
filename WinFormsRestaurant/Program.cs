using Emgu.CV.ML;
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
            Shift_Class shift = new Shift_Class();
            DateTime currentDate = shift.getLastDayinCircle().AddDays(-1);
            Methods methods = new Methods();
            if (DateTime.Now> new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0))
            methods.scheduleShift(5);
            Employee_Class em = new Employee_Class();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                if (em.getEmjob(StaticVars_Class.emID) == "Employee")
                {
                    if (StaticVars_Class.state == StaticVars_Class.loginstate[0])
                    {
                        OverView overView = new OverView();
                        Application.Run(overView);
                    }
                    else
                    {
                        WorkStation workStation = new WorkStation();
                        Application.Run(workStation);
                    }
                }
                else
                {
                    Manage manage = new Manage();
                    Application.Run(manage);
                }
            }
            else
                Application.Exit();
            Application.Run(new SelectDishes());
        }
    }
}
