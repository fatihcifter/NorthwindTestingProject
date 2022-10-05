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
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private async void addSupplier_Click(object sender, RoutedEventArgs e)
        {
            Customers customer = new Customers();


            customer.companyName = name.Text;
            customer.contactName = contactName.Text;
            customer.contactTitle = contactTitle.Text;
            customer.address = new Addresses();
            customer.address.street = supplierStreet.Text;
            customer.address.city = supplierCity.Text;
            customer.address.country = supplierCountry.Text;
            customer.address.region = supplierRegion.Text;
            customer.address.postalCode = supplierPostalCode.Text;
            customer.address.phone = supplierPhone.Text;


            if (ButtonController.checker)
            {
                customer.id = id.Text;
                
                await CustomerController.UpdateCustomers(customer);
            }
            else
            {
                await CustomerController.PostCustomers(customer);
            }
        }
    }
}
