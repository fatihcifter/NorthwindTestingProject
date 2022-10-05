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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private async void CustomerAdd_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();

            customer.id = addCustomerId.Text;
            customer.companyName = companyAddName.Text;
            customer.contactName = contactAddName.Text;
            customer.contactTitle = contactAddTitle.Text;
            customer.address = new Addresses();
            customer.address.street = customerAddStreet.Text;
            customer.address.city = customerAddCity.Text;
            customer.address.country = customerAddCountry.Text;
            customer.address.region = customerAddRegion.Text;
            customer.address.postalCode = customerAddPostalCode.Text;
            customer.address.phone = customerAddPhone.Text;

            await  CustomerController.PostCustomers(customer);
        }
    }
}
