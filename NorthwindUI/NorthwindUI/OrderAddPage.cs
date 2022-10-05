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
    public partial class OrderAddPage : Form
    {
        public OrderAddPage()
        {
            InitializeComponent();
        }

        private void PostOrder_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.customerId = customerId.Text;
            order.employeeId = int.Parse(employeeId.Text);
            order.orderDate = orderDate.Text;
            order.requiredDate = requiredDate.Text;
            order.shippedDate = shippedDate.Text;
            order.shipVia = double.Parse(shipVia.Text);
            order.freight = double.Parse(freight.Text);
            order.shipName = shipName.Text;
            order.shipAddress = new ShipAddress();
            order.shipAddress.street = street.Text;
            order.shipAddress.city = city.Text;
            order.shipAddress.region = region.Text;
            order.shipAddress.postalCode = postalCode.Text;
            order.shipAddress.country = country.Text;
            order.details = new List<Detail>();


            Detail detail = new Detail();


            detail.productId = double.Parse(productId.Text);
            detail.unitPrice = double.Parse(unitPrice.Text); 
            detail.quantity = double.Parse(quantity.Text);
            detail.discount = double.Parse(discount.Text);   


            order.details.Add(detail);


            OrdersController.PostOrders(order);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void productId_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_TextChanged(object sender, EventArgs e)
        {

        }

        private void postalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void region_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void street_TextChanged(object sender, EventArgs e)
        {

        }

        private void shipName_TextChanged(object sender, EventArgs e)
        {

        }

        private void freight_TextChanged(object sender, EventArgs e)
        {

        }

        private void shipVia_TextChanged(object sender, EventArgs e)
        {

        }

        private void shippedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void requiredDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
