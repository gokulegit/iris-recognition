namespace DocTransClient
{
    partial class FrmMainC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainC));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.tiInbox = new XPExplorerBar.TaskItem();
            this.tiSent = new XPExplorerBar.TaskItem();
            this.tiSend = new XPExplorerBar.TaskItem();
            this.expando2 = new XPExplorerBar.Expando();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblusr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).BeginInit();
            this.taskPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).BeginInit();
            this.expando1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando2)).BeginInit();
            this.expando2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(812, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 441);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 20);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 20);
            this.panel1.TabIndex = 7;
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskPane1.Expandos.AddRange(new XPExplorerBar.Expando[] {
            this.expando1,
            this.expando2});
            this.taskPane1.Location = new System.Drawing.Point(0, 0);
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size(200, 481);
            this.taskPane1.TabIndex = 6;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando1.Animate = true;
            this.expando1.AutoLayout = true;
            this.expando1.CustomHeaderSettings.TitleFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expando1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.tiInbox,
            this.tiSent,
            this.tiSend});
            this.expando1.Location = new System.Drawing.Point(12, 12);
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size(176, 100);
            this.expando1.TabIndex = 0;
            this.expando1.Text = "Administration";
            // 
            // tiInbox
            // 
            this.tiInbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tiInbox.BackColor = System.Drawing.Color.Transparent;
            this.tiInbox.Image = null;
            this.tiInbox.Location = new System.Drawing.Point(12, 33);
            this.tiInbox.Name = "tiInbox";
            this.tiInbox.Size = new System.Drawing.Size(150, 16);
            this.tiInbox.TabIndex = 0;
            this.tiInbox.Text = "File Inbox";
            this.tiInbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tiInbox.UseVisualStyleBackColor = false;
            this.tiInbox.Click += new System.EventHandler(this.tiInbox_Click);
            // 
            // tiSent
            // 
            this.tiSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tiSent.BackColor = System.Drawing.Color.Transparent;
            this.tiSent.Image = null;
            this.tiSent.Location = new System.Drawing.Point(12, 53);
            this.tiSent.Name = "tiSent";
            this.tiSent.Size = new System.Drawing.Size(150, 16);
            this.tiSent.TabIndex = 1;
            this.tiSent.Text = "Sent";
            this.tiSent.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tiSent.UseVisualStyleBackColor = false;
            this.tiSent.Click += new System.EventHandler(this.tiSent_Click);
            // 
            // tiSend
            // 
            this.tiSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tiSend.BackColor = System.Drawing.Color.Transparent;
            this.tiSend.Image = null;
            this.tiSend.Location = new System.Drawing.Point(12, 73);
            this.tiSend.Name = "tiSend";
            this.tiSend.Size = new System.Drawing.Size(150, 16);
            this.tiSend.TabIndex = 2;
            this.tiSend.Text = "Send a File";
            this.tiSend.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tiSend.UseVisualStyleBackColor = false;
            this.tiSend.Click += new System.EventHandler(this.tiSend_Click);
            // 
            // expando2
            // 
            this.expando2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando2.Animate = true;
            this.expando2.AutoLayout = true;
            this.expando2.CustomHeaderSettings.TitleFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expando2.ExpandedHeight = 124;
            this.expando2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando2.Items.AddRange(new System.Windows.Forms.Control[] {
            this.lblUser,
            this.lblusr,
            this.label1,
            this.lblTime});
            this.expando2.Location = new System.Drawing.Point(12, 124);
            this.expando2.Name = "expando2";
            this.expando2.Size = new System.Drawing.Size(176, 124);
            this.expando2.TabIndex = 1;
            this.expando2.Text = "User Information";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Current User :";
            // 
            // lblusr
            // 
            this.lblusr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusr.Location = new System.Drawing.Point(12, 54);
            this.lblusr.Name = "lblusr";
            this.lblusr.Size = new System.Drawing.Size(160, 19);
            this.lblusr.TabIndex = 0;
            this.lblusr.Text = "Current User :";
            this.lblusr.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time :";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 94);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(160, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Current User :";
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMainC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taskPane1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMainC";
            this.Text = "Document Transfer - Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainC_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainC_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).EndInit();
            this.taskPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).EndInit();
            this.expando1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando2)).EndInit();
            this.expando2.ResumeLayout(false);
            this.expando2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private XPExplorerBar.TaskItem tiInbox;
        private XPExplorerBar.TaskItem tiSent;
        private XPExplorerBar.TaskItem tiSend;
        private XPExplorerBar.Expando expando2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblusr;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;

    }
}