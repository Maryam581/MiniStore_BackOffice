using System;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
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
            pnlHeader = new Panel();
            flpRIGHT = new FlowLayoutPanel();
            pbUser = new PictureBox();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            pnlSidebar = new Panel();
            FlpNav = new FlowLayoutPanel();
            btndashboard = new Button();
            btnproducts = new Button();
            btnorders = new Button();
            btnreports = new Button();
            btnSync = new Button();
            btnlog = new Button();
            btnsetting = new Button();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            tslabelStatus = new ToolStripStatusLabel();
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            flpRIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            FlpNav.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRIGHT);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1341, 63);
            pnlHeader.TabIndex = 0;
            // 
            // flpRIGHT
            // 
            flpRIGHT.Controls.Add(pbUser);
            flpRIGHT.Controls.Add(lblUser);
            flpRIGHT.Dock = DockStyle.Right;
            flpRIGHT.Location = new Point(1214, 0);
            flpRIGHT.Margin = new Padding(3, 4, 3, 4);
            flpRIGHT.Name = "flpRIGHT";
            flpRIGHT.Size = new Size(127, 63);
            flpRIGHT.TabIndex = 1;
            // 
            // pbUser
            // 
            pbUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUser.Image = WindowsApp.Properties.Resources.user;
            pbUser.Location = new Point(3, 3);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(32, 32);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Right;
            lblUser.Location = new Point(41, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 38);
            lblUser.TabIndex = 1;
            lblUser.Text = "Admin";
            lblUser.Click += lblUser_Click;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(3, 4, 3, 4);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(140, 63);
            flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = WindowsApp.Properties.Resources.building_store__1_;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(32, 32);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(FlpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 63);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(216, 553);
            pnlSidebar.TabIndex = 1;
            // 
            // FlpNav
            // 
            FlpNav.Controls.Add(btndashboard);
            FlpNav.Controls.Add(btnproducts);
            FlpNav.Controls.Add(btnorders);
            FlpNav.Controls.Add(btnreports);
            FlpNav.Controls.Add(btnSync);
            FlpNav.Controls.Add(btnlog);
            FlpNav.Controls.Add(btnsetting);
            FlpNav.Dock = DockStyle.Left;
            FlpNav.FlowDirection = FlowDirection.TopDown;
            FlpNav.Location = new Point(0, 0);
            FlpNav.Margin = new Padding(3, 4, 3, 4);
            FlpNav.Name = "FlpNav";
            FlpNav.Size = new Size(219, 553);
            FlpNav.TabIndex = 1;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = SystemColors.Control;
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.ForeColor = SystemColors.ActiveCaptionText;
            btndashboard.Image = WindowsApp.Properties.Resources.dashboard;
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(3, 3);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(200, 40);
            btndashboard.TabIndex = 7;
            btndashboard.Tag = "center";
            btndashboard.Text = "Dashboard";
            btndashboard.TextAlign = ContentAlignment.MiddleLeft;
            btndashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnproducts
            // 
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Image = WindowsApp.Properties.Resources.shopping_cart;
            btnproducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnproducts.Location = new Point(3, 49);
            btnproducts.Name = "btnproducts";
            btnproducts.Padding = new Padding(10, 0, 0, 0);
            btnproducts.Size = new Size(200, 40);
            btnproducts.TabIndex = 1;
            btnproducts.Tag = "center";
            btnproducts.Text = "Products";
            btnproducts.TextAlign = ContentAlignment.MiddleLeft;
            btnproducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnproducts.UseVisualStyleBackColor = true;
            btnproducts.Click += btnproduct_Click;
            // 
            // btnorders
            // 
            btnorders.FlatAppearance.BorderSize = 0;
            btnorders.FlatStyle = FlatStyle.Flat;
            btnorders.Image = WindowsApp.Properties.Resources.truck_delivery;
            btnorders.ImageAlign = ContentAlignment.MiddleLeft;
            btnorders.Location = new Point(3, 95);
            btnorders.Name = "btnorders";
            btnorders.Padding = new Padding(10, 0, 0, 0);
            btnorders.Size = new Size(200, 40);
            btnorders.TabIndex = 2;
            btnorders.Tag = "center";
            btnorders.Text = "Orders";
            btnorders.TextAlign = ContentAlignment.MiddleLeft;
            btnorders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnorders.UseVisualStyleBackColor = true;
            // 
            // btnreports
            // 
            btnreports.FlatAppearance.BorderSize = 0;
            btnreports.FlatStyle = FlatStyle.Flat;
            btnreports.Image = WindowsApp.Properties.Resources.report_analytics;
            btnreports.ImageAlign = ContentAlignment.MiddleLeft;
            btnreports.Location = new Point(3, 141);
            btnreports.Name = "btnreports";
            btnreports.Padding = new Padding(10, 0, 0, 0);
            btnreports.Size = new Size(200, 40);
            btnreports.TabIndex = 3;
            btnreports.Tag = "center";
            btnreports.Text = "Reports";
            btnreports.TextAlign = ContentAlignment.MiddleLeft;
            btnreports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreports.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Image = WindowsApp.Properties.Resources.refresh;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(3, 187);
            btnSync.Name = "btnSync";
            btnSync.Padding = new Padding(10, 0, 0, 0);
            btnSync.Size = new Size(200, 40);
            btnSync.TabIndex = 4;
            btnSync.Tag = "center";
            btnSync.Text = "Sync";
            btnSync.TextAlign = ContentAlignment.MiddleLeft;
            btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSync.UseVisualStyleBackColor = true;
            // 
            // btnlog
            // 
            btnlog.FlatAppearance.BorderSize = 0;
            btnlog.FlatStyle = FlatStyle.Flat;
            btnlog.Image = WindowsApp.Properties.Resources.logs;
            btnlog.ImageAlign = ContentAlignment.MiddleLeft;
            btnlog.Location = new Point(3, 233);
            btnlog.Name = "btnlog";
            btnlog.Padding = new Padding(10, 0, 0, 0);
            btnlog.Size = new Size(200, 40);
            btnlog.TabIndex = 5;
            btnlog.Tag = "center";
            btnlog.Text = "logs";
            btnlog.TextAlign = ContentAlignment.MiddleLeft;
            btnlog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlog.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            btnsetting.FlatAppearance.BorderSize = 0;
            btnsetting.FlatStyle = FlatStyle.Flat;
            btnsetting.Image = WindowsApp.Properties.Resources.settings;
            btnsetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnsetting.Location = new Point(3, 279);
            btnsetting.Name = "btnsetting";
            btnsetting.Padding = new Padding(10, 0, 0, 0);
            btnsetting.Size = new Size(200, 40);
            btnsetting.TabIndex = 6;
            btnsetting.Tag = "center";
            btnsetting.Text = "Settings";
            btnsetting.TextAlign = ContentAlignment.MiddleLeft;
            btnsetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsetting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 792);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslabelStatus });
            statusStrip1.Location = new Point(0, 616);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1341, 28);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslabelStatus
            // 
            tslabelStatus.Name = "tslabelStatus";
            tslabelStatus.Size = new Size(60, 21);
            tslabelStatus.Text = "Ready";
            tslabelStatus.Click += tslabelStatus_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(216, 63);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1125, 553);
            pnlContent.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 644);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            Click += btndashboard_Click;
            pnlHeader.ResumeLayout(false);
            flpRIGHT.ResumeLayout(false);
            flpRIGHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            FlpNav.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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