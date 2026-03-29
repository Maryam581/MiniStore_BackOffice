using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        ProductFormModeEnum __mode;
        Product _product;
        IProductServices _service;




        public ProductForm(ProductFormModeEnum mode, Product? p ,  IProductServices services)
        {
            InitializeComponent();
            numericUpDownPrice.Maximum = Decimal.MaxValue;
            numericUpDownStock.Maximum = Int32.MaxValue;


            cmbCatagory.Items.Clear();

            cmbCatagory.DataSource = (Enum.GetValues(typeof(ProductCategoryEnum)));
            cmbCatagory.SelectedIndex = 0;

            comboBoxStatus.Items.Clear();

            comboBoxStatus.DataSource = (Enum.GetValues(typeof(ProductStatusEnum)));
            comboBoxStatus.SelectedIndex = 0;


            __mode = mode;
            _product = p;
            _service = services;


            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }


            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {

                tbName.Text = p.Name;
                tbID.Text = p.Id;
                cmbCatagory.SelectedItem = p.Category;
                numericUpDownPrice.Value = p.Price;
                comboBoxStatus.SelectedItem = p.Status;
                numericUpDownStock.Value = p.Stock;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (__mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = tbName.Text;
                newProduct.Category = (ProductCategoryEnum)cmbCatagory.SelectedItem;
                newProduct.Price = numericUpDownPrice.Value;
                newProduct.Stock = (int)numericUpDownStock.Value;
                newProduct.Status = (ProductStatusEnum)comboBoxStatus.SelectedItem;


                // _product = _service.Add(newProduct);
                //tbID.Text = _product.Id;
                Product temp = _service.Add(newProduct);
                tbID.Text = temp?.Id ?? "";


            }
            else if (__mode == ProductFormModeEnum.Edit)
            {
                _product.Name = tbName.Text;
                _product.Category = (ProductCategoryEnum)cmbCatagory.SelectedItem;
                _product.Price = numericUpDownPrice.Value;
                _product.Stock = (int)numericUpDownStock.Value;
                _product.Status = (ProductStatusEnum)comboBoxStatus.SelectedItem;


                bool isUpdated = _service.Update(_product);


            }
            this.Close();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
