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
    public partial class FrmDownload : Form
    {
        public FrmDownload()
        {
            InitializeComponent();
        }
        string fd, fn, hv;
        public FrmDownload(string fid, string fname, string h)
        {
            InitializeComponent();
            fd = fid;
            fn = fname;
            hv = h;
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(st.ConStr);
            cn.Open();
            SqlDataReader rd = new SqlCommand("SELECT * FROM " + st.GetCurrentUserTableName() + " WHERE fid='" + fd + "'", cn).ExecuteReader();
            if (rd.Read())
            {
                //download the File.
                //st.IMsgBox("Download...");
                BackgroundWorker w = new BackgroundWorker()
                {
                    WorkerReportsProgress = true,
                    WorkerSupportsCancellation = true
                };
                w.DoWork += new DoWorkEventHandler((ss, ee) =>
                {
                    try
                    {
                        int p = -999;
                        SqlConnection cn1 = new SqlConnection(st.ConStr);
                        cn1.Open();
                        byte[] fdata = (byte[])new SqlCommand("SELECT filecontents FROM " + st.GetCurrentUserTableName() + " WHERE fid='" + ee.Argument.ToString().Split('~')[0].Trim() + "'", cn1).ExecuteScalar();
                        if (fdata != null)
                        {
                            w.ReportProgress(p++, "Downloading to Temp...");
                            Thread.Sleep(500);
                            string fnm = ee.Argument.ToString().Split('~')[1].Trim();
                            Directory.CreateDirectory("C:\\itemp");
                            string efpath = "C:\\itemp\\" + fnm.Substring(fnm.LastIndexOf('\\') + 1) + ".fe";
                            FileStream fs = new FileStream(efpath, FileMode.Create);
                            Document dd = (Document)st.ByteArrayToObject(fdata);
                            fs.Write(dd.FileData, 0, dd.FileData.Length);
                            fs.Flush();
                            fs.Close();
                            w.ReportProgress(p++, "File Downloaded to TEMP...");
                            Thread.Sleep(500);
                            string effinish = efpath.Remove(efpath.LastIndexOf('.'));
                            CryptoHelp.DecryptFile(efpath, effinish, ee.Argument.ToString().Split('~')[2].Trim(), (min, max, val) =>
                            {
                                w.ReportProgress(val, min + "~" + max + "~" + val);
                            });
                            w.ReportProgress(p++, "File Decrypted Successfully.");
                            Thread.Sleep(1000);
                            w.ReportProgress(p++, "Verifying the Hash Value of the File.");
                            Thread.Sleep(1000);
                            string hs=st.ComputeHash(dd.Length + dd.lastModified.ToString(), "gj", dd.HashMethod);
                            //w.ReportProgress(p++, "");
                            /*SaveFileDialog saveAs = new SaveFileDialog();
                            saveAs.AddExtension = true;
                            saveAs.Filter = "Files |*." + new FileInfo(efpath).Extension;
                            if (saveAs.ShowDialog() != DialogResult.Cancel)
                            {
                                string nfname = saveAs.FileName;
                                File.Copy(effinish, nfname);
                                st.IMsgBox("File Downloaded Successfully.");
                            }*/
                            ee.Result = effinish + "~" + hs;

                        }
                        cn1.Close();
                    }
                    catch (Exception ex)
                    {
                        st.EMsgBox(ex.ToString());
                    }
                });
                w.ProgressChanged += new ProgressChangedEventHandler((sss, eee) =>
                {
                    pb.Visible = true;
                    lbls.Visible = true;
                    string us = eee.UserState + "";
                    if (eee.ProgressPercentage < 0)
                    {
                        lbls.Text = us;
                    }
                    else
                    {
                        pb.Minimum = Convert.ToInt32(us.Split('~')[0].Trim());
                        pb.Maximum = Convert.ToInt32(us.Split('~')[1].Trim());
                        pb.Value = Convert.ToInt32(us.Split('~')[2].Trim());
                        lbls.Text = "Decrypting the File...";
                    }
                });
                w.RunWorkerCompleted += new RunWorkerCompletedEventHandler((ssss, eeee) =>
                {
                    pb.Visible = false;
                    string effinish = eeee.Result.ToString().Split('~')[0].Trim();
                    txtDocumentKey.Text = eeee.Result.ToString().Split('~')[1].Trim();
                    if (txtFkey.Text.Trim() == txtDocumentKey.Text.Trim())
                    {
                        SaveFileDialog saveAs = new SaveFileDialog();
                        saveAs.AddExtension = true;
                        saveAs.Filter = "Files |*" + new FileInfo(effinish).Extension;
                        saveAs.FileName = new FileInfo(effinish).Name;
                        lbls.Text = "Hash Values Matched.";
                        if (saveAs.ShowDialog() != DialogResult.Cancel)
                        {
                            string nfname = saveAs.FileName;
                            File.Copy(effinish, nfname);
                            st.IMsgBox("File Downloaded Successfully.\n\n[" + nfname + "]");
                            try
                            {
                                File.Delete(effinish);
                                File.Delete(effinish + ".fe");
                                Directory.Delete("C:\\itemp");
                            }
                            catch { }
                            this.Close();
                        }
                    }
                    else
                    {
                        st.EMsgBox("The Document Was Modified / Intrusion Occured.\nThe Hash Signature Doesn't Match the File Origin.");
                        lbls.Text = "Hash Values Mismatch.";
                        try
                        {
                            File.Delete(effinish);
                            File.Delete(effinish + ".fe");
                            Directory.Delete("C:\\itemp");
                        }
                        catch { }
                        //this.Close();
                    }
                });
                btnDownload.Enabled = false;
                w.RunWorkerAsync(rd["fid"] + "~" + rd["fname"] + "~" + rd["filekey"]);
            }
            else
            {
                st.EMsgBox("Invalid File Key. Download Failed.");
            }
            cn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmDownload_Load(object sender, EventArgs e)
        {
            lblFname.Text = fn;
            txtFkey.Text = hv;
        }

        private void txtFkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = "0123456789\babcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (a.IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }
    }
}
