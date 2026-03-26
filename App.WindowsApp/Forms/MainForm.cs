using App.Core.Services;
using App.WindowsApp.Views;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class Main : Form
    {
        InMemoryProductService _productServices = new InMemoryProductService();
         Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new DashboardView());
             ShowView(() => new DashboardView());

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductsView(_productServices));
        }

        private void ShowView<T>(Func<T> factory) where T:UserControl
        {
            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory() ?? throw new InvalidOperationException("Factory returned null");
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}