


using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWind.Models;
using NorthwindUI;
using System.Collections;
using System.Text;
using System.Text.Json;

namespace NorthWind.Controller
{
    public class OrdersController
    {
        public Orders order;
        private static HttpContent? _content;

        public static async Task<List<Orders>> GetOrders()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Orders");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Orders> orders = JsonConvert.DeserializeObject<List<Orders>>(result);

          


            return orders;
        }

        public static  async Task DeleteOrders(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Orders/"+id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostOrders(Orders model)
        {
       
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            HttpResponseMessage responseMessage = await client.PostAsync("api/Orders/",_content)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id orders = JsonConvert.DeserializeObject<Id>(postResut);

            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Orders/"+ orders.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateOrders(Orders model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Orders/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Orders> ShowOrderDetail(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Orders/"+id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Orders orderDetail = JsonConvert.DeserializeObject<Orders>(result);
            UpdateOrderPage add = new UpdateOrderPage();
            add.id.Text = orderDetail.id.ToString();
            add.customerId.Text = orderDetail.customerId;
            add.employeeId.Text = orderDetail.employeeId.ToString();
            add.orderDate.Text = orderDetail.orderDate;
            add.requiredDate.Text = orderDetail.requiredDate;
            add.shippedDate.Text = orderDetail.shippedDate;
            add.orderDate.Text = orderDetail.orderDate;
            add.shipVia.Text = orderDetail.shipVia.ToString();
            add.freight.Text = orderDetail.freight.ToString();
            add.shipName.Text = orderDetail.shipName;
            add.street.Text = orderDetail.shipAddress.street;
            add.city.Text = orderDetail.shipAddress.city;
            add.region.Text = orderDetail.shipAddress.region;

            add.postalCode.Text = orderDetail.shipAddress.postalCode;
            add.country.Text = orderDetail.shipAddress.country;

            
            foreach (var order in orderDetail.details)
            {
                ListViewItem item = new ListViewItem(order.productId.ToString());
                item.SubItems.Add(order.unitPrice.ToString());
                item.SubItems.Add(order.quantity.ToString());
                item.SubItems.Add(order.discount.ToString());


                add.listView1.Items.Add(item);


            }



            add.Show();
            
              return null ;
        }



        public string city { get; set; }
        public string region { get; set; }
        public int postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }

    }
}
