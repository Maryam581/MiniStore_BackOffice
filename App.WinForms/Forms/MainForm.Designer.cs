using System;
using System.Windows.Forms;

namespace App.WinForms.Forms
{
    partial class Main
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpRIGHT = new System.Windows.Forms.FlowLayoutPanel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.FlpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.flpRIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.FlpNav.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.flpRIGHT);
            this.pnlHeader.Controls.Add(this.flpLeft);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1341, 63);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // flpRIGHT
            // 
            this.flpRIGHT.Controls.Add(this.pbUser);
            this.flpRIGHT.Controls.Add(this.lblUser);
            this.flpRIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpRIGHT.Location = new System.Drawing.Point(1214, 0);
            this.flpRIGHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpRIGHT.Name = "flpRIGHT";
            this.flpRIGHT.Size = new System.Drawing.Size(127, 63);
            this.flpRIGHT.TabIndex = 1;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.Image = global::App.WinForms.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(3, 3);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(32, 32);
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Location = new System.Drawing.Point(41, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 38);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // flpLeft
            // 
            this.flpLeft.Controls.Add(this.pbLogo);
            this.flpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLeft.Location = new System.Drawing.Point(0, 0);
            this.flpLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(140, 63);
            this.flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::App.WinForms.Properties.Resources.building_store__1_;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(32, 32);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.FlpNav);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 63);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(216, 553);
            this.pnlSidebar.TabIndex = 1;
            // 
            // FlpNav
            // 
            this.FlpNav.Controls.Add(this.btndashboard);
            this.FlpNav.Controls.Add(this.btnproducts);
            this.FlpNav.Controls.Add(this.btnorders);
            this.FlpNav.Controls.Add(this.btnreports);
            this.FlpNav.Controls.Add(this.btnSync);
            this.FlpNav.Controls.Add(this.btnlog);
            this.FlpNav.Controls.Add(this.btnsetting);
            this.FlpNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpNav.Location = new System.Drawing.Point(0, 0);
            this.FlpNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FlpNav.Name = "FlpNav";
            this.FlpNav.Size = new System.Drawing.Size(219, 553);
            this.FlpNav.TabIndex = 1;
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.SystemColors.Control;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndashboard.Image = global::App.WinForms.Properties.Resources.dashboard;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(3, 3);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(200, 40);
            this.btndashboard.TabIndex = 7;
            this.btndashboard.Tag = "center";
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Image = global::App.WinForms.Properties.Resources.shopping_cart;
            this.btnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.Location = new System.Drawing.Point(3, 49);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnproducts.Size = new System.Drawing.Size(200, 40);
            this.btnproducts.TabIndex = 1;
            this.btnproducts.Tag = "center";
            this.btnproducts.Text = "Products";
            this.btnproducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnorders
            // 
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Image = global::App.WinForms.Properties.Resources.truck_delivery;
            this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.Location = new System.Drawing.Point(3, 95);
            this.btnorders.Name = "btnorders";
            this.btnorders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnorders.Size = new System.Drawing.Size(200, 40);
            this.btnorders.TabIndex = 2;
            this.btnorders.Tag = "center";
            this.btnorders.Text = "Orders";
            this.btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = true;
            // 
            // btnreports
            // 
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.Image = global::App.WinForms.Properties.Resources.report_analytics;
            this.btnreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.Location = new System.Drawing.Point(3, 141);
            this.btnreports.Name = "btnreports";
            this.btnreports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnreports.Size = new System.Drawing.Size(200, 40);
            this.btnreports.TabIndex = 3;
            this.btnreports.Tag = "center";
            this.btnreports.Text = "Reports";
            this.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreports.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = global::App.WinForms.Properties.Resources.refresh;
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(3, 187);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSync.Size = new System.Drawing.Size(200, 40);
            this.btnSync.TabIndex = 4;
            this.btnSync.Tag = "center";
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnlog
            // 
            this.btnlog.FlatAppearance.BorderSize = 0;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.Image = global::App.WinForms.Properties.Resources.logs;
            this.btnlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlog.Location = new System.Drawing.Point(3, 233);
            this.btnlog.Name = "btnlog";
            this.btnlog.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnlog.Size = new System.Drawing.Size(200, 40);
            this.btnlog.TabIndex = 5;
            this.btnlog.Tag = "center";
            this.btnlog.Text = "logs";
            this.btnlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlog.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Image = global::App.WinForms.Properties.Resources.settings;
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(3, 279);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsetting.Size = new System.Drawing.Size(200, 40);
            this.btnsetting.TabIndex = 6;
            this.btnsetting.Tag = "center";
            this.btnsetting.Text = "Settings";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 792);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1341, 28);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslabelStatus
            // 
            this.tslabelStatus.Name = "tslabelStatus";
            this.tslabelStatus.Size = new System.Drawing.Size(60, 21);
            this.tslabelStatus.Text = "Ready";
            this.tslabelStatus.Click += new System.EventHandler(this.tslabelStatus_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(216, 63);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1125, 553);
            this.pnlContent.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 644);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.btndashboard_Click);
            this.pnlHeader.ResumeLayout(false);
            this.flpRIGHT.ResumeLayout(false);
            this.flpRIGHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.FlpNav.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tslabelStatus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel flpRIGHT;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel FlpNav;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslabelStatus;
        private System.Windows.Forms.Panel pnlContent;
        private PaintEventHandler pnlHeader_Paint;
    }
}