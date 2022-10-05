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
    public partial class UpdateOrderPage : Form
    {
        public UpdateOrderPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.id = int.Parse(id.Text);
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

            


            foreach (ListViewItem orderDetail in listView1.Items)
            {
                Detail detail = new Detail();






                detail.productId = double.Parse(orderDetail.SubItems[0].Text);
                        detail.unitPrice = double.Parse(orderDetail.SubItems[1].Text);
                        detail.quantity = double.Parse(orderDetail.SubItems[2].Text);
                        detail.discount = double.Parse(orderDetail.SubItems[3].Text);
                    
           




            order.details.Add(detail);
            }
            OrdersController.UpdateOrders(order);
        }

        private void UpdateOrderPage_Load(object sender, EventArgs e)
        {

        }

        private void orderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void requiredDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void shippedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void shipVia_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void freight_TextChanged(object sender, EventArgs e)
        {

        }

        private void shipName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void DetailAdd_Click(object sender, EventArgs e)
        {
          

            Detail detail = new Detail();
            //foreach (Details orderDetail in listView1.Items)
            
            detail.productId = double.Parse(productBox.Text);
            detail.unitPrice = double.Parse(unitBox.Text);
            detail.quantity = double.Parse(quantityBox.Text);
            detail.discount = double.Parse(discountBox.Text);

            ListViewItem item = new ListViewItem(detail.productId.ToString());
            item.SubItems.Add(detail.unitPrice.ToString());
            item.SubItems.Add(detail.quantity.ToString());
            item.SubItems.Add(detail.discount.ToString());


            listView1.Items.Add(item);


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

        private void customerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void discountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
