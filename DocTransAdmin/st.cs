using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace DocTransAdmin
{
    public static class st
    {
        static string getdbPath()
        {
            string t = Application.StartupPath;
            string t1 = t.Remove(t.LastIndexOf('\\'));
            string t2 = t1.Remove(t1.LastIndexOf('\\'));
            string t3 = t2.Remove(t2.LastIndexOf('\\'));
            return Application.StartupPath;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out IntPtr ProcessId); 

        public static string ConStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + getdbPath() + "\\idb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public static void IMsgBox(object c)
        {
            MessageBox.Show(c.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WMsgBox(object c)
        {
            MessageBox.Show(c.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void EMsgBox(object c)
        {
            MessageBox.Show(c.ToString(), "Error/Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult CMsgBox(object c)
        {
            return MessageBox.Show(c.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string InputBox(string prompt,string title, int xPos, int yPos)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, title, null, xPos, yPos);
        }
        public static string CenteredInputBox(string prompt, string title, string preText)
        {
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - 175;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - 100;
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, title, preText, x, y);
        }
        public static string GetNewEmpId()
        {
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                object c = new SqlCommand("SELECT * FROM employees ORDER BY CAST(SUBSTRING(eid, 4, 9999) as INT) DESC", cn).ExecuteScalar();
                if (!DBNull.Value.Equals(c) && c != null)
                {
                    int ct = Convert.ToInt32(c.ToString().Substring(3));
                    ct++;
                    string sta = c.ToString().Substring(0, 3);
                    cn.Close();
                    return sta + ct;
                }
                else
                {
                    cn.Close();
                    return "EMP1";
                }
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
                return "";
            }
        }
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        static bool ByteArrayCompare(byte[] b1, byte[] b2)
        {
            // Validate buffers are the same length.
            // This also ensures that the count does not exceed the length of either buffer.  
            return b1.Length == b2.Length && memcmp(b1, b2, b1.Length) == 0;
        }
        public static string AlreadyStored(byte[] rs)
        {
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlDataReader rd = new SqlCommand("SELECT * FROM employees", cn).ExecuteReader();
                while (rd.Read())
                {
                    byte[] data = (byte[])rd["iristemp"];
                    if (ByteArrayCompare(data, rs))
                        return rd["eid"] + " : " + rd["imgkey"];
                }
                cn.Close();
                return null;
            }
            catch (Exception ex)
            {
                WMsgBox(ex.ToString());
                return null;
            }
        }
        public static string AlreadyStored_Template(Double[,] rs)
        {
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlDataReader rd = new SqlCommand("SELECT * FROM employees", cn).ExecuteReader();
                var rlist = new SortedDictionary<string, double>();
                
                

                while (rd.Read())
                {
                    byte[] data = (byte[])rd["iristemp"];
                    Double[,] dbv = (Double[,])ByteArrayToObject(data);
                    /*if (ByteArrayCompare(data, rs))
                        return rd["eid"] + " : " + rd["imgkey"];*/
                    //rlist.Add(rd["eid"] + "-" + rd["ename"], TemplateEquals(dbv, rs));
                }
                cn.Close();
                
                /*if (val.Value > 60.0)
                {
                    return val.Key.Substring(0, val.Key.IndexOf('-') + 1);
                }*/
                return "";
            }
            catch (Exception ex)
            {
                WMsgBox(ex.ToString());
                return null;
            }
        }
        public static double TemplateEquals(Double[,] a, Double[,] b)
        {
            try
            {
                if (a.Length != b.Length)
                    return 0;
                int elementCount = 0;
                double percent = 0;
                int tot = a.GetLength(0) * a.GetLength(1);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] == b[i, j])
                        {
                            elementCount++;
                            //percent = (double)((double)(elementCount / tot)) * 100;
                        }
                    }
                }
                double v1 = (double)((double)elementCount / (double)tot);
                double v2 = (double)(v1 * 100);
                percent = v2;
                return percent;
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
                return 0;
            }
        }
        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        // Convert a byte array to an Object
        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
    }
}
