using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace DocTransClient
{
    public partial class FrmShowBox : Form
    {
        public FrmShowBox()
        {
            InitializeComponent();
        }
        string tablename;
        string curView;
        public FrmShowBox(string tableName, string view)
        {
            InitializeComponent();
            tablename = tableName;
            curView = view;
        }
        void showData(string tname , string curv)
        {
            btnRefresh.Enabled = false;
            btnDownload.Enabled = false;
            dg.Enabled = false;
            ldr.Visible = true;
            btnDemo.Enabled = false;
            DataTable dt = new DataTable();
            BackgroundWorker w = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            w.DoWork += new DoWorkEventHandler((s1, e1) =>
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                Thread.Sleep(1000);
                string q = "";
                if (curv == "inbox")
                    q = "SELECT fid as [File ID], dttime as [Date], fname as [File Name], filekey as [Hash Value], fromemp as [From],toemp as [To], filesize as [Size (bytes)] FROM " + tname + " WHERE toemp='" + st.GetCurrentUserTableName() + "'";
                else if (curv == "sent")
                    q = "SELECT fid as [File ID],dttime as [Date], fname as [File Name], filekey as [Hash Value], fromemp as [From], toemp as [To], filesize as [Size (bytes)] FROM " + tname + " WHERE fromemp='" + st.GetCurrentUserTableName() + "'";
                SqlDataReader rd = new SqlCommand(q, cn).ExecuteReader();
                dt.Load(rd);
                cn.Close();
                e1.Result = dt;
            });
            w.ProgressChanged += new ProgressChangedEventHandler((s2, e2) =>
            {
                ldr.Visible = true;
            });
            w.RunWorkerCompleted += new RunWorkerCompletedEventHandler((s3, e3) =>
            {
                ldr.Visible = false;
                btnRefresh.Enabled = true;
                btnDownload.Enabled = true;
                btnDemo.Enabled = true;
                dg.Enabled = true;
                dg.DataSource = ((DataTable)e3.Result).DefaultView;
                dg.ReadOnly = true;
                dg.RowTemplate.Height = 35;
                dg.Refresh();
            });
            w.RunWorkerAsync();
        }
        private void FrmShowBox_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            if (tablename != null && curView != null)
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                DataTable dt = new DataTable();
                switch (curView)
                {
                    case "inbox":
                        lblhead.Text = "Inbox";
                        btnDemo.Visible = false;
                        break;
                    case "sent":
                        lblhead.Text = "Sent Files";
                        btnDemo.Visible = true;
                        break;
                }
                showData(this.tablename, this.curView);               
                cn.Close();
            }
        }

        private void Refresh_click(object sender, EventArgs e)
        {
            showData(this.tablename, this.curView);
        }

        private void Download_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count == 0)
            {
                st.WMsgBox("Please Select a File to Download.,");
                return;
            }
            string fid = dg.SelectedRows[0].Cells[0].Value + "";
            if (fid != null)
            {
                try
                {
                    new FrmDownload(fid, dg.SelectedRows[0].Cells[2].Value + "", dg.SelectedRows[0].Cells[3].Value + "").ShowDialog(this);
                }
                catch { }
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count == 0)
            {
                st.WMsgBox("Please Select a Row/File to Modify.");
                return;
            }
            if (st.CMsgBox("Are you Sure? This Operation Can't be Undone.\nAfter the Execution of this operation, The File data will be Unusable.") == DialogResult.No)
                return;
            string fid = dg.SelectedRows[0].Cells[0].Value + "";
            try
            {
                SqlConnection c = new SqlConnection(st.ConStr);
                c.Open();
                string toUser = new SqlCommand("SELECT toemp FROM " + tablename + " WHERE fid='" + fid + "'", c).ExecuteScalar() + "";
                Document dd = (Document)st.ByteArrayToObject((byte[])new SqlCommand("SELECT filecontents FROM " + tablename + " WHERE fid='" + fid + "'", c).ExecuteScalar());
                if (dd != null)
                {
                    dd.lastModified = DateTime.Now;
                    byte[] n = dd.FileData;
                }
                byte[] newdata = st.ObjectToByteArray(dd);
                SqlCommand cmd = new SqlCommand("UPDATE " + toUser + " SET filecontents=@fdata WHERE fid=@fid", c);
                cmd.Parameters.AddWithValue("@fdata", newdata);
                cmd.Parameters.AddWithValue("@fid", fid);
                cmd.ExecuteNonQuery();
                st.IMsgBox("The Intrusion on [" + fid + "] Was Made successfully.");
                c.Close();
            }
            catch (Exception)
            {
                st.EMsgBox("Could Not Able to Modify the File Content of Selected File.");
            }
        }
    }
}
