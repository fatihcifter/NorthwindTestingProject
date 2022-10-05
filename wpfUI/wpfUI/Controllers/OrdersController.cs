using Newtonsoft.Json;
using NorthWind.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using wpfUI;

namespace NorthWind.Controller
{
    public class OrdersController
    {
        public Orders order;
        private static HttpContent _content;

        //public static  String GetOrders()
        //{
           
        //}

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
            OrderAddWindow add = new OrderAddWindow();

            if (ButtonController.checker)
            {
                add.IdLabel.IsEnabled = false;
                add.id.IsEnabled = false;
                add.id.Text = orderDetail.id.ToString();
                add.AddBtn.Content = "Güncelle";
            }
            
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
          




            add.Show();
            
              return null ;
        }


       

    }
}
