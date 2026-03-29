using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


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
            var Categories = new List<object> { "--All--" };
            Categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
           cmnCatagorie.SelectedIndex = 0;
            cmnCatagorie.DataSource = Categories;
           
           // cmnCatagorie.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            
            

            cmbstockstatus.Items.Clear();
            var stockstatus = new List<object> { "--All--" };
            stockstatus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbstockstatus.SelectedIndex = 0;
            cmbstockstatus.DataSource = stockstatus;
            
           // cmbstockstatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            
            


            if (_service == null)
                return;

            _service.GetAll();



            _dgvbindingSource.DataSource = _service.GetAll();
        }



        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null , _service);
            prodForm.ShowDialog();
            RefreshGrid();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct , _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
        }

        private void tsvView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct , _service);
                prodForm.ShowDialog();
            }
        }
        private void RefreshGrid()
        {
            string searchtext = cmbSearch.Text;

            ProductCategoryEnum? selectedCategory = null;

            if (cmnCatagorie.SelectedItem != null)
            {
                if (cmnCatagorie.SelectedItem.ToString().Equals("--All--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum)cmnCatagorie.SelectedItem;
                }





            }
            ProductStatusEnum? selectedstatus = null;

            if (cmbstockstatus.SelectedItem != null)
            {
                if (cmbstockstatus.SelectedItem.ToString().Equals("--All--"))
                {
                    selectedstatus = null;
                }
                else
                {
                    selectedstatus = (ProductStatusEnum)cmbstockstatus.SelectedItem;
                }





            }


            // ProductCategoryEnum? category = cmnCatagorie.SelectedItem != null ? (ProductCategoryEnum)cmnCatagorie.SelectedItem : null;
            // ProductStatusEnum? Status = cmbstockstatus.SelectedItem != null ? (ProductStatusEnum)cmbstockstatus.SelectedItem : null;

            _dgvbindingSource.DataSource = _service.Search(searchtext, selectedCategory, selectedstatus);
            _service.GetAll();



            _dgvbindingSource.DataSource = _service.GetAll();
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmnCatagorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();



        }

        private void cmbstockstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}


