namespace DocTransClient
{
    partial class FrmDownload
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
            this.btnDownload = new GTools.GButton();
            this.btnCancel = new GTools.GButton();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.txtFkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.txtDocumentKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.ButtonStyle = GTools.GButton.ButtonStyles.Orange;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.HoverTextColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(281, 202);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Radius = 4;
            this.btnDownload.Size = new System.Drawing.Size(102, 34);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonStyle = GTools.GButton.ButtonStyles.Orange;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverTextColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(389, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 4;
            this.btnCancel.Size = new System.Drawing.Size(85, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(12, 202);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(263, 34);
            this.pb.TabIndex = 3;
            this.pb.Visible = false;
            // 
            // txtFkey
            // 
            this.txtFkey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFkey.Location = new System.Drawing.Point(12, 87);
            this.txtFkey.Name = "txtFkey";
            this.txtFkey.ReadOnly = true;
            this.txtFkey.Size = new System.Drawing.Size(458, 25);
            this.txtFkey.TabIndex = 0;
            this.txtFkey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFkey_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hash Value From the Sender :";
            // 
            // lblFname
            // 
            this.lblFname.BackColor = System.Drawing.Color.Transparent;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(9, 9);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(461, 57);
            this.lblFname.TabIndex = 4;
            this.lblFname.Text = "MM";
            // 
            // lbls
            // 
            this.lbls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbls.AutoSize = true;
            this.lbls.BackColor = System.Drawing.Color.Transparent;
            this.lbls.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(9, 181);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(115, 17);
            this.lbls.TabIndex = 5;
            this.lbls.Text = "Enter the File Key :";
            this.lbls.Visible = false;
            // 
            // textBox1
            // 
            this.txtDocumentKey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentKey.Location = new System.Drawing.Point(12, 145);
            this.txtDocumentKey.Name = "textBox1";
            this.txtDocumentKey.ReadOnly = true;
            this.txtDocumentKey.Size = new System.Drawing.Size(458, 25);
            this.txtDocumentKey.TabIndex = 1;
            this.txtDocumentKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFkey_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hash Value by Decryption :";
            // 
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::DocTransClient.Properties.Resources.blueBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 248);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumentKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFkey);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDownload);
            this.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDownload";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Download";
            this.Load += new System.EventHandler(this.FrmDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GTools.GButton btnDownload;
        private GTools.GButton btnCancel;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.TextBox txtFkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.TextBox txtDocumentKey;
        private System.Windows.Forms.Label label2;
    }
}