using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.Cryptography;

namespace DocTransClient
{
    public enum HashName
    {
        SHA1 = 1,
        MD5 = 2,
        SHA256 = 4,
        SHA384 = 8,
        SHA512 = 16
    }
    class st
    {
        public static string CurrentUser;
        public static string CurGroup;
        public static string GetCurrentUserTableName()
        {
            SqlConnection cn = new SqlConnection(st.ConStr);
            cn.Open();
            string rt = "";
            object c = new SqlCommand("SELECT ename FROM employees WHERE eid='" + CurrentUser + "'", cn).ExecuteScalar() + "";
            if (!DBNull.Value.Equals(c) && c != null)
            {
                rt = c.ToString().Replace(' ', '_') + "_" + CurrentUser;
            }
            cn.Close();
            return rt;
        }
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
        public static string ConStr1 = @"Provider=SQLOLEDB.1;Data Source=DISCOVER\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=idb";

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
        public static string CenteredInputBox(string prompt, string title, string preText)
        {
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - 175;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - 100;
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, title, preText, x, y);
        }
        public static DialogResult CMsgBox(object c)
        {
            return MessageBox.Show(c.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string InputBox(string prompt, string title, int xPos, int yPos)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, title, null, xPos, yPos);
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
        public static string GenerateID()
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
        private static string tryID(string tablename, string columnname, string starter, int count)
        {
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                object c = new SqlCommand("SELECT " + columnname + " FROM " + tablename + " WHERE " + columnname + "='" + starter + count + "'", cn).ExecuteScalar();
                cn.Close();
                if (c == null)
                    return starter + count;
                else
                    return tryID(tablename, columnname, starter, ++count);
            }
            catch (SqlException)
            {
                return string.Empty;
            }
        }
        public static string generateID(string tablename, string columnname, string starter)
        {
            string cns = st.ConStr;
            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            int c = Convert.ToInt32(new SqlCommand("SELECT COUNT(*) FROM " + tablename, cn).ExecuteScalar().ToString());
            cn.Close();
            if (c == 0)
                return starter + ++c;
            return tryID(tablename, columnname, starter, c + 1);
        }
        /// <summary> 
        /// Compute Hash 
        /// </summary> 
        /// <param name="plainText">plain text</param> 
        /// <param name="salt">salt string</param> 
        /// <returns>string</returns> 
        public static string ComputeHash(string plainText, string salt)
        {
            return ComputeHash(plainText, salt, HashName.MD5);
        }

        /// <summary> 
        /// Compute Hash 
        /// </summary> 
        /// <param name="plainText">plain text</param> 
        /// <param name="salt">salt string</param> 
        /// <param name="hashName">Hash Name</param> 
        /// <returns>string</returns> 
        public static string ComputeHash(string plainText, string salt, HashName hashName)
        {
            if (!string.IsNullOrEmpty(plainText))
            {
                // Convert plain text into a byte array. 
                byte[] plainTextBytes = ASCIIEncoding.ASCII.GetBytes(plainText);
                // Allocate array, which will hold plain text and salt. 
                byte[] plainTextWithSaltBytes = null;
                byte[] saltBytes;
                if (!string.IsNullOrEmpty(salt))
                {
                    // Convert salt text into a byte array. 
                    saltBytes = ASCIIEncoding.ASCII.GetBytes(salt);
                    plainTextWithSaltBytes =
                        new byte[plainTextBytes.Length + saltBytes.Length];
                }
                else
                {
                    // Define min and max salt sizes. 
                    int minSaltSize = 4;
                    int maxSaltSize = 8;
                    // Generate a random number for the size of the salt. 
                    Random random = new Random();
                    int saltSize = random.Next(minSaltSize, maxSaltSize);
                    // Allocate a byte array, which will hold the salt. 
                    saltBytes = new byte[saltSize];
                    // Initialize a random number generator. 
                    RNGCryptoServiceProvider rngCryptoServiceProvider =
                                new RNGCryptoServiceProvider();
                    // Fill the salt with cryptographically strong byte values. 
                    rngCryptoServiceProvider.GetNonZeroBytes(saltBytes);
                }
                // Copy plain text bytes into resulting array. 
                for (int i = 0; i < plainTextBytes.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainTextBytes[i];
                }
                // Append salt bytes to the resulting array. 
                for (int i = 0; i < saltBytes.Length; i++)
                {
                    plainTextWithSaltBytes[plainTextBytes.Length + i] =
                                        saltBytes[i];
                }
                HashAlgorithm hash = null;
                switch (hashName)
                {
                    case HashName.SHA1:
                        hash = new SHA1Managed();
                        break;
                    case HashName.SHA256:
                        hash = new SHA256Managed();
                        break;
                    case HashName.SHA384:
                        hash = new SHA384Managed();
                        break;
                    case HashName.SHA512:
                        hash = new SHA512Managed();
                        break;
                    case HashName.MD5:
                        hash = new MD5CryptoServiceProvider();
                        break;
                }
                // Compute hash value of our plain text with appended salt. 
                byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);
                // Create array which will hold hash and original salt bytes. 
                byte[] hashWithSaltBytes =
                    new byte[hashBytes.Length + saltBytes.Length];
                // Copy hash bytes into resulting array. 
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashWithSaltBytes[i] = hashBytes[i];
                }
                // Append salt bytes to the result. 
                for (int i = 0; i < saltBytes.Length; i++)
                {
                    hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
                }
                // Convert result into a base64-encoded string. 
                string hashValue = Convert.ToBase64String(hashWithSaltBytes);
                // Return the result. 
                return hashValue;
            }
            return string.Empty;
        }
    }
    [Serializable()]
    public class Document
    {
        public DateTime lastModified;
        public long Length;
        public byte[] FileData;
        public HashName HashMethod;
    }
}