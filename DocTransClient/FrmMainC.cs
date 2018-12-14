using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocTransClient
{
    public partial class FrmMainC : Form
    {
        public FrmMainC()
        {
            InitializeComponent();
        }
        string currentUser;
        string grp;
        public FrmMainC(string curuser, string grp)
        {
            InitializeComponent();
            currentUser = curuser;
            st.CurrentUser = curuser;
            st.CurGroup = grp;
            this.grp = grp;
        }
        private void FrmMainC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        Form fm;
        void loadForm(Form f)
        {
            if (fm != null)
            {
                fm.Close();
            }
            fm = f;
            fm.MdiParent = this;
            fm.Size = new Size(this.ClientSize.Width - 224, this.ClientSize.Height - 44);
            fm.Show();
        }
        private void FrmMainC_Load(object sender, EventArgs e)
        {
            lblusr.Text = st.GetCurrentUserTableName();
            lblTime.Text = "";
            taskPane1.UseCustomTheme("panther.dll");
            panel1.BackgroundImage = taskPane1.BackgroundImage;
            panel2.BackgroundImage = taskPane1.BackgroundImage;
            panel3.BackgroundImage = taskPane1.BackgroundImage;
            Timer t = new Timer()
            {
                Interval = 1000,
                Enabled = true
            };
            t.Tick += new EventHandler((object s, EventArgs e1) =>
            {
                lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tiInbox_Click(object sender, EventArgs e)
        {
            loadForm(new FrmShowBox(st.GetCurrentUserTableName(), "inbox"));
        }

        private void tiSend_Click(object sender, EventArgs e)
        {
            loadForm(new FrmSendFileC());
        }

        private void tiSent_Click(object sender, EventArgs e)
        {
            loadForm(new FrmShowBox(st.GetCurrentUserTableName(), "sent"));
        }
    }
}
