using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DocTransAdmin
{
    public partial class FrmEditEmpA : Form
    {
        public FrmEditEmpA()
        {
            InitializeComponent();
        }
        string EmpId;
        public FrmEditEmpA(string eid)
        {
            InitializeComponent();
            this.EmpId = eid;
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
        private void FrmEditEmpA_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpId))
            {
                st.EMsgBox("No Employee ID Set.");
                Close();
                return;
            }
            try
            {
                addGroups();
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                SqlDataReader rd = new SqlCommand("SELECT * FROM employees WHERE eid='" + EmpId + "'", cn).ExecuteReader();
                if (rd.Read())
                {
                    txtEid.Text = EmpId;
                    txtEname.Text = rd[1] + "";
                    txtPho.Text = rd["phone"] + "";
                    cmbGroup.Text = rd["groop"] + "";
                }
                /*this.DialogResult = DialogResult.OK;*/
                cn.Close();
            }
            catch (Exception ex)            
            {
                st.EMsgBox(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (st.CMsgBox("Are you Sure? Want to Close? The Changes made will not be Saved.") == DialogResult.No)
                return;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(st.ConStr);
                cn.Open();
                new SqlCommand("UPDATE employees SET ename='" + txtEname.Text + "', phone='" + txtPho.Text + "', groop='" + cmbGroup.Text + "' WHERE eid='" + txtEid.Text + "'", cn).ExecuteNonQuery();
                cn.Close();
                st.IMsgBox("Information Updated Successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                st.EMsgBox(ex.ToString());
            }
        }
    }
}
