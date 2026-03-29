namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            tlpProduct = new TableLayoutPanel();
            lPrice = new Label();
            lStock = new Label();
            lStatus = new Label();
            lId = new Label();
            lCatagory = new Label();
            lName = new Label();
            tbName = new TextBox();
            cmbCatagory = new ComboBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownStock = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            tbID = new TextBox();
            fllpProduct = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tlpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            fllpProduct.SuspendLayout();
            SuspendLayout();
            // 
            // tlpProduct
            // 
            tlpProduct.ColumnCount = 2;
            tlpProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tlpProduct.Controls.Add(lPrice, 0, 2);
            tlpProduct.Controls.Add(lStock, 0, 3);
            tlpProduct.Controls.Add(lStatus, 0, 4);
            tlpProduct.Controls.Add(lId, 0, 5);
            tlpProduct.Controls.Add(lCatagory, 0, 1);
            tlpProduct.Controls.Add(lName, 0, 0);
            tlpProduct.Controls.Add(tbName, 1, 0);
            tlpProduct.Controls.Add(cmbCatagory, 1, 1);
            tlpProduct.Controls.Add(numericUpDownPrice, 1, 2);
            tlpProduct.Controls.Add(numericUpDownStock, 1, 3);
            tlpProduct.Controls.Add(comboBoxStatus, 1, 4);
            tlpProduct.Controls.Add(tbID, 1, 5);
            tlpProduct.Dock = DockStyle.Top;
            tlpProduct.Location = new Point(0, 0);
            tlpProduct.Name = "tlpProduct";
            tlpProduct.RowCount = 6;
            tlpProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProduct.Size = new Size(932, 310);
            tlpProduct.TabIndex = 0;
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.FlatStyle = FlatStyle.Flat;
            lPrice.Location = new Point(3, 100);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(49, 25);
            lPrice.TabIndex = 8;
            lPrice.Text = "Price";
            lPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lStock
            // 
            lStock.AutoSize = true;
            lStock.FlatStyle = FlatStyle.Flat;
            lStock.Location = new Point(3, 150);
            lStock.Name = "lStock";
            lStock.Size = new Size(55, 25);
            lStock.TabIndex = 9;
            lStock.Text = "Stock";
            lStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.FlatStyle = FlatStyle.Flat;
            lStatus.Location = new Point(3, 200);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(60, 25);
            lStatus.TabIndex = 10;
            lStatus.Text = "Status";
            lStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(3, 250);
            lId.Name = "lId";
            lId.Size = new Size(30, 25);
            lId.TabIndex = 11;
            lId.Text = "ID";
            lId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lCatagory
            // 
            lCatagory.AutoSize = true;
            lCatagory.FlatStyle = FlatStyle.Flat;
            lCatagory.Location = new Point(3, 50);
            lCatagory.Name = "lCatagory";
            lCatagory.Size = new Size(84, 25);
            lCatagory.TabIndex = 7;
            lCatagory.Text = "Category";
            lCatagory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.FlatStyle = FlatStyle.Flat;
            lName.Location = new Point(3, 0);
            lName.Name = "lName";
            lName.Size = new Size(59, 25);
            lName.TabIndex = 6;
            lName.Text = "Name";
            lName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(236, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(693, 31);
            tbName.TabIndex = 0;
            // 
            // cmbCatagory
            // 
            cmbCatagory.Dock = DockStyle.Fill;
            cmbCatagory.FormattingEnabled = true;
            cmbCatagory.Location = new Point(236, 53);
            cmbCatagory.Name = "cmbCatagory";
            cmbCatagory.Size = new Size(693, 33);
            cmbCatagory.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Dock = DockStyle.Fill;
            numericUpDownPrice.Location = new Point(236, 103);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(693, 31);
            numericUpDownPrice.TabIndex = 2;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Dock = DockStyle.Fill;
            numericUpDownStock.Location = new Point(236, 153);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(693, 31);
            numericUpDownStock.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Dock = DockStyle.Fill;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(236, 203);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(693, 33);
            comboBoxStatus.TabIndex = 4;
            // 
            // tbID
            // 
            tbID.Dock = DockStyle.Fill;
            tbID.Location = new Point(236, 253);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(693, 31);
            tbID.TabIndex = 5;
            // 
            // fllpProduct
            // 
            fllpProduct.Controls.Add(btnCancel);
            fllpProduct.Controls.Add(btnSave);
            fllpProduct.Dock = DockStyle.Bottom;
            fllpProduct.Location = new Point(0, 346);
            fllpProduct.Name = "fllpProduct";
            fllpProduct.Size = new Size(932, 104);
            fllpProduct.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(9, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(112, 41);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(139, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(112, 41);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(fllpProduct);
            Controls.Add(tlpProduct);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            FormClosing += ProductForm_FormClosing;
            tlpProduct.ResumeLayout(false);
            tlpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            fllpProduct.ResumeLayout(false);
            fllpProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpProduct;
        private FlowLayoutPanel fllpProduct;
        private Label lName;
        private Label lPrice;
        private Label lStock;
        private Label lStatus;
        private Label lId;
        private Label lCatagory;
        private TextBox tbName;
        private ComboBox cmbCatagory;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownStock;
        private ComboBox comboBoxStatus;
        private TextBox tbID;
        private Button btnCancel;
        private Button btnSave;
    }
}