using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocTransClient.Properties;

namespace DocTransClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            if (string.IsNullOrEmpty(Settings.Default.ServerConStr))
            {
                string rp = st.CenteredInputBox("Enter the Connection String of the Server Database - Client Application", "Connection String", "");
                if (string.IsNullOrEmpty(rp))
                    return;
                Settings.Default.ServerConStr = rp;
                Settings.Default.Save();
                st.ConStr = rp;
            }
            else
            {
                st.ConStr = Settings.Default.ServerConStr;
            }/**/
            //Application.Run(new FrmMainC("EMP1", "BlueTeam"));
            Application.Run(new FrmLoginC());
        }
    }
}
