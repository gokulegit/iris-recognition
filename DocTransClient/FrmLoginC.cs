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
    public partial class FrmLoginC : Form
    {
        public FrmLoginC()
        {
            InitializeComponent();
        }

        private void FrmLoginC_Load(object sender, EventArgs e)
        {
            /*SqlConnection cn = new SqlConnection(st.ConStr);
            cn.Open();*/
            lblMs.Text = "";
            /*txtEname.AutoCompleteCustomSource.Clear();
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlDataReader rd = new SqlCommand("SELECT * FROM employees", cn).ExecuteReader();
                while (rd.Read())
                {
                    txtEname.AutoCompleteCustomSource.Add(rd[1] + ", " + rd[0]);
                }
                txtEname.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtEname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtEname.Focus();
                cn.Close();
            }
            catch (Exception ex)
            {
                st.EMsgBox(ex.ToString());
            }*/
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtIrisImg.Text.Trim().Length == 0)
            {
                st.WMsgBox("Please Choose an Iris Image.");
                return;
            }
            if (!new FileInfo(txtIrisImg.Text.Trim()).Exists)
            {
                st.WMsgBox("Invalid Path. No Image was Selected.");
                return;
            }
            BackgroundWorker wr = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };
            wr.DoWork += new DoWorkEventHandler(IrisUploadNow);
            wr.ProgressChanged += new ProgressChangedEventHandler(IrisUploading);
            wr.RunWorkerCompleted += new RunWorkerCompletedEventHandler(IrisUploadCompleted);
            btnUpload.Enabled = false;
            
            pc.BackgroundImage = Image.FromFile(txtIrisImg.Text.Trim());
            pl.Visible = true;
            ls.Visible = true;
            ls.Text = "";
            wr.RunWorkerAsync(txtIrisImg.Text.Trim());
        }

        void IrisUploadNow(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = sender as BackgroundWorker;
            int ins = int.MinValue;
            w.ReportProgress(ins++, "Initializing The Scanning Engine");
            Thread.Sleep(1000);
            w.ReportProgress(ins++, "Performing Scanning Iris Image...");
            IrisRecognitionNative.IrisReg ir = new IrisRecognitionNative.IrisReg();
            object c = null;
            try { c = ir.createiristemplate(e.Argument.ToString()); }
            catch (Exception ex)
            {
                st.WMsgBox("Invalid Image Or Could not able to locate the IRIS data.\nInput Gray Scale Image of Maximum Size 512x512." + ex.ToString());
            }
            w.ReportProgress(ins++, "Scanning Completed...");
            System.Double[,] res = null;
            if (c != null)
            {
                res = (System.Double[,])c;
                w.ReportProgress(ins++, "Calculating Values... Please Wait.");
                string al = AlreadyMatchingTemplate(res);

                if (al == null)
                {
                    st.EMsgBox("Iris Not Found. Unable to Login.");
                    return;
                }
                else
                {
                    //w.ReportProgress(-2, ikey);
                    e.Result = al;
                }
            }
        }

        void IrisUploading(object sender, ProgressChangedEventArgs e)
        {
            ls.Text = e.UserState + "";
        }
        string grp = "";
        void IrisUploadCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                //btnUpload.Enabled = true;
                ls.Visible = false;
                pl.Visible = false;
                string re = e.Result.ToString();
                txtEid.Text = re.Split('-')[0].Trim();
                txtEname.Text = re.Split('-')[1].Trim();
                txtImgKey.Text = re.Split('-')[2].Trim();
                grp=re.Split('-')[3].Trim();
                lblMs.Text = "Login Successfull.";
                BackgroundWorker w = new BackgroundWorker()
                {
                    WorkerSupportsCancellation = false,
                    WorkerReportsProgress = true
                };
                w.DoWork += new DoWorkEventHandler((object s, DoWorkEventArgs e3) =>
                {
                    int i = 10;
                    while (i >= 1)
                    {
                        if (i == 1)
                            w.ReportProgress(i, "Login Successfull. Please Wait... " + i + " Second");
                        else
                            w.ReportProgress(i, "Login Successfull. Please Wait... " + i + " Seconds");
                        Thread.Sleep(1000);
                        i--;
                    }
                });
                w.ProgressChanged += new ProgressChangedEventHandler((object s1, ProgressChangedEventArgs e1) =>
                {
                    lblMs.Visible = true;
                    lblMs.Text = e1.UserState + "";
                });
                w.RunWorkerCompleted += new RunWorkerCompletedEventHandler((object s2, RunWorkerCompletedEventArgs e2) =>
                {
                    //st.IMsgBox("FrmMain Open.");
                    new FrmMainC(txtEid.Text, grp).Show();
                    Hide();
                });
                w.RunWorkerAsync();
            }
            else
            {
                btnUpload.Enabled = true;
                ls.Visible = false;
                pl.Visible = false;
                txtIrisImg.Focus();
            }
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
                    rlist.Add(rd["eid"] + "-" + rd["ename"] + "-" + rd["imgkey"] + "-" + rd["groop"], st.TemplateEquals(dbv, rs));
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
    }
}
