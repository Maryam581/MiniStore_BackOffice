using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Product
    {
        public string Id { get; internal set; }
        private string id { get; set; }
        private string Name { get; set; }
        private ProductCategoryEnum Category { get; set; }
        private int Stock { get; set; }
        private  decimal Price { get; set; }
        private ProductStatusEnum Status { get; set; }

    }
}
