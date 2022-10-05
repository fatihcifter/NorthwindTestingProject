using NorthWind.Controller;
using NorthWind.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindUI
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void shippedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostProduct_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            product.supplierId = int.Parse(supplierId.Text);
            product.categoryId = int.Parse(categoryId.Text);
            product.quantityPerUnit = quantityPerUnit.Text;
            product.unitPrice = double.Parse(unitPrice.Text);
            product.unitsInStock = int.Parse(unitsInStock.Text);
            product.unitsOnOrder = int.Parse(unitsOnOrder.Text);
            product.reorderLevel = int.Parse(reorderLevel.Text);
            product.discontinued = discontinued.Checked;
            product.name = name.Text;


            ProductsController.PostProducts(product);
        }
    }
}
