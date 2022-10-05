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
    public partial class UpdateSuppliers : Form
    {
        public UpdateSuppliers()
        {
            InitializeComponent();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers();
            supplier.id = int.Parse(supplierUpdateId.Text);
            supplier.companyName = companyUpdateName.Text;
            supplier.contactName = contactUpdateName.Text;
            supplier.contactTitle = contactUpdateTitle.Text;
            supplier.address = new Addresses();

            supplier.address.street = supplierStreet.Text;
            supplier.address.country = supplierCountry.Text;
            supplier.address.city = supplierCity.Text;
            supplier.address.region = supplierRegion.Text;
            supplier.address.postalCode = supplierPostalCode.Text;
            supplier.address.phone = supplierPhone.Text;





            SuppliersController.UpdateSuppliers(supplier);
        }
    }
}
