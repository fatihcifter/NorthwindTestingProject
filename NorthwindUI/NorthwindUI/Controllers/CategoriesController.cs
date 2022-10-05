


using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWind.Models;
using NorthwindUI;
using System.Collections;
using System.Text;
using System.Text.Json;

namespace NorthWind.Controller
{
    public class CategoriesController
    {
        public Categories products;
        private static HttpContent? _content;

        public static async Task<List<Categories>> GetCategories()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Category");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Categories> products = JsonConvert.DeserializeObject<List<Categories>>(result);

          


            return products;
        }

        public static  async Task DeleteCategories(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Category/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostCategories(Categories model)
        {
       
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            var empty = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync("api/Category/", empty)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id products = JsonConvert.DeserializeObject<Id>(postResut);

            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Category/" + products.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateCategories(Categories model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Category/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Orders> ShowCategoriesDetail(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Category/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Categories productDetail = JsonConvert.DeserializeObject<Categories>(result);
            UpdateProduct add = new UpdateProduct();
            add.id.Text = productDetail.id.ToString();
            //add.supplierId.Text = productDetail.supplierId.ToString();
            //add.categoryId.Text = productDetail.categoryId.ToString();
           
            add.name.Text = productDetail.name;
            

            
    

            add.Show();
            
              return null ;
        }




    }
}
