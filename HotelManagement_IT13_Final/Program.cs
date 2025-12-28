using HotelManagement_IT13_Final.Forms.Auth;
using HotelManagement_IT13_Final.Forms.Dashboard;
using HotelManagement_IT13_Final.Forms.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_IT13_Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new frmLogin());
            Application.Run(new frmAdminDashboard());
            Application.Run(new frmUsers());

        }
    }
}
