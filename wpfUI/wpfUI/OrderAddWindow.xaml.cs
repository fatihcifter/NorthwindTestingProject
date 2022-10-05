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
    /// OrderAddWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class OrderAddWindow : Window
    {
        public OrderAddWindow()
        {   

            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
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

            if (ButtonController.checker)
            {
                OrdersController.UpdateOrders(order);
            }
            else { 
            OrdersController.PostOrders(order);
            }

        }
    }
}
