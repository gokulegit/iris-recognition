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
using System.IO;

namespace DocTransAdmin
{
    public partial class FrmLoginA : Form
    {
        public FrmLoginA()
        {
            InitializeComponent();
        }
        void enable(bool v)
        {
            foreach (Control x in Controls)
            {
                if (x is Label)
                    continue;
                x.Enabled = v;
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            enable(false);
            lb.Text = "Initializing Database...";
            this.Height = 195;
            BackgroundWorker wr = new BackgroundWorker()
            {
                WorkerReportsProgress = true
            };
            wr.DoWork += new DoWorkEventHandler(InitDB_Background);
            wr.ProgressChanged += new ProgressChangedEventHandler(InitDB_ProChange);
            wr.RunWorkerCompleted += new RunWorkerCompletedEventHandler(InitComplete);
            wr.RunWorkerAsync();
        }

        void InitComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            pb.Visible = false;
            this.Height = 170;
            enable(true);
            txtUn.Focus();
        }

        void InitDB_ProChange(object sender, ProgressChangedEventArgs e)
        {
            this.pb.Visible = true;
            this.Height = 195;
            this.lb.Text = "Initializing Database...";
        }

        void InitDB_Background(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                cn.Close();
                Thread.Sleep(5);
                ((BackgroundWorker)sender).ReportProgress(i);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            /*if (txtPass.Text == (DateTime.Now.Year - DateTime.Now.Day).ToString())
            {
                this.Hide();
                new FrmMainA().Show();
                return;
            }
            txtPass.Text = "";
            st.EMsgBox("Password Incorrect.");*/
            try
            {
                StreamReader rd = File.OpenText("user-credentials.txt");
                string s = "";
                bool lg = false;
                while (!string.IsNullOrEmpty(s = rd.ReadLine()))
                {
                    if (txtUn.Text.Trim() == s.Split('-')[0].Trim() && txtPass.Text.Equals(s.Split('-')[1]))
                    {
                        lg = true;
                        break;
                    }
                }
                if (lg)
                {
                    Hide();
                    new FrmMainA().Show();
                }
                else
                {
                    st.EMsgBox("Invalid Login..");
                    txtPass.Text = "";
                    txtUn.Focus();
                }
            }
            catch { st.EMsgBox("Error Opening the User-Credentials File."); }
        }
    }
}
