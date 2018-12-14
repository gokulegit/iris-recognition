using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace DocTransClient
{
    public partial class FrmSendFileC : Form
    {
        public FrmSendFileC()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Trim() == string.Empty)
            {
                st.WMsgBox("Enter a Valid Path.");
                return;
            }
            if (!new FileInfo(txtPath.Text.Trim()).Exists)
            {
                st.WMsgBox("Invalid Path or File.");
                return;
            }
            if (txtPwd.Text.Trim().Length == 0)
            {
                st.WMsgBox("Please Calculate a Hash Value for the File.");
                return;
            }
            BackgroundWorker w = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };
            w.DoWork += new DoWorkEventHandler(FileSend);
            w.ProgressChanged += new ProgressChangedEventHandler(FileSendingStatus);
            w.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FileSentCompleted);
            lblm.Text = "";
            lblm.Visible = true;
            pb.Visible = true;
            ldr.Visible = true;
            btnSend.Enabled = false;
            /**/
            SenderArgs sa = new SenderArgs()
            {
                hme = this.hmethod,
                rest = txtPath.Text.Trim() + "~" + txtPwd.Text + "~" + lstOnline.SelectedItem
            };
            w.RunWorkerAsync(sa);
        }
        struct SenderArgs
        {
            public HashName hme;
            public string rest;
        }
        void FileSend(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = sender as BackgroundWorker;
            try
            {
                //using (FileStream fs = File.Open(e.Argument + "", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                //using (BufferedStream bs = new BufferedStream(fs))
                //using (StreamReader sr = new StreamReader(bs))
                //{
                //    string line;
                //    while ((line = sr.ReadLine()) != null)
                //    {

                //        Thread.Sleep(100);
                //    }
                //}
                int i = 1;
                string tp = ((SenderArgs)e.Argument).rest;
                string fname = tp.Split('~')[0];
                string efile = new FileInfo(fname).Name + ".fe";
                string pwd = tp.Split('~')[1];
                CryptoHelp.EncryptFile(fname, efile, pwd, (min, max, val) =>
                {
                    //pb.Minimum = min;
                    //pb.Maximum = max;
                    //pb.Value = val;
                    //Application.DoEvents();
                    w.ReportProgress(val, min + "~" + max + "~" + val);
                });
                i++;
                w.ReportProgress(i++, "File Encrypted...");
                Thread.Sleep(1000);
                Document dd = new Document();
                dd.Length = new FileInfo(fname).Length;
                dd.lastModified = new FileInfo(fname).LastWriteTime;
                byte[] efiledata = File.ReadAllBytes(efile);
                dd.FileData = efiledata;
                dd.HashMethod = ((SenderArgs)e.Argument).hme;
                string touser = tp.Split('~')[2];
                string tousertbl = touser.Split(',')[1].Trim().Replace(' ', '_') + "_" + touser.Split(',')[0].Trim();
                string fromemp = st.GetCurrentUserTableName();
                // i = -999;
                if (efiledata != null)
                {
                    w.ReportProgress(i++, "Sending File...");
                    SqlConnection cn = new SqlConnection(st.ConStr);
                    cn.Open();
                    SqlCommand cd = new SqlCommand
                        ("INSERT INTO " + tousertbl + " (fid, fname, fromemp,toemp, dttime, filekey, filecontents, filesize) VALUES('" +
                        st.generateID(tousertbl, "fid", "FL") + "','" +
                        new FileInfo(fname).Name + "','" +
                        fromemp + "','" +
                        tousertbl + "','" +
                        DateTime.Now.ToString("M-d-yyyy HH:mm:ss") + "','" +
                        pwd + "',@fdata," +
                        new FileInfo(efile).Length + ")", cn);

                    cd.Parameters.AddWithValue("@fdata", st.ObjectToByteArray(dd));
                    //st.IMsgBox(cd.CommandText); 
                    for (int j = 1 - 500; j <= 100 - 500; j++)
                    {
                        w.ReportProgress(j, "0~100~" + (j + 500));
                        if (j + 500 == 30)
                        {
                            cd.ExecuteNonQuery();
                        }
                        if (j + 500 == 70)
                        {
                            cd.CommandText = "INSERT INTO " + fromemp + " (fid, fname, fromemp,toemp, dttime, filekey, filecontents, filesize) VALUES('" +
                                st.generateID(fromemp, "fid", "FL") + "','" +
                                new FileInfo(fname).Name + "','" +
                                fromemp + "','" +
                                tousertbl + "','" +
                                DateTime.Now.ToString("M-d-yyyy HH:mm:ss") + "','" +
                                pwd + "',@fdata," +
                                new FileInfo(efile).Length + ")";
                            cd.Parameters.Clear();
                            cd.Parameters.AddWithValue("@fdata", st.ObjectToByteArray(dd));
                            cd.ExecuteNonQuery();
                        }

                        Thread.Sleep(10);
                    }
                    File.Delete(efile);
                    cn.Close();
                    //  st.IMsgBox("sdf");
                }
            }
            catch (Exception ex)
            {
                st.EMsgBox("Error Occured While Reading the File : " + ex.ToString());
            }
        }
        HashName hmethod;
        void FileSendingStatus(object sender, ProgressChangedEventArgs e)
        {
            pb.Visible = true;
            lblm.Visible = true;
            string us = e.UserState.ToString();
            if (us.Contains("~"))
            {
                pb.Minimum = Convert.ToInt32(us.Split('~')[0]);
                pb.Maximum = Convert.ToInt32(us.Split('~')[1]);
                pb.Value = Convert.ToInt32(us.Split('~')[2]);
                lblm.Text = "Encrypting the File...";
            }
            else
                lblm.Text = us;
            if (e.ProgressPercentage < 0)
            {
                pb.Minimum = Convert.ToInt32(us.Split('~')[0]);
                pb.Maximum = Convert.ToInt32(us.Split('~')[1]);
                pb.Value = Convert.ToInt32(us.Split('~')[2]);
                lblm.Text = "Sending the File...";
            }
        }

        void FileSentCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //st.IMsgBox("File Upload Completed");
            pb.Visible = false;
            lblm.Text = "File Sent Successfully.";
            ldr.Visible = false;
            btnSend.Enabled = true;
            txtPwd.Text = "";
            txtPath.Text = "";
            FrmSendFileC_Load(null, null);
            BackgroundWorker w = new BackgroundWorker();
            w.DoWork += new DoWorkEventHandler((ss, ee) =>
            {
                Thread.Sleep(6000);
            });
            w.RunWorkerCompleted += new RunWorkerCompletedEventHandler((sss, eee) =>
            {
                lblm.Text = "";
            });
            w.RunWorkerAsync();
        }

        private void FrmSendFileC_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            try
            {
                cmbHashAlg.DataSource = Enum.GetValues(typeof(HashName));
                //st.IMsgBox(st.ComputeHash("Gokul", "jai",HashName.SHA1));
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlDataReader rd = new SqlCommand("SELECT * FROM employees WHERE groop='" + st.CurGroup + "'", cn).ExecuteReader();
                lstOnline.Items.Clear();
                while (rd.Read())
                {
                    if (rd[0] + "" == st.CurrentUser)
                        continue;
                    lstOnline.Items.Add(rd[0] + ", " + rd[1]);
                }
                cn.Close();
                if (lstOnline.Items.Count > 0) lstOnline.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                st.EMsgBox(ex.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "All Files(*.*) |*.*";
            dl.Multiselect = false;
            if (dl.ShowDialog() != DialogResult.Cancel)
            {
                txtPath.Text = dl.FileName;
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            btnSend.Enabled = txtPwd.Text.Trim().Length > 0;
        }

        private void btnHashCalc_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Trim().Length == 0)
            {
                st.WMsgBox("Please Choose a File.");
                return;
            }
            if (cmbHashAlg.SelectedIndex == -1)
            {
                st.WMsgBox("Please Choose a Hashing Algorithm.");
                return;
            }
            FileInfo f = new FileInfo(txtPath.Text.Trim());
            if (!f.Exists)
            {
                st.WMsgBox("No Such File Exists..");
                return;
            }
            string raw = f.Length + f.LastWriteTime.ToString();
            hmethod = (HashName)cmbHashAlg.SelectedValue;
            txtPwd.Text = st.ComputeHash(raw, "gj", this.hmethod);
        }
    }
}
