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
    public class ShippersController
    {
        public Shippers products;
        private static HttpContent _content;

        public static async Task<List<Shippers>> GetShippers()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Shippers");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Shippers> products = JsonConvert.DeserializeObject<List<Shippers>>(result);

          


            return products;
        }

        public static  async Task DeleteShippers(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Shippers/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostShippers(Shippers model)
        {
        
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            var empty = new StringContent("", Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessage = await client.PostAsync("api/Shippers", empty)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id shippers = JsonConvert.DeserializeObject<Id>(postResut);

            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Shippers/" + shippers.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateShippers(Shippers model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Shippers/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Orders> ShowShippersDetail(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Shippers/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Shippers supplierDetail = JsonConvert.DeserializeObject<Shippers>(result);
            ShippersAddWindow add = new ShippersAddWindow
                ();
            add.id.Text = supplierDetail.id.ToString();
            add.companyName
                .Text = supplierDetail.companyName.ToString();
            add.phone.Text = supplierDetail.phone.ToString();
            add.addSupplier.Content = "Güncelle ";






            add.Show();
            
              return null ;
        }




    }
}
