namespace DocTransAdmin
{
    partial class FrmMainA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainA));
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.tiRegister = new XPExplorerBar.TaskItem();
            this.tiView = new XPExplorerBar.TaskItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).BeginInit();
            this.taskPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).BeginInit();
            this.expando1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskPane1.Expandos.AddRange(new XPExplorerBar.Expando[] {
            this.expando1});
            this.taskPane1.Location = new System.Drawing.Point(0, 0);
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size(200, 481);
            this.taskPane1.TabIndex = 1;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando1.Animate = true;
            this.expando1.AutoLayout = true;
            this.expando1.CustomHeaderSettings.TitleFont = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expando1.ExpandedHeight = 80;
            this.expando1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.tiRegister,
            this.tiView});
            this.expando1.Location = new System.Drawing.Point(12, 12);
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size(176, 80);
            this.expando1.TabIndex = 0;
            this.expando1.Text = "Administration";
            // 
            // tiRegister
            // 
            this.tiRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tiRegister.BackColor = System.Drawing.Color.Transparent;
            this.tiRegister.Image = null;
            this.tiRegister.Location = new System.Drawing.Point(12, 33);
            this.tiRegister.Name = "tiRegister";
            this.tiRegister.Size = new System.Drawing.Size(150, 16);
            this.tiRegister.TabIndex = 0;
            this.tiRegister.Text = "Register a New Client";
            this.tiRegister.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tiRegister.UseVisualStyleBackColor = false;
            this.tiRegister.Click += new System.EventHandler(this.tiRegister_Click);
            // 
            // tiView
            // 
            this.tiView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tiView.BackColor = System.Drawing.Color.Transparent;
            this.tiView.Image = null;
            this.tiView.Location = new System.Drawing.Point(12, 53);
            this.tiView.Name = "tiView";
            this.tiView.Size = new System.Drawing.Size(150, 16);
            this.tiView.TabIndex = 1;
            this.tiView.Text = "View Clients";
            this.tiView.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tiView.UseVisualStyleBackColor = false;
            this.tiView.Click += new System.EventHandler(this.tiView_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 20);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 20);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(763, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 441);
            this.panel3.TabIndex = 5;
            // 
            // FrmMainA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taskPane1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMainA";
            this.Text = "Document Transfer - Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainA_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainA_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).EndInit();
            this.taskPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).EndInit();
            this.expando1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private XPExplorerBar.TaskItem tiRegister;
        private XPExplorerBar.TaskItem tiView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}