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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            Products order = new Products();
            order.id = int.Parse(id.Text);
            order.supplierId = int.Parse(supplierId.Text);
            order.categoryId = int.Parse(categoryId.Text);
            order.quantityPerUnit = quantityPerUnit.Text;
            order.unitPrice = double.Parse(unitPrice.Text);
            order.unitsInStock = int.Parse(unitsInStock.Text);
            order.unitsOnOrder = int.Parse(unitsOnOrder.Text);
            order.reorderLevel = int.Parse(reorderLevel.Text);
            order.discontinued = discontinued.Checked;
            order.name = name.Text;





            ProductsController.UpdateProducts(order);
        }
    }
}
