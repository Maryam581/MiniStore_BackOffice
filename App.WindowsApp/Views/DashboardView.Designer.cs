
namespace App.WindowsApp.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.flpkpi = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlSales = new System.Windows.Forms.Panel();
            this.lblsalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblrevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowstock = new System.Windows.Forms.Panel();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlReView = new System.Windows.Forms.Panel();
            this.lvRecentOrders = new System.Windows.Forms.ListView();
            this.colOrderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomerid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.flpkpi.SuspendLayout();
            this.PnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowstock.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlReView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.BackColor = System.Drawing.Color.White;
            this.tblDashboard.ColumnCount = 2;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tblDashboard.Controls.Add(this.listView2, 1, 0);
            this.tblDashboard.Controls.Add(this.flpkpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowstock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlReView, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(855, 573);
            this.tblDashboard.TabIndex = 0;
            this.tblDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.tblDashboard_Paint);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(849, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(3, 97);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // flpkpi
            // 
            this.flpkpi.Controls.Add(this.PnlSales);
            this.flpkpi.Controls.Add(this.pnlOrders);
            this.flpkpi.Controls.Add(this.pnlRevenue);
            this.flpkpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpkpi.Location = new System.Drawing.Point(3, 3);
            this.flpkpi.Name = "flpkpi";
            this.flpkpi.Size = new System.Drawing.Size(840, 114);
            this.flpkpi.TabIndex = 0;
            this.flpkpi.Paint += new System.Windows.Forms.PaintEventHandler(this.flpkpi_Paint);
            // 
            // PnlSales
            // 
            this.PnlSales.BackColor = System.Drawing.Color.White;
            this.PnlSales.Controls.Add(this.lblsalesV);
            this.PnlSales.Controls.Add(this.lblSalesT);
            this.PnlSales.Location = new System.Drawing.Point(3, 3);
            this.PnlSales.Name = "PnlSales";
            this.PnlSales.Size = new System.Drawing.Size(200, 100);
            this.PnlSales.TabIndex = 0;
            // 
            // lblsalesV
            // 
            this.lblsalesV.AutoSize = true;
            this.lblsalesV.Location = new System.Drawing.Point(111, 30);
            this.lblsalesV.Name = "lblsalesV";
            this.lblsalesV.Size = new System.Drawing.Size(36, 20);
            this.lblsalesV.TabIndex = 1;
            this.lblsalesV.Text = "163";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(18, 31);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(49, 20);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderV);
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Location = new System.Drawing.Point(209, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(200, 100);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Location = new System.Drawing.Point(127, 31);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(27, 20);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "33";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Location = new System.Drawing.Point(24, 31);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(57, 20);
            this.lblOrderT.TabIndex = 0;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblrevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRevenue.Location = new System.Drawing.Point(415, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(200, 100);
            this.pnlRevenue.TabIndex = 2;
            this.pnlRevenue.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRevenue_Paint);
            // 
            // lblrevenueV
            // 
            this.lblrevenueV.AutoSize = true;
            this.lblrevenueV.Location = new System.Drawing.Point(99, 29);
            this.lblrevenueV.Name = "lblrevenueV";
            this.lblrevenueV.Size = new System.Drawing.Size(90, 20);
            this.lblrevenueV.TabIndex = 1;
            this.lblrevenueV.Text = "37,356PKR";
            this.lblrevenueV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(20, 31);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(73, 20);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowstock
            // 
            this.pnlLowstock.Controls.Add(this.pnlStock);
            this.pnlLowstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowstock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowstock.Name = "pnlLowstock";
            this.pnlLowstock.Size = new System.Drawing.Size(840, 220);
            this.pnlLowstock.TabIndex = 1;
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.lvLowStock);
            this.pnlStock.Controls.Add(this.lblLowStock);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(0, 0);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(840, 220);
            this.pnlStock.TabIndex = 0;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        this.colProduct,
        this.colStock});
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(0, 33);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(836, 97);
            this.lvLowStock.TabIndex = 1;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.lvLowStock_SelectedIndexChanged);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            this.lblLowStock.BackColor = System.Drawing.Color.DarkGray;
            this.lblLowStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowStock.Location = new System.Drawing.Point(0, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(840, 33);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "LowStock";
            // 
            // pnlReView
            // 
            this.pnlReView.Controls.Add(this.lvRecentOrders);
            this.pnlReView.Controls.Add(this.lblRecentOrders);
            this.pnlReView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReView.Location = new System.Drawing.Point(3, 349);
            this.pnlReView.Name = "pnlReView";
            this.pnlReView.Size = new System.Drawing.Size(840, 221);
            this.pnlReView.TabIndex = 4;
            // 
            // lvRecentOrders
            // 
            this.lvRecentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        this.colOrderid,
        this.colCustomerid,
        this.colStatus,
        this.colTotal});
            this.lvRecentOrders.HideSelection = false;
            this.lvRecentOrders.Location = new System.Drawing.Point(-3, 46);
            this.lvRecentOrders.Name = "lvRecentOrders";
            this.lvRecentOrders.Size = new System.Drawing.Size(842, 97);
            this.lvRecentOrders.TabIndex = 2;
            this.lvRecentOrders.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrders.View = System.Windows.Forms.View.Details;
            // 
            // colOrderid
            // 
            this.colOrderid.Text = "Order";
            // 
            // colCustomerid
            // 
            this.colCustomerid.Text = "Customer";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.BackColor = System.Drawing.Color.DarkGray;
            this.lblRecentOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentOrders.Location = new System.Drawing.Point(0, 0);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(840, 43);
            this.lblRecentOrders.TabIndex = 1;
            this.lblRecentOrders.Text = "RecentOrders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(855, 573);
            this.tblDashboard.ResumeLayout(false);
            this.flpkpi.ResumeLayout(false);
            this.PnlSales.ResumeLayout(false);
            this.PnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowstock.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            this.pnlReView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpkpi;
        private System.Windows.Forms.Panel PnlSales;
        private System.Windows.Forms.Label lblsalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblrevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowstock;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Panel pnlReView;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.ColumnHeader colOrderid;
        private System.Windows.Forms.ColumnHeader colCustomerid;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.Label lblRecentOrders;
    }
}


