using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace DocTransAdmin
{
    public partial class FrmMainA : Form
    {
        public FrmMainA()
        {
            InitializeComponent();
        }

        private void FrmMainA_Load(object sender, EventArgs e)
        {
            try
            {
                taskPane1.UseCustomTheme("itunes.dll");
                panel1.BackgroundImage = taskPane1.BackgroundImage;
                panel2.BackgroundImage = taskPane1.BackgroundImage;
                panel3.BackgroundImage = taskPane1.BackgroundImage;
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                cn.Close();                
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
            }
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
            fm.Size = new Size(this.ClientSize.Width - 224, this.ClientSize.Height -44);
            fm.Show();
        }
        private void tiRegister_Click(object sender, EventArgs e)
        {
            loadForm(new FrmRegisterA());
        }

        private void FrmMainA_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void tiView_Click(object sender, EventArgs e)
        {
            loadForm(new FrmViewEmp());
        }
    }
}
