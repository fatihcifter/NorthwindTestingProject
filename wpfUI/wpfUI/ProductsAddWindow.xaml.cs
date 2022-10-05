using NorthWind.Controller;
using NorthWind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfUI
{
    /// <summary>
    /// Interaction logic for ProductsAddWindow.xaml
    /// </summary>
    public partial class ProductsAddWindow : Window
    {
        public ProductsAddWindow()
        {
            InitializeComponent();
        }

        private async void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Products product = new Products();

            product.supplierId = int.Parse(supplierId.Text);
            product.categoryId = int.Parse(categoryId.Text);
            product.quantityPerUnit = quantityPerUnit.Text;
            product.unitPrice = double.Parse(unitPrice.Text);
            product.unitsInStock = int.Parse(unitsInStock.Text);
            product.unitsOnOrder = int.Parse(unitsOnOrder.Text);
            product.reorderLevel = int.Parse(reorderLevel.Text);
            product.discontinued = discontinued.IsChecked.Value;
            product.name = name.Text;


            
            if (ButtonController.checker)
            {
                ProductsController.UpdateProducts(product);
            }
            else
            {
                ProductsController.PostProducts(product);
            }
        }
    }
}
