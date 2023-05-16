using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRestaurant
{
    internal class StaticVars_Class
    {
        public static string username;

        public static int employeePerShift;

        public static string emID;

        public static string shifttime;

        public static string closetime = "Not in working time";

        public static string[] loginstate = { "Idle","Cheked-in","Checked-out"};

        public static string state = loginstate[0];
    }
}
