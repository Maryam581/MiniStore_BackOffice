namespace App.WinForms.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.tblproduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnlstrip = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsvView = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlfilters = new System.Windows.Forms.Panel();
            this.tblfilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblcatogries = new System.Windows.Forms.Label();
            this.lblstockstatus = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.TextBox();
            this.cmnCatagorie = new System.Windows.Forms.ComboBox();
            this.cmbstockstatus = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dvgproducts = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLCatogries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblproduct.SuspendLayout();
            this.pnlstrip.SuspendLayout();
            this.pnlfilters.SuspendLayout();
            this.tblfilters.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblproduct
            // 
            this.tblproduct.BackColor = System.Drawing.Color.White;
            this.tblproduct.ColumnCount = 1;
            this.tblproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblproduct.Controls.Add(this.pnlstrip, 0, 0);
            this.tblproduct.Controls.Add(this.pnlfilters, 0, 1);
            this.tblproduct.Controls.Add(this.pnlGrid, 0, 2);
            this.tblproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblproduct.Location = new System.Drawing.Point(0, 0);
            this.tblproduct.Name = "tblproduct";
            this.tblproduct.Padding = new System.Windows.Forms.Padding(16);
            this.tblproduct.RowCount = 3;
            this.tblproduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblproduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblproduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproduct.Size = new System.Drawing.Size(1232, 611);
            this.tblproduct.TabIndex = 0;
            // 
            // pnlstrip
            // 
            this.pnlstrip.BackColor = System.Drawing.Color.White;
            this.pnlstrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pnlstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pnlstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsvView,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbRefresh});
            this.pnlstrip.Location = new System.Drawing.Point(19, 19);
            this.pnlstrip.Margin = new System.Windows.Forms.Padding(3);
            this.pnlstrip.Name = "pnlstrip";
            this.pnlstrip.Size = new System.Drawing.Size(1194, 50);
            this.pnlstrip.TabIndex = 0;
            this.pnlstrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(74, 45);
            this.tsbAdd.Text = "Add";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(70, 45);
            this.tsbEdit.Text = "Edit";
            // 
            // tsvView
            // 
            this.tsvView.Image = ((System.Drawing.Image)(resources.GetObject("tsvView.Image")));
            this.tsvView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsvView.Name = "tsvView";
            this.tsvView.Size = new System.Drawing.Size(77, 45);
            this.tsvView.Text = "View";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(90, 45);
            this.tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(98, 45);
            this.tsbRefresh.Text = "Refresh";
            // 
            // pnlfilters
            // 
            this.pnlfilters.Controls.Add(this.tblfilters);
            this.pnlfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfilters.Location = new System.Drawing.Point(19, 75);
            this.pnlfilters.Name = "pnlfilters";
            this.pnlfilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlfilters.Size = new System.Drawing.Size(1194, 94);
            this.pnlfilters.TabIndex = 1;
            // 
            // tblfilters
            // 
            this.tblfilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblfilters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblfilters.ColumnCount = 3;
            this.tblfilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.10193F));
            this.tblfilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83691F));
            this.tblfilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.06116F));
            this.tblfilters.Controls.Add(this.lblSearch, 0, 0);
            this.tblfilters.Controls.Add(this.lblcatogries, 1, 0);
            this.tblfilters.Controls.Add(this.lblstockstatus, 2, 0);
            this.tblfilters.Controls.Add(this.cmbSearch, 0, 1);
            this.tblfilters.Controls.Add(this.cmnCatagorie, 1, 1);
            this.tblfilters.Controls.Add(this.cmbstockstatus, 2, 1);
            this.tblfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblfilters.Location = new System.Drawing.Point(12, 10);
            this.tblfilters.Name = "tblfilters";
            this.tblfilters.RowCount = 2;
            this.tblfilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblfilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblfilters.Size = new System.Drawing.Size(1170, 74);
            this.tblfilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(4, 1);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(519, 35);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblcatogries
            // 
            this.lblcatogries.AutoSize = true;
            this.lblcatogries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcatogries.Location = new System.Drawing.Point(530, 1);
            this.lblcatogries.Name = "lblcatogries";
            this.lblcatogries.Size = new System.Drawing.Size(318, 35);
            this.lblcatogries.TabIndex = 1;
            this.lblcatogries.Text = "Catogories";
            // 
            // lblstockstatus
            // 
            this.lblstockstatus.AutoSize = true;
            this.lblstockstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblstockstatus.Location = new System.Drawing.Point(855, 1);
            this.lblstockstatus.Name = "lblstockstatus";
            this.lblstockstatus.Size = new System.Drawing.Size(311, 35);
            this.lblstockstatus.TabIndex = 2;
            this.lblstockstatus.Text = "StockStatus";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearch.Location = new System.Drawing.Point(4, 40);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(519, 26);
            this.cmbSearch.TabIndex = 3;
            // 
            // cmnCatagorie
            // 
            this.cmnCatagorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmnCatagorie.FormattingEnabled = true;
            this.cmnCatagorie.Location = new System.Drawing.Point(530, 40);
            this.cmnCatagorie.Name = "cmnCatagorie";
            this.cmnCatagorie.Size = new System.Drawing.Size(318, 28);
            this.cmnCatagorie.TabIndex = 4;
            // 
            // cmbstockstatus
            // 
            this.cmbstockstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbstockstatus.FormattingEnabled = true;
            this.cmbstockstatus.Location = new System.Drawing.Point(855, 40);
            this.cmbstockstatus.Name = "cmbstockstatus";
            this.cmbstockstatus.Size = new System.Drawing.Size(311, 28);
            this.cmbstockstatus.TabIndex = 5;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dvgproducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(19, 175);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(1194, 417);
            this.pnlGrid.TabIndex = 2;
            // 
            // dvgproducts
            // 
            this.dvgproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgproducts.BackgroundColor = System.Drawing.Color.White;
            this.dvgproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.COLName,
            this.COLCatogries,
            this.ColPrice,
            this.ColStock,
            this.ColStatus});
            this.dvgproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgproducts.Location = new System.Drawing.Point(12, 12);
            this.dvgproducts.MultiSelect = false;
            this.dvgproducts.Name = "dvgproducts";
            this.dvgproducts.ReadOnly = true;
            this.dvgproducts.RowHeadersVisible = false;
            this.dvgproducts.RowHeadersWidth = 62;
            this.dvgproducts.RowTemplate.Height = 28;
            this.dvgproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgproducts.Size = new System.Drawing.Size(1170, 393);
            this.dvgproducts.TabIndex = 0;
            // 
            // colid
            // 
            this.colid.HeaderText = "ID";
            this.colid.MinimumWidth = 8;
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            // 
            // COLName
            // 
            this.COLName.HeaderText = "NAME";
            this.COLName.MinimumWidth = 8;
            this.COLName.Name = "COLName";
            this.COLName.ReadOnly = true;
            // 
            // COLCatogries
            // 
            this.COLCatogries.HeaderText = "Catogries";
            this.COLCatogries.MinimumWidth = 8;
            this.COLCatogries.Name = "COLCatogries";
            this.COLCatogries.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 8;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 8;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Sratus";
            this.ColStatus.MinimumWidth = 8;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblproduct);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(1232, 611);
            this.tblproduct.ResumeLayout(false);
            this.tblproduct.PerformLayout();
            this.pnlstrip.ResumeLayout(false);
            this.pnlstrip.PerformLayout();
            this.pnlfilters.ResumeLayout(false);
            this.tblfilters.ResumeLayout(false);
            this.tblfilters.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblproduct;
        private System.Windows.Forms.ToolStrip pnlstrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsvView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlfilters;
        private System.Windows.Forms.TableLayoutPanel tblfilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblcatogries;
        private System.Windows.Forms.Label lblstockstatus;
        private System.Windows.Forms.TextBox cmbSearch;
        private System.Windows.Forms.ComboBox cmnCatagorie;
        private System.Windows.Forms.ComboBox cmbstockstatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dvgproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLCatogries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}
