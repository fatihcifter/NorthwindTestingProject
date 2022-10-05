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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private async void addSupplier_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers();

            
            supplier.companyName = companyAddName.Text;
            supplier.contactName = contactAddName.Text;
            supplier.contactTitle = contactAddTitle.Text;
            supplier.address = new Addresses();
            supplier.address.street = supplierStreet.Text;
            supplier.address.city = supplierCity.Text;
            supplier.address.country = supplierCountry.Text;
            supplier.address.region = supplierRegion.Text;
            supplier.address.postalCode = supplierPostalCode.Text;
            supplier.address.phone = supplierPhone.Text;

            await SuppliersController.PostSuppliers(supplier);
        }

        private void supplierStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void supplierCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierPostalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactAddTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactAddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyAddName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
