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
using System.Xml.Linq;

namespace wpfUI
{
    /// <summary>
    /// Interaction logic for ShippersAddWindow.xaml
    /// </summary>
    public partial class ShippersAddWindow : Window
    {
        public ShippersAddWindow()
        {
            InitializeComponent();
        }

        private void addSupplier_Click(object sender, RoutedEventArgs e)
        {
            Shippers shipper = new Shippers();

            shipper.companyName = companyName.Text;
            shipper.phone = phone
                .Text;

            if (ButtonController.checker)
            {
                shipper.id = int.Parse(id.Text);
                ShippersController.UpdateShippers(shipper);
            }
            else
            {
                ShippersController.PostShippers(shipper);
            }


        }
    }
}
