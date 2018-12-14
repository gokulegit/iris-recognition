using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using GTools;

namespace DocTransAdmin
{
    public partial class FrmRegisterA : Form
    {
        public FrmRegisterA()
        {
            InitializeComponent();
        }

        private void FrmRegisterA_Load(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
            //Process p = new Process();
            txtEid.Text = st.GetNewEmpId();
            txtEname.Focus();
            addGroups();
        }
        void addGroups()
        {
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlDataReader rd = new SqlCommand("SELECT gname as GP FROM groups", cn).ExecuteReader();
                cmbGroup.Items.Clear();
                while (rd.Read())
                {
                    if (rd["GP"] + "" == "General")
                        continue;
                    cmbGroup.Items.Add(rd["GP"] + "");
                }
                cn.Close();
                if (cmbGroup.Items.Count > 0) cmbGroup.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
            }
        }
        private byte[] curIrisData = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                object c = new SqlCommand("SELECT iristemp FROM employees WHERE imgkey='" + txtImgKey.Text + "'", cn).ExecuteScalar();
                object v = st.ByteArrayToObject((byte[])c);
                var v1 = (System.Double[,])v;
                string hs = "";
                for (int i = 0; i < v1.GetLength(0); i++)
                {
                    for (int j = 0; j < v1.GetLength(1); j++)
                    {
                        hs += v1[i, j];
                    }
                }
                richTextBox1.Text = hs;
                cn.Close();
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
            }*/
            if (txtEname.Text.Trim().Length == 0)
            {
                st.WMsgBox("Enter the Employee Name.");
                txtEname.Focus();
                return;
            }
            if (txtPh.Text.Trim().Length == 0)
            {
                st.WMsgBox("Enter the Phone Number.");
                txtPh.Focus();
                return;
            }
            if (txtImgKey.Text.Trim().Length == 0)
            {
                st.WMsgBox("Please Upload the Iris Image.");
                txtIrisImg.Focus();
                return;
            }
            if (cmbGroup.SelectedIndex == -1)
            {
                st.WMsgBox("Please Choose a Group to Add the employee into.");
                cmbGroup.Focus();
                return;
            }
            try
            {
                if (st.CMsgBox("Are you Sure? Want to Save?") == DialogResult.No)
                    return;
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO employees VALUES(@eid,@ename,@phone,@img,@imgkey,@groop, @iristemp)", cn);
                cmd.Parameters.AddWithValue("@eid", txtEid.Text.Trim());
                cmd.Parameters.AddWithValue("@ename", txtEname.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPh.Text.Trim());
                cmd.Parameters.AddWithValue("@img", File.ReadAllBytes(txtIrisImg.Text.Trim()));
                cmd.Parameters.AddWithValue("@imgkey", txtImgKey.Text.Trim());
                cmd.Parameters.AddWithValue("@groop", cmbGroup.Text.Trim());
                cmd.Parameters.AddWithValue("@iristemp", this.curIrisData);
                cmd.ExecuteNonQuery();
                //st.IMsgBox("CREATE table " + txtEname.Text.Trim().Replace(' ', '_') + "_" + txtEid.Text.Trim() + " (sno int identity(1,1) ,fid nvarchar(MAX) not null primary key, fname nvarchar(MAX),fromemp nvarchar(50), dttime datetime,filekey nvarchar(MAX), filecontents varbinary(MAX) NULL, filesize bigint)");
                new SqlCommand("CREATE table " + txtEname.Text.Trim().Replace(' ', '_') + "_" + txtEid.Text.Trim() + " (sno int identity(1,1) ,fid nvarchar(100) not null primary key, fname nvarchar(MAX),fromemp nvarchar(50),toemp nvarchar(50), dttime datetime,filekey nvarchar(MAX), filecontents varbinary(MAX) NULL, filesize bigint)", cn).ExecuteNonQuery();
                cn.Close();
                st.IMsgBox("The Employee \"" + txtEname.Text.Trim() + "\" has been Registered With the ID \"" + txtEid.Text + "\" Successfully.");
                ClearForm();
                addGroups();
                txtEid.Text = st.GetNewEmpId();
                txtEname.Focus();
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
            }
        }
        void ClearForm()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label)
                    continue;
                if (x is ComboBox)
                    continue;
                if (x is Button)
                    continue;
                if (x is LinkLabel)
                    continue;
                if (x is GButton)
                    continue;
                x.Text = "";
                if (x is PictureBox)
                    ((PictureBox)x).BackgroundImage = null;
            }
        }
        private void txtImgKey_TextChanged(object sender, EventArgs e)
        {
            if (txtImgKey.Text == "")
                btnRegister.Enabled = false;
            else
                btnRegister.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            //dl.Filter = "JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            dl.Filter = "BMP Files |*.bmp|JPG Image |*.jpg";
            //dl.InitialDirectory = "C:\\";
            dl.Multiselect = false;
            if (dl.ShowDialog() != DialogResult.Cancel)
            {
                txtIrisImg.Text = dl.FileName;
            }
        }
        BackgroundWorker w;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtIrisImg.Text.Trim().Length == 0)
            {
                st.EMsgBox("Please Input the Path of the Image.");
                return;
            }
            if (!new FileInfo(txtIrisImg.Text.Trim()).Exists)
            {
                st.EMsgBox("Invalid Path. No file Exists.");
                return;
            }
            btnUpload.Enabled = false;
            btnRegister.Enabled = false;
            picIris.BackgroundImage = Image.FromFile(txtIrisImg.Text.Trim());
            pl.Visible = true;
            ls.Visible = true;
            ls.Text = "";
            w = new BackgroundWorker();
            w.WorkerReportsProgress = true;
            w.WorkerSupportsCancellation = true;
            w.DoWork += new DoWorkEventHandler((object s1, DoWorkEventArgs e1) =>
            {
                //int p = 1;
                int ins = int.MinValue;
                w.ReportProgress(ins++, "Initializing The Scanning Engine");
                Thread.Sleep(1000);
                w.ReportProgress(ins++, "Performing Scanning Iris Image...");
                IrisRecognitionNative.IrisReg ir = new IrisRecognitionNative.IrisReg();
                object c = null;
                try { c = ir.createiristemplate(txtIrisImg.Text.Trim()); }
                catch (Exception ex)
                {
                    st.WMsgBox("Invalid Image OR Could not able to locate the IRIS data.\nInput Gray Scale Image of Maximum Size 512x512." + ex.ToString());
                }
                w.ReportProgress(ins++, "Scanning Completed...");
                System.Double[,] res = null;
                string ikey = "";
                if (c != null)
                {
                    res = (System.Double[,])c;
                    ikey = RandomString(20);
                    w.ReportProgress(ins++, "Calculating Values... Please Wait.");
                    //st.IMsgBox(HashMatrix(res));
                    /*for (int i = 0; i < res.GetLength(0); i++)
                    {
                        for (int j = 0; j < res.GetLength(1); j++)
                        {
                            v += res[i, j];
                            /* w.ReportProgress(p++, res[i, j]);
                            w.ReportProgress(ins++, "Printing : [" + i + "," + j + "] : " + res[i, j]);
                            Thread.Sleep(10); 
                        }
                    }*/

                    //string al = st.AlreadyStored(st.ObjectToByteArray(res));
                    string al = AlreadyMatchingTemplate(res);

                    if (al != null)
                    {
                        st.WMsgBox("The Iris Information Matches to the Existing Profile. [" + al + "]\n\nPlease Choose the Image of Other Person.");
                        return;
                    }
                    curIrisData = st.ObjectToByteArray(res);
                    w.ReportProgress(-2, ikey);
                }
                /*byte[] udata = null;
                if (res != null)
                {
                    udata = st.ObjectToByteArray(res);
                }
                e1.Result = udata;*/
            });
            w.ProgressChanged += new ProgressChangedEventHandler((object s2, ProgressChangedEventArgs e2) =>
            {
                pl.Visible = true;
                if (e2.ProgressPercentage < -3)
                {
                    ls.Visible = true;
                    ls.Text = e2.UserState.ToString();
                    return;
                }
                if (e2.ProgressPercentage == -2)
                {
                    txtImgKey.Text = e2.UserState.ToString();
                    return;
                }
                //richTextBox1.AppendText(e2.UserState.ToString() + " ");
            });
            w.RunWorkerCompleted += new RunWorkerCompletedEventHandler((object s3, RunWorkerCompletedEventArgs e3) =>
            {
                btnUpload.Enabled = true;
                pl.Visible = false;
                ls.Text = "";
                btnRegister.Enabled = true;
                //txtImgKey.Text = 

            });
            w.RunWorkerAsync();
        }
        string AlreadyMatchingTemplate(Double[,] rs)
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
                    Double[,] dbv = (Double[,])st.ByteArrayToObject(data);
                    /*if (ByteArrayCompare(data, rs))
                        return rd["eid"] + " : " + rd["imgkey"];*/
                    rlist.Add(rd["eid"] + "-" + rd["ename"], st.TemplateEquals(dbv, rs));
                }
                cn.Close();


                IEnumerable<KeyValuePair<string, double>> vals = rlist.OrderByDescending(k => k.Value);

                if (vals.Count() > 0)
                {

                    var val = vals.ElementAt(0);
                    if (val.Value > 60.0)
                    {
                        return val.Key;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
                return null;
            }
        }
        public string ByteArrToString(byte[] byteArr)
        {
            string temp = "";
            foreach (byte b in byteArr)
                temp += b.ToString().PadLeft(3, '0');
            return temp;
        }
        string RandomString(int length)
        {
            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            if (length < 0) throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
            if (string.IsNullOrEmpty(allowedChars)) throw new ArgumentException("allowedChars may not be empty.");

            const int byteSize = 0x100;
            var allowedCharSet = new HashSet<char>(allowedChars).ToArray();
            if (byteSize < allowedCharSet.Length)
                throw new ArgumentException(String.Format("allowedChars may contain no more than {0} characters.", byteSize));

            // Guid.NewGuid and System.Random are not particularly random. By using a
            // cryptographically-secure random number generator, the caller is always
            // protected, regardless of use.
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();

            var result = new StringBuilder();
            var buf = new byte[128];
            while (result.Length < length)
            {
                rng.GetBytes(buf);
                for (var i = 0; i < buf.Length && result.Length < length; ++i)
                {
                    // Divide the byte into allowedCharSet-sized groups. If the
                    // random value falls into the last group and the last group is
                    // too small to choose from the entire allowedCharSet, ignore
                    // the value in order to avoid biasing the result.
                    var outOfRangeStart = byteSize - (byteSize % allowedCharSet.Length);
                    if (outOfRangeStart <= buf[i]) continue;
                    result.Append(allowedCharSet[buf[i] % allowedCharSet.Length]);
                }
            }
            SqlConnection cn = new SqlConnection(st.ConStr);
            cn.Open();
            object c = new SqlCommand("SELECT * FROM employees WHERE imgkey='" + result + "'", cn).ExecuteScalar();
            if (!DBNull.Value.Equals(c) && c != null)
            {
                cn.Close();
                return RandomString(length);
            }
            return result.ToString();
        }

        string HashMatrix(System.Double[,] array)
        {
            System.Double hash = 17.0;
            string hs = "";
            int r, c;
            r = array.GetLength(0);
            c = array.GetLength(1);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    hash = hash * 31 + array[i, j];
                    //hs += array[i, j];
                }
            }
            //long v = Convert.ToInt64(hs, 2);

            hs = string.Format("{0}", hash);
            return hs;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (w != null)
            {
                if (w.IsBusy)
                {
                    st.WMsgBox("Please While the Scanning Operation is Running..");
                    return;
                }
                this.Close();
            }
            this.Close();
        }

        private void FrmRegisterA_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (w != null)
                if (w.IsBusy)
                {
                    st.WMsgBox("Please While the Scanning Operation is Running..");
                    e.Cancel = true;
                }*/
        }

        private void txtPh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((txtPh.Text + e.KeyChar).Length >= 11)
                {
                    e.Handled = true;
                }
            }
            string all = "0123456789\b";
            if (all.IndexOf(e.KeyChar) == -1)
                e.Handled = true;

        }

        private void lnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string gname = st.CenteredInputBox("Enter a New Group Name : ", "Group Name", "");
            if (!string.IsNullOrEmpty(gname.Trim()))
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                object c = new SqlCommand("SELECT * FROM groups WHERE gname='" + gname + "'", cn).ExecuteScalar();
                if (!DBNull.Value.Equals(c) && c != null)
                {
                    cn.Close();
                    st.IMsgBox("The Group Name you had Choosed was Already Exists in the Database.");
                    return;
                }
                new SqlCommand("INSERT INTO groups VALUES('" + gname + "',0)", cn).ExecuteNonQuery();
                cn.Close();
                addGroups();
            }
        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbGroup.SelectedIndex == -1)
                return;
            string gn = cmbGroup.Text;
            string ngn = st.CenteredInputBox("Enter New Group Name for " + gn, "New Group Name", gn);
            if (!string.IsNullOrEmpty(ngn) && gn != ngn)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(st.ConStr);
                    cn.Open();
                    new SqlCommand("UPDATE groups SET gname='" + ngn + "' WHERE gname='" + gn + "'", cn).ExecuteNonQuery();
                    cn.Close();
                    addGroups();
                }
                catch (Exception ex)
                {
                    st.WMsgBox(ex.ToString());
                }
            }
        }

        private void lnkDel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbGroup.SelectedIndex == -1)
                return;
            string gn = cmbGroup.Text;
            //string ngn = st.CenteredInputBox("Enter New Group Name for " + gn, "New Group Name", gn);
            if (st.CMsgBox("Are you Sure ? Want to Delete the Group \"" + gn + "\"\nThe Group Members will be Moved to General Group if Deleted.") == DialogResult.Yes)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(st.ConStr);
                    cn.Open();
                    new SqlCommand("UPDATE employees SET groop='General' WHERE groop='" + gn + "'", cn).ExecuteNonQuery();
                    int ct = Convert.ToInt32(new SqlCommand("SELECT COUNT(*) FROM employees WHERE groop='General'", cn).ExecuteScalar() + "");
                    new SqlCommand("UPDATE groups SET mems=" + ct + " WHERE gname='General'", cn).ExecuteNonQuery();
                    new SqlCommand("DELETE FROM groups WHERE gname='" + gn + "'", cn).ExecuteNonQuery();
                    cn.Close();
                    st.IMsgBox("The Group Deleted Successfully.");
                    addGroups();
                }
                catch (Exception ex)
                {
                    st.WMsgBox(ex.ToString());
                }
            }
        }

        private void txtEname_KeyPress(object sender, KeyPressEventArgs e)
        {
            string al = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \b ";
            if (al.IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }
    }
}