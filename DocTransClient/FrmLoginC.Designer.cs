namespace DocTransClient
{
    partial class FrmLoginC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginC));
            this.pl = new System.Windows.Forms.ProgressBar();
            this.ls = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpload = new GTools.GButton();
            this.btnBrowse = new GTools.GButton();
            this.txtIrisImg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImgKey = new System.Windows.Forms.TextBox();
            this.lblMs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.Location = new System.Drawing.Point(306, 153);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(206, 13);
            this.pl.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pl.TabIndex = 18;
            this.pl.Visible = false;
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.BackColor = System.Drawing.Color.Transparent;
            this.ls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ls.Location = new System.Drawing.Point(306, 137);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(65, 13);
            this.ls.TabIndex = 20;
            this.ls.Text = "Iris Image : ";
            this.ls.Visible = false;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(194, 80);
            this.txtEname.Name = "txtEname";
            this.txtEname.ReadOnly = true;
            this.txtEname.Size = new System.Drawing.Size(219, 21);
            this.txtEname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(38, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Employee Name :";
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(194, 53);
            this.txtEid.Name = "txtEid";
            this.txtEid.ReadOnly = true;
            this.txtEid.Size = new System.Drawing.Size(98, 21);
            this.txtEid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(38, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Employee ID : ";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.ButtonStyle = GTools.GButton.ButtonStyles.Red;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.HoverTextColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(194, 134);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Radius = 4;
            this.btnUpload.Size = new System.Drawing.Size(104, 35);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload & Login";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ButtonStyle = GTools.GButton.ButtonStyles.Green;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(503, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Radius = 3;
            this.btnBrowse.Size = new System.Drawing.Size(27, 25);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtIrisImg
            // 
            this.txtIrisImg.Location = new System.Drawing.Point(194, 26);
            this.txtIrisImg.Name = "txtIrisImg";
            this.txtIrisImg.Size = new System.Drawing.Size(304, 21);
            this.txtIrisImg.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(38, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Iris Image : ";
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.Color.Transparent;
            this.pc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc.Location = new System.Drawing.Point(194, 184);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(177, 142);
            this.pc.TabIndex = 25;
            this.pc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Image Key : ";
            // 
            // txtImgKey
            // 
            this.txtImgKey.Location = new System.Drawing.Point(194, 107);
            this.txtImgKey.Name = "txtImgKey";
            this.txtImgKey.ReadOnly = true;
            this.txtImgKey.Size = new System.Drawing.Size(219, 21);
            this.txtImgKey.TabIndex = 3;
            // 
            // lblMs
            // 
            this.lblMs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMs.BackColor = System.Drawing.Color.Transparent;
            this.lblMs.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMs.Location = new System.Drawing.Point(12, 331);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(562, 29);
            this.lblMs.TabIndex = 20;
            this.lblMs.Text = "Iris Image : ";
            this.lblMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMs.Visible = false;
            // 
            // FrmLoginC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(586, 367);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtIrisImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.lblMs);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.txtImgKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLoginC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Document Transfer Client";
            this.Load += new System.EventHandler(this.FrmLoginC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pl;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.Label label3;
        private GTools.GButton btnUpload;
        private GTools.GButton btnBrowse;
        private System.Windows.Forms.TextBox txtIrisImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImgKey;
        private System.Windows.Forms.Label lblMs;
    }
}

