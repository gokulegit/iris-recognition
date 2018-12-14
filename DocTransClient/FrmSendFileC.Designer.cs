namespace DocTransClient
{
    partial class FrmSendFileC
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new GTools.GButton();
            this.lstOnline = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new GTools.GButton();
            this.btnCancel = new GTools.GButton();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblm = new System.Windows.Forms.Label();
            this.ldr = new MRG.Controls.UI.LoadingCircle();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnHashCalc = new GTools.GButton();
            this.cmbHashAlg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send a File";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(102, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 1);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose a File :";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(224, 106);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(346, 25);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(576, 106);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Radius = 4;
            this.btnBrowse.Size = new System.Drawing.Size(27, 26);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstOnline
            // 
            this.lstOnline.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOnline.FormattingEnabled = true;
            this.lstOnline.ItemHeight = 18;
            this.lstOnline.Location = new System.Drawing.Point(224, 230);
            this.lstOnline.Name = "lstOnline";
            this.lstOnline.Size = new System.Drawing.Size(379, 112);
            this.lstOnline.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose an Employee :";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverTextColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(224, 356);
            this.btnSend.Name = "btnSend";
            this.btnSend.Radius = 4;
            this.btnSend.Size = new System.Drawing.Size(98, 32);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.Send_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonStyle = GTools.GButton.ButtonStyles.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(328, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 4;
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(224, 409);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(379, 15);
            this.pb.TabIndex = 6;
            this.pb.Visible = false;
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblm.Location = new System.Drawing.Point(224, 429);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(123, 18);
            this.lblm.TabIndex = 0;
            this.lblm.Text = "Choose an Employee :";
            this.lblm.Visible = false;
            // 
            // ldr
            // 
            this.ldr.Active = true;
            this.ldr.Color = System.Drawing.Color.DarkGoldenrod;
            this.ldr.InnerCircleRadius = 8;
            this.ldr.Location = new System.Drawing.Point(182, 401);
            this.ldr.Name = "ldr";
            this.ldr.NumberSpoke = 24;
            this.ldr.OuterCircleRadius = 9;
            this.ldr.RotationSpeed = 20;
            this.ldr.Size = new System.Drawing.Size(35, 33);
            this.ldr.SpokeThickness = 4;
            this.ldr.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7;
            this.ldr.TabIndex = 7;
            this.ldr.Text = "loadingCircle1";
            this.ldr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hash Value :";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(224, 189);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.ReadOnly = true;
            this.txtPwd.Size = new System.Drawing.Size(379, 25);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // btnHashCalc
            // 
            this.btnHashCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnHashCalc.ButtonStyle = GTools.GButton.ButtonStyles.Blue;
            this.btnHashCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHashCalc.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashCalc.ForeColor = System.Drawing.Color.White;
            this.btnHashCalc.HoverTextColor = System.Drawing.Color.White;
            this.btnHashCalc.Location = new System.Drawing.Point(432, 145);
            this.btnHashCalc.Name = "btnHashCalc";
            this.btnHashCalc.Radius = 4;
            this.btnHashCalc.Size = new System.Drawing.Size(127, 29);
            this.btnHashCalc.TabIndex = 4;
            this.btnHashCalc.Text = "Compute Hash";
            this.btnHashCalc.Click += new System.EventHandler(this.btnHashCalc_Click);
            // 
            // cmbHashAlg
            // 
            this.cmbHashAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHashAlg.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHashAlg.FormattingEnabled = true;
            this.cmbHashAlg.Location = new System.Drawing.Point(224, 147);
            this.cmbHashAlg.Name = "cmbHashAlg";
            this.cmbHashAlg.Size = new System.Drawing.Size(202, 26);
            this.cmbHashAlg.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hashing Algorithm : ";
            // 
            // FrmSendFileC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(715, 539);
            this.Controls.Add(this.cmbHashAlg);
            this.Controls.Add(this.ldr);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lstOnline);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHashCalc);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSendFileC";
            this.Text = "FrmSendFileC";
            this.Load += new System.EventHandler(this.FrmSendFileC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private GTools.GButton btnBrowse;
        private System.Windows.Forms.ListBox lstOnline;
        private System.Windows.Forms.Label label4;
        private GTools.GButton btnSend;
        private GTools.GButton btnCancel;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblm;
        private MRG.Controls.UI.LoadingCircle ldr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPwd;
        private GTools.GButton btnHashCalc;
        private System.Windows.Forms.ComboBox cmbHashAlg;
        private System.Windows.Forms.Label label6;
    }
}