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
    public partial class UpdateCustomers : Form
    {
        public UpdateCustomers()
        {
            InitializeComponent();
        }



        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.id = customerUpdateId.Text;
            customer.companyName = companyUpdateName.Text;
            customer.contactName = contactUpdateName.Text;
            customer.contactTitle = contactUpdateTitle.Text;

            customer.address = new Addresses();

            customer.address.street = customerUpdateStreet.Text;
            customer.address.country = customerCountry.Text;
            customer.address.city = customerCity.Text;
            customer.address.region = customerRegion.Text;
            customer.address.postalCode = customerPostalCode.Text;
            customer.address.phone = customerPhone.Text;
       



           
            CustomerController.UpdateCustomers(customer);
        }
    }
}
