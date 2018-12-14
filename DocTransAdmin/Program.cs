using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocTransAdmin.Properties;

namespace DocTransAdmin
{
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
            /*try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                List<Double[,]> lst = new List<double[,]>();
                SqlDataReader rd = new SqlCommand("SELECT * FROM employees", cn).ExecuteReader();
                while (rd.Read())
                {
                    lst.Add((Double[,])st.ByteArrayToObject((byte[])rd["iristemp"]));
                }
                int i = 0, j = 0;
                string rs = "";
                foreach (Double[,] x in lst)
                {
                    i++;
                    j = 0;
                    foreach (Double[,] y in lst)
                    {
                        j++;
                        if (x == y) continue;
                        rs += string.Format("[{0},{1}] : {2}\n", i, j, st.TemplateEquals(x, y));
                    }
                }
                st.IMsgBox(rs);
                cn.Close();
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
            }*/
            if (string.IsNullOrEmpty(Settings.Default.ServerConStr))
            {
                string rp = st.CenteredInputBox("Enter the Connection String for the Database. - Server Application", "Server Connection String", "");
                if (!string.IsNullOrEmpty(rp))
                {
                    Settings.Default.ServerConStr = rp;
                    Settings.Default.Save();
                    st.ConStr = rp;
                }
                else return;
            }
            else
                st.ConStr = Settings.Default.ServerConStr;
            Application.Run(new FrmLoginA());
            //st.CenteredInputBox("alskdjflksdjf", "sdfsdfsD", "sdfsd");
        }
    }
}
