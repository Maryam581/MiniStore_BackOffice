namespace App.WindowsApp.Views
{ 
    partial class ProductsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            tblproduct = new TableLayoutPanel();
            pnlstrip = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsvView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlfilters = new Panel();
            tblfilters = new TableLayoutPanel();
            lblSearch = new Label();
            lblcatogries = new Label();
            lblstockstatus = new Label();
            cmbSearch = new TextBox();
            cmnCatagorie = new ComboBox();
            cmbstockstatus = new ComboBox();
            pnlGrid = new Panel();
            dvgproducts = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            COLName = new DataGridViewTextBoxColumn();
            COLCatogries = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            tblproduct.SuspendLayout();
            pnlstrip.SuspendLayout();
            pnlfilters.SuspendLayout();
            tblfilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgproducts).BeginInit();
            SuspendLayout();
            // 
            // tblproduct
            // 
            tblproduct.BackColor = Color.White;
            tblproduct.ColumnCount = 1;
            tblproduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblproduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblproduct.Controls.Add(pnlstrip, 0, 0);
            tblproduct.Controls.Add(pnlfilters, 0, 1);
            tblproduct.Controls.Add(pnlGrid, 0, 2);
            tblproduct.Dock = DockStyle.Fill;
            tblproduct.Location = new Point(0, 0);
            tblproduct.Margin = new Padding(3, 4, 3, 4);
            tblproduct.Name = "tblproduct";
            tblproduct.Padding = new Padding(18, 20, 18, 20);
            tblproduct.RowCount = 3;
            tblproduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblproduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tblproduct.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblproduct.Size = new Size(1369, 764);
            tblproduct.TabIndex = 0;
            // 
            // pnlstrip
            // 
            pnlstrip.BackColor = Color.White;
            pnlstrip.Dock = DockStyle.Fill;
            pnlstrip.GripStyle = ToolStripGripStyle.Hidden;
            pnlstrip.ImageScalingSize = new Size(24, 24);
            pnlstrip.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsvView, tsbDelete, toolStripSeparator1, tsbRefresh });
            pnlstrip.Location = new Point(21, 24);
            pnlstrip.Margin = new Padding(3, 4, 3, 4);
            pnlstrip.Name = "pnlstrip";
            pnlstrip.Size = new Size(1327, 62);
            pnlstrip.TabIndex = 0;
            pnlstrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(74, 57);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(70, 57);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsvView
            // 
            tsvView.Image = (Image)resources.GetObject("tsvView.Image");
            tsvView.ImageTransparentColor = Color.Magenta;
            tsvView.Name = "tsvView";
            tsvView.Size = new Size(77, 57);
            tsvView.Text = "View";
            tsvView.Click += tsvView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(90, 57);
            tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(98, 57);
            tsbRefresh.Text = "Refresh";
            // 
            // pnlfilters
            // 
            pnlfilters.Controls.Add(tblfilters);
            pnlfilters.Dock = DockStyle.Fill;
            pnlfilters.Location = new Point(21, 94);
            pnlfilters.Margin = new Padding(3, 4, 3, 4);
            pnlfilters.Name = "pnlfilters";
            pnlfilters.Padding = new Padding(13, 12, 13, 12);
            pnlfilters.Size = new Size(1327, 117);
            pnlfilters.TabIndex = 1;
            // 
            // tblfilters
            // 
            tblfilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblfilters.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblfilters.ColumnCount = 3;
            tblfilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.10193F));
            tblfilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.83691F));
            tblfilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.06116F));
            tblfilters.Controls.Add(lblSearch, 0, 0);
            tblfilters.Controls.Add(lblcatogries, 1, 0);
            tblfilters.Controls.Add(lblstockstatus, 2, 0);
            tblfilters.Controls.Add(cmbSearch, 0, 1);
            tblfilters.Controls.Add(cmnCatagorie, 1, 1);
            tblfilters.Controls.Add(cmbstockstatus, 2, 1);
            tblfilters.Dock = DockStyle.Fill;
            tblfilters.Location = new Point(13, 12);
            tblfilters.Margin = new Padding(3, 4, 3, 4);
            tblfilters.Name = "tblfilters";
            tblfilters.RowCount = 2;
            tblfilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblfilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblfilters.Size = new Size(1301, 93);
            tblfilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(4, 1);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(578, 45);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblcatogries
            // 
            lblcatogries.AutoSize = true;
            lblcatogries.Dock = DockStyle.Fill;
            lblcatogries.Location = new Point(589, 1);
            lblcatogries.Name = "lblcatogries";
            lblcatogries.Size = new Size(355, 45);
            lblcatogries.TabIndex = 1;
            lblcatogries.Text = "Catogories";
            // 
            // lblstockstatus
            // 
            lblstockstatus.AutoSize = true;
            lblstockstatus.Dock = DockStyle.Fill;
            lblstockstatus.Location = new Point(951, 1);
            lblstockstatus.Name = "lblstockstatus";
            lblstockstatus.Size = new Size(346, 45);
            lblstockstatus.TabIndex = 2;
            lblstockstatus.Text = "StockStatus";
            // 
            // cmbSearch
            // 
            cmbSearch.Dock = DockStyle.Fill;
            cmbSearch.Location = new Point(4, 51);
            cmbSearch.Margin = new Padding(3, 4, 3, 4);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(578, 31);
            cmbSearch.TabIndex = 3;
            cmbSearch.TextChanged += cmbSearch_TextChanged;
            // 
            // cmnCatagorie
            // 
            cmnCatagorie.Dock = DockStyle.Fill;
            cmnCatagorie.FormattingEnabled = true;
            cmnCatagorie.Location = new Point(589, 51);
            cmnCatagorie.Margin = new Padding(3, 4, 3, 4);
            cmnCatagorie.Name = "cmnCatagorie";
            cmnCatagorie.Size = new Size(355, 33);
            cmnCatagorie.TabIndex = 4;
            cmnCatagorie.SelectedIndexChanged += cmnCatagorie_SelectedIndexChanged;
            // 
            // cmbstockstatus
            // 
            cmbstockstatus.Dock = DockStyle.Fill;
            cmbstockstatus.FormattingEnabled = true;
            cmbstockstatus.Location = new Point(951, 51);
            cmbstockstatus.Margin = new Padding(3, 4, 3, 4);
            cmbstockstatus.Name = "cmbstockstatus";
            cmbstockstatus.Size = new Size(346, 33);
            cmbstockstatus.TabIndex = 5;
            cmbstockstatus.SelectedIndexChanged += cmbstockstatus_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dvgproducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(21, 219);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(13, 15, 13, 15);
            pnlGrid.Size = new Size(1327, 521);
            pnlGrid.TabIndex = 2;
            // 
            // dvgproducts
            // 
            dvgproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgproducts.BackgroundColor = Color.White;
            dvgproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgproducts.Columns.AddRange(new DataGridViewColumn[] { colid, COLName, COLCatogries, ColPrice, ColStock, ColStatus });
            dvgproducts.Dock = DockStyle.Fill;
            dvgproducts.Location = new Point(13, 15);
            dvgproducts.Margin = new Padding(3, 4, 3, 4);
            dvgproducts.MultiSelect = false;
            dvgproducts.Name = "dvgproducts";
            dvgproducts.ReadOnly = true;
            dvgproducts.RowHeadersVisible = false;
            dvgproducts.RowHeadersWidth = 62;
            dvgproducts.RowTemplate.Height = 28;
            dvgproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgproducts.Size = new Size(1301, 491);
            dvgproducts.TabIndex = 0;
            // 
            // colid
            // 
            colid.DataPropertyName = "Id";
            colid.HeaderText = "ID";
            colid.MinimumWidth = 8;
            colid.Name = "colid";
            colid.ReadOnly = true;
            // 
            // COLName
            // 
            COLName.DataPropertyName = "Name";
            COLName.HeaderText = "NAME";
            COLName.MinimumWidth = 8;
            COLName.Name = "COLName";
            COLName.ReadOnly = true;
            // 
            // COLCatogries
            // 
            COLCatogries.DataPropertyName = "Catogries";
            COLCatogries.HeaderText = "Catogries";
            COLCatogries.MinimumWidth = 8;
            COLCatogries.Name = "COLCatogries";
            COLCatogries.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "Price";
            ColPrice.HeaderText = "Price";
            ColPrice.MinimumWidth = 8;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.DataPropertyName = "Stock";
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 8;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "Status";
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 8;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblproduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsView";
            Size = new Size(1369, 764);
            Leave += ProductsView_Load;
            tblproduct.ResumeLayout(false);
            tblproduct.PerformLayout();
            pnlstrip.ResumeLayout(false);
            pnlstrip.PerformLayout();
            pnlfilters.ResumeLayout(false);
            tblfilters.ResumeLayout(false);
            tblfilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgproducts).EndInit();
            ResumeLayout(false);

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
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn COLName;
        private DataGridViewTextBoxColumn COLCatogries;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}
