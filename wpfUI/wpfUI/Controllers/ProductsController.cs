



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
    public class ProductsController
    {
        public Products products;
        private static HttpContent _content;

        public static async Task<List<Products>> GetProducts()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Products");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Products> products = JsonConvert.DeserializeObject<List<Products>>(result);

          


            return products;
        }

        public static  async Task DeleteProducts(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Products/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostProducts(Products model)
        {
       
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            HttpResponseMessage responseMessage = await client.PostAsync("api/Products/", _content)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id products = JsonConvert.DeserializeObject<Id>(postResut);

            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Products/" + products.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateProducts(Products model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Products/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Orders> ShowProductDetail(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Products/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Products productDetail = JsonConvert.DeserializeObject<Products>(result);
            ProductsAddWindow add = new ProductsAddWindow();



           
            add.AddBtn.Content = "Güncelle";
            
            add.id.Text = productDetail.id.ToString();
            add.supplierId.Text = productDetail.supplierId.ToString();
            add.categoryId.Text = productDetail.categoryId.ToString();
            add.quantityPerUnit.Text = productDetail.quantityPerUnit;
            add.unitPrice.Text = productDetail.unitPrice.ToString();
            add.unitsInStock.Text = productDetail.unitsInStock.ToString();
            add.unitsOnOrder.Text = productDetail.unitsOnOrder.ToString();
            add.reorderLevel.Text = productDetail.reorderLevel.ToString();
            add.discontinued.IsChecked = productDetail.discontinued;
            add.name.Text = productDetail.name;
            

            
    

            add.Show();
            
              return null ;
        }



    }
}
