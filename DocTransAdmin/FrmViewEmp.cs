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

namespace DocTransAdmin
{
    public partial class FrmViewEmp : Form
    {
        public FrmViewEmp()
        {
            InitializeComponent();
        }
        DataSet ds;
        BindingSource src;
        void setImage()
        {
            if (src.Count == 0 || src.Position == -1)
                return;
            byte[] idata = (byte[])ds.Tables[0].Rows[src.Position]["img"];
            //st.IMsgBox(idata.Length);
            MemoryStream ms = new MemoryStream(idata, 0, idata.Length);
            picIris.BackgroundImage = Image.FromStream(ms);
            ml.Message = (src.Position + 1) + " / " + src.Count + "  ";
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
                   /* if (rd["GP"] + "" == "General")
                        continue;*/
                    cmbGroup.Items.Add(rd["GP"] + "");
                }
                cmbGroup.Items.Add("--ALL--");
                cn.Close();
                if (cmbGroup.Items.Count > 0) cmbGroup.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                st.WMsgBox(ex.ToString());
            }
        }
        private void FrmViewEmp_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            foreach (Control x in Controls)
            {
                if (x.Name.StartsWith("lbl"))
                    x.Text = "";
            }
            addGroups();
            cmbGroup_SelectedIndexChanged(null, null);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (src != null)
            {
                src.MoveFirst();
                setImage();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (src != null)
            {
                src.MoveLast();
                setImage();
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex == -1)
                return;
            string sq = "";
            if (cmbGroup.SelectedIndex == cmbGroup.Items.Count - 1)
                sq = "SELECT * FROM employees ORDER BY CAST(SUBSTRING(eid , 4 , 9999) AS INT)";
            else
                sq = "SELECT * FROM employees WHERE groop='" + cmbGroup.Text + "' ORDER BY CAST(SUBSTRING(eid , 4 , 9999) AS INT)";
            SqlConnection cn = new SqlConnection(st.ConStr);
            cn.Open();

            SqlDataReader rd = new SqlCommand(sq, cn).ExecuteReader();
            int c = 0;
            while (rd.Read())
                c++;
            rd.Close();
            rd.Dispose();
            lblTot.Text = c + "";            
            if (c == 0)
            {
                if (src != null)
                {
                    src.Dispose();
                    src = null;
                }
                foreach (Control x in Controls)
                {
                    if (x.Name == "lblTot")
                    {
                        x.Text = "No Members";
                        ml.Message = "0 / 0  ";
                        continue;
                    }
                    if (x.Name.StartsWith("lbl"))
                        x.Text = "";
                    if (x is PictureBox)
                        ((PictureBox)x).BackgroundImage = null;
                }
                return;
            }
            ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(sq, cn);
            adp.Fill(ds, "employees");

            if (src != null)
                src.Dispose();
            src = new BindingSource()
            {
                DataSource = ds,
                DataMember = "employees"
            };
            lblEid.DataBindings.Clear();
            lblEname.DataBindings.Clear();
            lblPh.DataBindings.Clear();
            lblIkey.DataBindings.Clear();
            lblGroup.DataBindings.Clear();

            lblEid.DataBindings.Add("Text", src, "eid");
            lblEname.DataBindings.Add("Text", src, "ename");
            lblPh.DataBindings.Add("Text", src, "phone");
            lblIkey.DataBindings.Add("Text", src, "imgkey");
            lblGroup.DataBindings.Add("Text", src, "groop");
            ml.Message = (src.Position + 1) + " / " + src.Count + "  ";
            //picIris.DataBindings.Add("BackgroundImage", src, "img");
            src.MoveFirst();
            setImage();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int pos = src.Position;
            DialogResult rs = new FrmEditEmpA(lblEid.Text).ShowDialog();
            if (rs == DialogResult.OK)
            {
                cmbGroup_SelectedIndexChanged(null, null);
                src.Position = pos;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (src != null)
            {
                src.MovePrevious();
                setImage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (src != null)
            {
                src.MoveNext();
                setImage();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblEid.Text.Trim() == "")
            {
                st.WMsgBox("No Employee Selected.");
                return;
            }
            if (st.CMsgBox("Are you Sure? Want to Delete the Employee Details?\nEntire Files and Transactions will be Deleted.") == DialogResult.No)
                return;
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                new SqlCommand("DELETE FROM employees WHERE eid='" + lblEid.Text + "'", cn).ExecuteNonQuery();
                new SqlCommand("DROP TABLE " + lblEname.Text.Replace(' ', '_') + "_" + lblEid.Text, cn).ExecuteNonQuery();
                cn.Close();
                st.IMsgBox(string.Format("The Employee Details [{0} - {1}] Deleted Successfully", lblEid.Text, lblEname.Text));
                FrmViewEmp_Load(null, null);
                //cmbGroup_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                st.EMsgBox(ex.ToString());
            }
        }
    }
}
