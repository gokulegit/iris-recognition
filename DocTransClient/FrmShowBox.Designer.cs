namespace DocTransClient
{
    partial class FrmShowBox
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhead = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new GTools.GButton();
            this.btnDownload = new GTools.GButton();
            this.ldr = new MRG.Controls.UI.LoadingCircle();
            this.btnDemo = new GTools.GButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(102, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 1);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(12, 8);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(84, 22);
            this.lblhead.TabIndex = 3;
            this.lblhead.Text = "Send a File";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg.ColumnHeadersHeight = 35;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dg.Enabled = false;
            this.dg.Location = new System.Drawing.Point(12, 59);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.RowTemplate.Height = 30;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(624, 350);
            this.dg.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ButtonStyle = GTools.GButton.ButtonStyles.Orange;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoverTextColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(12, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 3;
            this.btnRefresh.Size = new System.Drawing.Size(100, 29);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.ButtonStyle = GTools.GButton.ButtonStyles.Orange;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Enabled = false;
            this.btnDownload.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.HoverTextColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(118, 420);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Radius = 3;
            this.btnDownload.Size = new System.Drawing.Size(150, 29);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download File";
            this.btnDownload.Click += new System.EventHandler(this.Download_Click);
            // 
            // ldr
            // 
            this.ldr.Active = true;
            this.ldr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ldr.BackColor = System.Drawing.Color.White;
            this.ldr.Color = System.Drawing.Color.DarkRed;
            this.ldr.InnerCircleRadius = 5;
            this.ldr.Location = new System.Drawing.Point(307, 215);
            this.ldr.Name = "ldr";
            this.ldr.NumberSpoke = 12;
            this.ldr.OuterCircleRadius = 11;
            this.ldr.RotationSpeed = 70;
            this.ldr.Size = new System.Drawing.Size(35, 31);
            this.ldr.SpokeThickness = 2;
            this.ldr.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.ldr.TabIndex = 8;
            this.ldr.Text = "loadingCircle1";
            this.ldr.Visible = false;
            // 
            // btnDemo
            // 
            this.btnDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDemo.BackColor = System.Drawing.Color.Transparent;
            this.btnDemo.ButtonStyle = GTools.GButton.ButtonStyles.Red;
            this.btnDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemo.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.ForeColor = System.Drawing.Color.White;
            this.btnDemo.HoverTextColor = System.Drawing.Color.White;
            this.btnDemo.Location = new System.Drawing.Point(274, 420);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Radius = 3;
            this.btnDemo.Size = new System.Drawing.Size(174, 29);
            this.btnDemo.TabIndex = 2;
            this.btnDemo.Text = "Make a Demo Intrusion";
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // FrmShowBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(648, 461);
            this.Controls.Add(this.ldr);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhead);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmShowBox";
            this.Load += new System.EventHandler(this.FrmShowBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.DataGridView dg;
        private GTools.GButton btnRefresh;
        private GTools.GButton btnDownload;
        private MRG.Controls.UI.LoadingCircle ldr;
        private GTools.GButton btnDemo;
    }
}