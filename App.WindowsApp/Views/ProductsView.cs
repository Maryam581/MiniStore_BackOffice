using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Core.Models;

using App.Core.Contracts;
using App.Core.Utilities;
using App.WindowsApp.Forms;


namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductServices _service;
        BindingSource _dgvbindingSource = new BindingSource();


        public ProductsView(IProductServices _ser)
        {

            _service = _ser;
            InitializeComponent();
            dvgproducts.DataSource = _dgvbindingSource;
        }


        

        private void ProductsView_Load(object sender, EventArgs e)
        {



            cmnCatagorie.Items.Clear();
            cmnCatagorie.Items.Add("--ALL--");
            cmnCatagorie.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmnCatagorie.SelectedIndex = 0;

            cmbstockstatus.Items.Clear();
            cmbstockstatus.Items.Add("--ALL--");
            cmbstockstatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbstockstatus.SelectedIndex = 0;

            if (_service == null)
                return;

            _service.GetAll();



            _dgvbindingSource.DataSource = _service.GetAll();
        }

       

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null);
            prodForm.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();
            }
        }

        private void tsvView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();
            }
        }
    }
}


