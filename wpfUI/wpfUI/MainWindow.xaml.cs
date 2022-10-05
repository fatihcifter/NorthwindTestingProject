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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using NorthWind.Controller;
using System.Reflection;

namespace wpfUI
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
    
        private void Orders_Click(object sender, RoutedEventArgs e)
        {

            checkForGrid("order");
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            checkForGrid("product");
        }

        private void Categories_Click(object sender, RoutedEventArgs e)
        {
            checkForGrid("category");
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            checkForGrid("customer");
        }

        private void Suppliers_Click(object sender, RoutedEventArgs e)
        {
            checkForGrid("supplier");
        }

        private void Shippers_Click(object sender, RoutedEventArgs e)
        {
            checkForGrid("shipper");
        }

        private void Employess_Click(object sender, RoutedEventArgs e)
        {
            checkForGrid("employee");
        }
        public void checkForGrid(string button)
        {
            if (button == "order")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/orders");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Order\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = false;
                Productsbtn.IsEnabled = true;
                Categoriesbtn.IsEnabled = true;
                Customersbtn.IsEnabled = true;
                Suppliersbtn.IsEnabled = true;
                Shippersbtn.IsEnabled = true;
                Employessbtn.IsEnabled = true;

                DataGridView.ItemsSource = w.order;
            }
            if (button == "product")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/products");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Product\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = true;
                Productsbtn.IsEnabled = false;
                Categoriesbtn.IsEnabled = true;
                Customersbtn.IsEnabled = true;
                Suppliersbtn.IsEnabled = true;
                Shippersbtn.IsEnabled = true;
                Employessbtn.IsEnabled = true;

                DataGridView.ItemsSource = w.product;
            }
            if (button == "category")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/category");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Categories\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = true;
                Productsbtn.IsEnabled = true;
                Categoriesbtn.IsEnabled = false;
                Customersbtn.IsEnabled = true;
                Suppliersbtn.IsEnabled = true;
                Shippersbtn.IsEnabled = true;
                Employessbtn.IsEnabled = true;


                DataGridView.ItemsSource = w.categories;
            }
            if (button == "customer")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/customers");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Customers\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = true;
                Productsbtn.IsEnabled = true;
                Categoriesbtn.IsEnabled = true;
                Customersbtn.IsEnabled = false;
                Suppliersbtn.IsEnabled = true;
                Shippersbtn.IsEnabled = true;
                Employessbtn.IsEnabled = true;


                DataGridView.ItemsSource = w.customers;
            }
            if (button == "supplier")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/suppliers");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Suppliers\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = true;
                Productsbtn.IsEnabled = true;
                Categoriesbtn.IsEnabled = true;
                Customersbtn.IsEnabled = true;
                Suppliersbtn.IsEnabled = false;
                Shippersbtn.IsEnabled = true;
                Employessbtn.IsEnabled = true;


                DataGridView.ItemsSource = w.suppliers;
            }
            if (button == "shipper")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/shippers");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Shippers\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = true;
                Productsbtn.IsEnabled = true;
                Categoriesbtn.IsEnabled = true;
                Customersbtn.IsEnabled = true;
                Suppliersbtn.IsEnabled = true;
                Shippersbtn.IsEnabled = false;
                Employessbtn.IsEnabled = true;


                DataGridView.ItemsSource = w.shippers;
            }
            if (button == "employee")
            {
                WebRequest req = WebRequest.Create("https://localhost:44351/api/employess");
                req.ContentType = "application/json";
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader re = new StreamReader(stream);
                String json = re.ReadToEnd();
                json = "{\"Employess\":" + json + "}";


                wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));

                Ordersbtn.IsEnabled = true;
                Productsbtn.IsEnabled = true;
                Categoriesbtn.IsEnabled = true;
                Customersbtn.IsEnabled = true;
                Suppliersbtn.IsEnabled = true;
                Shippersbtn.IsEnabled = true;
                Employessbtn.IsEnabled = false;


                DataGridView.ItemsSource = w.employess;
            }

        }
        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (!Ordersbtn.IsEnabled)

            {   
                ButtonController.checker = false;
                OrderAddWindow orderAddWindow = new OrderAddWindow();
                orderAddWindow.Show();
            }
            else if (!Productsbtn.IsEnabled)
            {
                ButtonController.checker = false;
                ProductsAddWindow productAddWindow = new ProductsAddWindow();
                productAddWindow.Show();
            }
            else if (!Categoriesbtn.IsEnabled)
            {
                ButtonController.checker = false;
                CategoryAddWindow categoryAddWindow = new CategoryAddWindow();
                categoryAddWindow.Show();
            }
            else if (!Customersbtn.IsEnabled)
            {
                ButtonController.checker = false;

                AddCustomerWindow addCustomerWindow = new AddCustomerWindow();
                addCustomerWindow.Show();
            }
        
           else  if (!Suppliersbtn.IsEnabled)
            {
                ButtonController.checker = false;
                SupplierAddWindow SupplierAddWindow = new SupplierAddWindow();
                SupplierAddWindow.Show();
            }
           else if (!Shippersbtn.IsEnabled)
            {
                ButtonController.checker = false;
               ShippersAddWindow shippersAddWindow = new ShippersAddWindow();
                shippersAddWindow.Show();
            }
             else if (!Employessbtn.IsEnabled)
            {
                ButtonController.checker = false;
                EmployeesAddWindow employeeAddWindow = new EmployeesAddWindow();
                employeeAddWindow.Show();
            }
        }

        private async void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
           
            if (DataGridView == null) return;
            var index = DataGridView.SelectedIndex;
            //here we get the actual row at selected index


          
            DataGridRow row = DataGridView.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;
          
           
            //here we get the actual data item behind the selected row
            var item = DataGridView.ItemContainerGenerator.ItemFromContainer(row);


            if (!Ordersbtn.IsEnabled)
            {


                Orders abc = (Orders)DataGridView.Items.GetItemAt(index);
                int a = abc.id;
                await OrdersController.DeleteOrders(a);

                checkForGrid("order");
            }
            else if (!Productsbtn.IsEnabled)
            {
                Products abc = (Products)DataGridView.Items.GetItemAt(index);
                int a = abc.id;
                await ProductsController.DeleteProducts(a);

                checkForGrid("product");
            }
            else if (!Categoriesbtn.IsEnabled)
            {

                Categories abc = (Categories)DataGridView.Items.GetItemAt(index);
                int a = abc.id;
                await CategoriesController.DeleteCategories(a);
                checkForGrid("category");
            }
            else if (!Customersbtn.IsEnabled)
            {
                Customers abc = (Customers)DataGridView.Items.GetItemAt(index);
                string a = abc.id;
              await   CustomerController.DeleteCustomers(a);
                checkForGrid("customer");
            }
            else if (!Suppliersbtn.IsEnabled)
            {
                Suppliers abc = (Suppliers)DataGridView.Items.GetItemAt(index);
                int a = abc.id;
                await SuppliersController.DeleteSuppliers(a);
                checkForGrid("supplier");
            }
            else if (!Shippersbtn.IsEnabled)
            {
                Shippers abc = (Shippers)DataGridView.Items.GetItemAt(index);
                int a = abc.id;
                await ShippersController.DeleteShippers(a);
                checkForGrid("shipper");
            }
            else if (!Employessbtn.IsEnabled)
            {

                Employess abc = (Employess)DataGridView.Items.GetItemAt(index);
                int a = abc.id;
                await EmployessController.DeleteEmployess(a);

               
                checkForGrid("employee");
            }
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridView.SelectedIndex > 0)
            {
                var index = DataGridView.SelectedIndex;
                //here we get the actual row at selected index

                if (!Ordersbtn.IsEnabled)
                {
                    Orders abc = (Orders)DataGridView.Items.GetItemAt(index);
                    int a = abc.id;
                    ButtonController.checker = true;
                    OrdersController.ShowOrderDetail(a);

                }
                else if (!Productsbtn.IsEnabled)
                {
                    ButtonController.checker = true;
                    Products abc = (Products)DataGridView.Items.GetItemAt(index);
                    int a = abc.id;
                    ProductsController.ShowProductDetail(a);
                    checkForGrid("product");
                }
                else if (!Categoriesbtn.IsEnabled)
                {
                    ButtonController.checker = true;
                    Categories abc = (Categories)DataGridView.Items.GetItemAt(index);
                    int a = abc.id;
                    CategoriesController.ShowCategoriesDetail(a);
                    checkForGrid("category");
                }
                else if (!Customersbtn.IsEnabled)
                {
                    ButtonController.checker = true;
                    Customers abc = (Customers)DataGridView.Items.GetItemAt(index);
                    string a = abc.id;
                    CustomerController.ShowCustomerDetail(a);
                    checkForGrid("customer");
                }
                else if (!Suppliersbtn.IsEnabled)
                {
                    ButtonController.checker = true;
                    Suppliers abc = (Suppliers)DataGridView.Items.GetItemAt(index);
                    int a = abc.id;
                    await SuppliersController.ShowSuppliersDetail(a);
                    checkForGrid("supplier");
                   
                }
                else if (!Shippersbtn.IsEnabled)
                {
                    ButtonController.checker = true;
                    Shippers abc = (Shippers)DataGridView.Items.GetItemAt(index);
                    int a = abc.id;
                    await ShippersController.ShowShippersDetail(a);
                    checkForGrid("shipper");
                }
                else if (!Employessbtn.IsEnabled)
                {
                    ButtonController.checker = true;
                    Employess abc = (Employess)DataGridView.Items.GetItemAt(index);
                    int a = abc.id;
                    EmployessController.ShowEmployessDetail(a);
                    checkForGrid("employee");
                }
            }
        }

        private void Detailsbtn_Click(object sender, RoutedEventArgs e)
        {
            OrderAddWindow orderAddWindow = new OrderAddWindow();
            orderAddWindow.Show();
        }
    }




    }
 
