


using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWind.Models;
using NorthwindUI;
using System.Collections;
using System.Text;
using System.Text.Json;

namespace NorthWind.Controller
{
    public class ShippersController
    {
        public Shippers products;
        private static HttpContent? _content;

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
            Shippers productDetail = JsonConvert.DeserializeObject<Shippers>(result);
            UpdateProduct add = new UpdateProduct();
            add.id.Text = productDetail.id.ToString();
            //add.supplierId.Text = productDetail.supplierId.ToString();
            //add.ShippersId.Text = productDetail.ShippersId.ToString();
           
          //  add.name.Text = productDetail.name;
            

            
    

            add.Show();
            
              return null ;
        }




    }
}
