using GTools;
namespace DocTransAdmin
{
    partial class FrmRegisterA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIrisImg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImgKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ls = new System.Windows.Forms.Label();
            this.pl = new System.Windows.Forms.ProgressBar();
            this.picIris = new System.Windows.Forms.PictureBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lnkAdd = new System.Windows.Forms.LinkLabel();
            this.lnkDel = new System.Windows.Forms.LinkLabel();
            this.lnkEdit = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new GTools.GButton();
            this.btnRegister = new GTools.GButton();
            this.btnUpload = new GTools.GButton();
            this.btnBrowse = new GTools.GButton();
            ((System.ComponentModel.ISupportInitialize)(this.picIris)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register a New Employee";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(200, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 1);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee ID : ";
            // 
            // txtEid
            // 
            this.txtEid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEid.Location = new System.Drawing.Point(203, 80);
            this.txtEid.Name = "txtEid";
            this.txtEid.ReadOnly = true;
            this.txtEid.Size = new System.Drawing.Size(98, 25);
            this.txtEid.TabIndex = 12;
            // 
            // txtEname
            // 
            this.txtEname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEname.Location = new System.Drawing.Point(203, 132);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(219, 25);
            this.txtEname.TabIndex = 0;
            this.txtEname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEname_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Name :";
            // 
            // txtPh
            // 
            this.txtPh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPh.Location = new System.Drawing.Point(203, 184);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(146, 25);
            this.txtPh.TabIndex = 1;
            this.txtPh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPh_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(47, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone : ";
            // 
            // txtIrisImg
            // 
            this.txtIrisImg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIrisImg.Location = new System.Drawing.Point(203, 236);
            this.txtIrisImg.Name = "txtIrisImg";
            this.txtIrisImg.Size = new System.Drawing.Size(304, 25);
            this.txtIrisImg.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(47, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Iris Image : ";
            // 
            // txtImgKey
            // 
            this.txtImgKey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgKey.Location = new System.Drawing.Point(203, 321);
            this.txtImgKey.Name = "txtImgKey";
            this.txtImgKey.ReadOnly = true;
            this.txtImgKey.Size = new System.Drawing.Size(219, 25);
            this.txtImgKey.TabIndex = 5;
            this.txtImgKey.TextChanged += new System.EventHandler(this.txtImgKey_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(47, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Image Key : ";
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.BackColor = System.Drawing.Color.Transparent;
            this.ls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ls.Location = new System.Drawing.Point(340, 272);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(65, 13);
            this.ls.TabIndex = 14;
            this.ls.Text = "Iris Image : ";
            this.ls.Visible = false;
            // 
            // pl
            // 
            this.pl.Location = new System.Drawing.Point(340, 288);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(206, 13);
            this.pl.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pl.TabIndex = 6;
            this.pl.Visible = false;
            // 
            // picIris
            // 
            this.picIris.BackColor = System.Drawing.Color.Transparent;
            this.picIris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIris.Location = new System.Drawing.Point(503, 45);
            this.picIris.Name = "picIris";
            this.picIris.Size = new System.Drawing.Size(177, 164);
            this.picIris.TabIndex = 17;
            this.picIris.TabStop = false;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(201, 360);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(121, 25);
            this.cmbGroup.TabIndex = 6;
            // 
            // lnkAdd
            // 
            this.lnkAdd.AutoSize = true;
            this.lnkAdd.BackColor = System.Drawing.Color.Transparent;
            this.lnkAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkAdd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAdd.LinkColor = System.Drawing.Color.MediumBlue;
            this.lnkAdd.Location = new System.Drawing.Point(330, 366);
            this.lnkAdd.Name = "lnkAdd";
            this.lnkAdd.Size = new System.Drawing.Size(50, 13);
            this.lnkAdd.TabIndex = 7;
            this.lnkAdd.TabStop = true;
            this.lnkAdd.Text = "Add New";
            this.lnkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdd_LinkClicked);
            // 
            // lnkDel
            // 
            this.lnkDel.AutoSize = true;
            this.lnkDel.BackColor = System.Drawing.Color.Transparent;
            this.lnkDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkDel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDel.LinkColor = System.Drawing.Color.MediumBlue;
            this.lnkDel.Location = new System.Drawing.Point(447, 366);
            this.lnkDel.Name = "lnkDel";
            this.lnkDel.Size = new System.Drawing.Size(38, 13);
            this.lnkDel.TabIndex = 9;
            this.lnkDel.TabStop = true;
            this.lnkDel.Text = "Delete";
            this.lnkDel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDel_LinkClicked);
            // 
            // lnkEdit
            // 
            this.lnkEdit.AutoSize = true;
            this.lnkEdit.BackColor = System.Drawing.Color.Transparent;
            this.lnkEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEdit.LinkColor = System.Drawing.Color.MediumBlue;
            this.lnkEdit.Location = new System.Drawing.Point(386, 366);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(55, 13);
            this.lnkEdit.TabIndex = 8;
            this.lnkEdit.TabStop = true;
            this.lnkEdit.Text = "Edit Name";
            this.lnkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEdit_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(47, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Group :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(309, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 4;
            this.btnCancel.Size = new System.Drawing.Size(71, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverTextColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(199, 396);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Radius = 4;
            this.btnRegister.Size = new System.Drawing.Size(104, 35);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.HoverTextColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(201, 270);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Radius = 4;
            this.btnUpload.Size = new System.Drawing.Size(104, 35);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Scan & Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(513, 234);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Radius = 4;
            this.btnBrowse.Size = new System.Drawing.Size(38, 29);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FrmRegisterA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 498);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lnkDel);
            this.Controls.Add(this.lnkEdit);
            this.Controls.Add(this.lnkAdd);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.picIris);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.txtImgKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIrisImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegisterA";
            this.Text = "FrmRegisterA";
            this.Load += new System.EventHandler(this.FrmRegisterA_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegisterA_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picIris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIrisImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImgKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.ProgressBar pl;
        private System.Windows.Forms.PictureBox picIris;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.LinkLabel lnkAdd;
        private System.Windows.Forms.LinkLabel lnkDel;
        private System.Windows.Forms.LinkLabel lnkEdit;
        private System.Windows.Forms.Label label8;
        private GTools.GButton btnCancel;
        private GTools.GButton btnRegister;
        private GTools.GButton btnUpload;
        private GTools.GButton btnBrowse;
    }
}