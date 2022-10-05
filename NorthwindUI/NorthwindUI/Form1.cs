using System.Text.Json;
using System.Text.Json.Serialization;
using NorthWind.Models;
using NorthWind.Controller;
namespace NorthwindUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
          

        {
            panel1.BringToFront();
           
            panel1.Visible = true;
            panel2.SendToBack();
            panel2.Visible = false;
            panel3.SendToBack();
            panel3.Visible = false;
            panel4.SendToBack();
            panel4.Visible = false;
            panel5.SendToBack();
            panel5.Visible = false;
            panel6.SendToBack();
            panel6.Visible = false;
            panel7.SendToBack();
            panel7.Visible = false;
            listView1.Items.Clear();
            List<Orders> orders = await OrdersController.GetOrders();

            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem(order.id.ToString());
                item.SubItems.Add(order.customerId);
                item.SubItems.Add(order.employeeId.ToString());
                item.SubItems.Add(order.orderDate);
                item.SubItems.Add(order.requiredDate);
                item.SubItems.Add(order.shippedDate);
                item.SubItems.Add(order.shipVia.ToString());
                item.SubItems.Add(order.freight.ToString());
                item.SubItems.Add(order.shipName);
                listView1.Items.Add(item);
                
                
            }


        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {

                string index = listView1.SelectedItems[0].Text;
                listView1.Items.Remove(listView1.SelectedItems[0]);
                OrdersController.DeleteOrders(int.Parse(index));

            }
        }

        private void OrderAdd_Click(object sender, EventArgs e)
        {
            OrderAddPage add = new OrderAddPage();
            add.Show();
               

        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                string index = listView1.SelectedItems[0].Text;
                OrdersController.ShowOrderDetail(int.Parse(index));
                

            
            }

        }

        private async void Products_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;
            panel1.SendToBack();
            panel1.Visible = false;
            panel3.SendToBack();
            panel3.Visible = false;
            panel4.SendToBack();
            panel4.Visible = false;
            panel5.SendToBack();
            panel5.Visible = false;
            panel6.SendToBack();
            panel6.Visible = false;
            panel7.SendToBack();
            panel7.Visible = false;
            productView.Items.Clear();
            List<Products> products = await ProductsController.GetProducts();

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.id.ToString());
                item.SubItems.Add(product.id.ToString());
                item.SubItems.Add(product.supplierId.ToString());
                item.SubItems.Add(product.categoryId.ToString());
                item.SubItems.Add(product.quantityPerUnit);
                item.SubItems.Add(product.unitPrice.ToString());
                item.SubItems.Add(product.unitsInStock.ToString());
                item.SubItems.Add(product.unitsOnOrder.ToString());
                item.SubItems.Add(product.reorderLevel.ToString());
                item.SubItems.Add(product.discontinued.ToString());
                item.SubItems.Add(product.name);

                productView.Items.Add(item);


            }

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            string index = productView.SelectedItems[0].Text;
            productView.Items.Remove(productView.SelectedItems[0]);
            ProductsController.DeleteProducts(int.Parse(index));
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            if (productView.Items.Count > 0)
            {
                string index = productView.SelectedItems[0].Text;
                ProductsController.ShowProductDetail(int.Parse(index));


                
            }

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productView.FindItemWithText("5");
        }

        private async void categories_Click(object sender, EventArgs e)
        {
 
            panel3.BringToFront();
            panel3.Visible = true;
            panel1.SendToBack();
            panel1.Visible = false;
            panel2.SendToBack();
            panel2.Visible = false;
            panel4.SendToBack();
            panel4.Visible = false;
            panel5.SendToBack();
            panel5.Visible = false;
            panel6.SendToBack();
            panel6.Visible = false;
            panel7.SendToBack();
            panel7.Visible = false;
            categoryView.Items.Clear();
            List<Categories> categories = await CategoriesController.GetCategories();

            foreach (var category in categories)
            {
                ListViewItem item = new ListViewItem(category.id.ToString());
              
                item.SubItems.Add(category.description);
                item.SubItems.Add(category.name);
               

                categoryView.Items.Add(item);


            }
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();

            category.description = categoryDescBox.Text;
            category.name = categoryNameBox.Text;



            CategoriesController.PostCategories(category);
        }

        private void CategoryUpdate_Click(object sender, EventArgs e)

        {
            Categories category = new Categories();
            category.description = categoryDescBox.Text;
            category.name = categoryNameBox.Text;
            category.id = int.Parse(categoryIdBox.Text);
            CategoriesController.UpdateCategories(category);
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            string index = categoryView.SelectedItems[0].Text;
            categoryView.Items.Remove(categoryView.SelectedItems[0]);
            CategoriesController.DeleteCategories(int.Parse(index));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private async void customer_Click(object sender, EventArgs e)
        {
           
            panel4.BringToFront();
            panel4.Visible = true;
            panel7.SendToBack();
            panel7.Visible = false;
            panel5.SendToBack();
            panel5.Visible = false;
            panel1.SendToBack();
            panel1.Visible = false;
            panel2.SendToBack();
            panel2.Visible = false;
            panel3.SendToBack();
            panel3.Visible = false;
            panel6.SendToBack();
            panel6.Visible = false;
            customerView.Items.Clear();
            List<Customers> customers = await CustomerController.GetCustomers();

            foreach (var customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.id.ToString());
                item.SubItems.Add(customer.companyName);
                item.SubItems.Add(customer.contactName);
                item.SubItems.Add(customer.contactTitle);
                item.SubItems.Add(customer.address.street);
                item.SubItems.Add(customer.address.city);
                item.SubItems.Add(customer.address.region);
                item.SubItems.Add(customer.address.postalCode);
                item.SubItems.Add(customer.address.country);
                item.SubItems.Add(customer.address.phone);



                customerView.Items.Add(item);


            }
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer customerAdd = new AddCustomer();
            customerAdd.Show();
        }


        private void DeleteCustomers_Click(object sender, EventArgs e)
        {
            string index = customerView.SelectedItems[0].Text;
            customerView.Items.Remove(customerView.SelectedItems[0]);
            CustomerController.DeleteCustomers(int.Parse(index));
        }

        private void UpdateCustomers_Click(object sender, EventArgs e)
        {
            if (customerView.Items.Count > 0)
            {
                string index = customerView.SelectedItems[0].Text;
                CustomerController.ShowCustomerDetail(index);



            }

        }

        private async void Suppliers_Click(object sender, EventArgs e)
        {   
            panel5.BringToFront();
            panel5.Visible = true;
            panel4.SendToBack();
            panel4.Visible = false;
            panel1.SendToBack();
            panel1.Visible = false;
            panel2.SendToBack();
            panel2.Visible = false;
            panel3.SendToBack();
            panel3.Visible = false;
            panel6.SendToBack();
            panel6.Visible = false;
            panel7.SendToBack();
            panel7.Visible = false;
            suppliersView.Items.Clear();
   
            List<Suppliers> Suppliers = await SuppliersController.GetSuppliers();

            foreach (var supplier in Suppliers)
            {
                ListViewItem item = new ListViewItem(supplier.id.ToString());
                item.SubItems.Add(supplier.companyName);
                item.SubItems.Add(supplier.contactName);
                item.SubItems.Add(supplier.contactTitle);
                item.SubItems.Add(supplier.address.street);
                item.SubItems.Add(supplier.address.city);
                item.SubItems.Add(supplier.address.region);
                item.SubItems.Add(supplier.address.postalCode);
                item.SubItems.Add(supplier.address.country);
                item.SubItems.Add(supplier.address.phone);



                suppliersView.Items.Add(item);


            }
        }

        private void deleteSuppliers_Click(object sender, EventArgs e)
        {
            string index = suppliersView.SelectedItems[0].Text;
            suppliersView.Items.Remove(suppliersView.SelectedItems[0]);
            SuppliersController.DeleteSuppliers(int.Parse(index));
        }

        private void updateSuppliers_Click(object sender, EventArgs e)
        {
            if (suppliersView.Items.Count > 0)
            {
                string index = suppliersView.SelectedItems[0].Text;
                SuppliersController.ShowSuppliersDetail(int.Parse(index));



            }

        }

        private void addSuppliers_Click(object sender, EventArgs e)
        {
            AddSuppliers supplierAdd = new AddSuppliers();
            supplierAdd.Show();
        }

        private void shippersDelete_Click(object sender, EventArgs e)
        {
            string index = shippersView.SelectedItems[0].Text;
            shippersView.Items.Remove(shippersView.SelectedItems[0]);
            CategoriesController.DeleteCategories(int.Parse(index));
        }

        private async void Shippers_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
            panel6.Visible = true;
            panel4.SendToBack();
            panel4.Visible = false;
            panel1.SendToBack();
            panel1.Visible = false;
            panel2.SendToBack();
            panel2.Visible = false;
            panel3.SendToBack();
            panel3.Visible = false;
            panel5.SendToBack();
            panel5.Visible = false;
            panel7.SendToBack();
            panel7.Visible = false;

            shippersView.Items.Clear();
            List<Shippers> shippers = await ShippersController.GetShippers();

            foreach (var shipper in shippers)
            {
                ListViewItem item = new ListViewItem(shipper.id.ToString());

                item.SubItems.Add(shipper.companyName);
                item.SubItems.Add(shipper.phone);


                shippersView.Items.Add(item);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void shippersAdd_Click(object sender, EventArgs e)
        {
            Shippers shipper = new Shippers();

            shipper.companyName = shipperCName.Text;
            shipper.phone = shipperCPhone.Text;


            ShippersController.PostShippers(shipper);
        }

        private void shippersUpdate_Click(object sender, EventArgs e)
        {
            Shippers shipper = new Shippers();
            shipper.companyName = shipperCName.Text;
            shipper.phone = shipperCPhone.Text;
            shipper.id = int.Parse(shipperId.Text);
            ShippersController.UpdateShippers(shipper);
        }

        private async void Employess_Click(object sender, EventArgs e)
        {
            panel7.BringToFront();
            panel7.Visible = true;
            panel4.SendToBack();
            panel4.Visible = false;
            panel1.SendToBack();
            panel1.Visible = false;
            panel2.SendToBack();
            panel2.Visible = false;
            panel3.SendToBack();
            panel3.Visible = false;
            panel5.SendToBack();
            panel5.Visible = false;
            panel6.SendToBack();
            panel6.Visible = false;
            employessView.Items.Clear();
            List<Employess> employess = await EmployessController.GetEmployess();

            foreach (var employe in employess)
            {
                ListViewItem item = new ListViewItem(employe.id.ToString());
                item.SubItems.Add(employe.lastName);
                item.SubItems.Add(employe.firstName);
                item.SubItems.Add(employe.title);
                item.SubItems.Add(employe.titleOfCourtesy);
                item.SubItems.Add(employe.birthDate);
                item.SubItems.Add(employe.hireDate);
                item.SubItems.Add(employe.territoryIds.ToString());
      
                item.SubItems.Add(employe.address.street);
                item.SubItems.Add(employe.address.city);
                item.SubItems.Add(employe.address.region);
                item.SubItems.Add(employe.address.postalCode);
                item.SubItems.Add(employe.address.country);
                item.SubItems.Add(employe.address.phone);
                item.SubItems.Add(employe.reportsTo.ToString());
                item.SubItems.Add(employe.notes);
                employessView.Items.Add(item);


            }


        }

        private void employessAdd_Click(object sender, EventArgs e)
        {
            AddEmployess employeAdd = new AddEmployess();
            employeAdd.Show();
        }

        private void employessDelete_Click(object sender, EventArgs e)
        {
            string index = employessView.SelectedItems[0].Text;
            employessView.Items.Remove(employessView.SelectedItems[0]);
            EmployessController.DeleteEmployess(int.Parse(index));
        }

        private void employessUpdate_Click(object sender, EventArgs e)
        {
            if (employessView.Items.Count > 0)
            {
                string index = employessView.SelectedItems[0].Text;
                EmployessController.ShowEmployessDetail(int.Parse(index));



            }
        }
    }
}