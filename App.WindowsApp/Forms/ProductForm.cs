using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
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




            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }


            else if(mode == ProductFormModeEnum.View)
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

            }
           
        }

        
    }
}
