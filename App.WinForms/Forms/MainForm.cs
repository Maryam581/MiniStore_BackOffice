using System;
using System.Collections.Generic;
using System.Windows.Forms;
using App.WinForms.Views;

namespace App.WinForms.Forms
{
    public partial class Main : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
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
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new DashboardView());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new ProductView());
        }

        private void ShowView<T>(Func<T> factory) where T:UserControl
        {
            var key = typeof(T);

            if(_views.TryGetValue(key, out var view))
            {
                 view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;//if value not found there
            }
            //View
            if (!pnlContent.Controls.Contains(view))

            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }
             
            view.BringToFront();
        }
    }
}