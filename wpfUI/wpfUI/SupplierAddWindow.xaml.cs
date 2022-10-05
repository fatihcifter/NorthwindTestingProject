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
    /// Interaction logic for SupplierAddWindow.xaml
    /// </summary>
    public partial class SupplierAddWindow : Window
    {
        public SupplierAddWindow()
        {
            InitializeComponent();
        }

        private async void addSupplier_Click(object sender, RoutedEventArgs e)
        {
            Suppliers supplier = new Suppliers();


            supplier.companyName = name.Text;
            supplier.contactName = contactName.Text;
            supplier.contactTitle = contactTitle.Text;
            supplier.address = new Addresses();
            supplier.address.street = supplierStreet.Text;
            supplier.address.city = supplierCity.Text;
            supplier.address.country = supplierCountry.Text;
            supplier.address.region = supplierRegion.Text;
            supplier.address.postalCode = supplierPostalCode.Text;
            supplier.address.phone = supplierPhone.Text;


            if (ButtonController.checker)
            {
                supplier.id = int.Parse(id.Text);
                addSupplier.Content = "Güncelle";
                await SuppliersController.UpdateSuppliers(supplier);
            }
            else
            {
                await SuppliersController.PostSuppliers(supplier);
            }



      
        }
    }
}
