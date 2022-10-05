
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
    public class SuppliersController
    {
        public Suppliers products;
        private static HttpContent _content;

        public static async Task<List<Suppliers>> GetSuppliers()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Suppliers");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Suppliers> suppliers = JsonConvert.DeserializeObject<List<Suppliers>>(result);

          


            return suppliers;
        }

        public static  async Task DeleteSuppliers(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Suppliers/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostSuppliers(Suppliers model)
        {
       
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            HttpResponseMessage responseMessage = await client.PostAsync("api/Suppliers/", _content)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id suppliers = JsonConvert.DeserializeObject<Id>(postResut);

            model.id = int.Parse(suppliers.id);
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Suppliers/" + suppliers.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateSuppliers(Suppliers model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Suppliers/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Orders> ShowSuppliersDetail(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Suppliers/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Suppliers suppliersDetail = JsonConvert.DeserializeObject<Suppliers>(result);
            SupplierAddWindow supplierAdd = new SupplierAddWindow();
            supplierAdd.id.Text = suppliersDetail.id.ToString();
            supplierAdd.name.Text = suppliersDetail.companyName;
            supplierAdd.contactName.Text = suppliersDetail.contactName;
            supplierAdd.contactTitle.Text = suppliersDetail.contactTitle;

            supplierAdd.supplierStreet.Text = suppliersDetail.address.street;
            supplierAdd.supplierCity.Text = suppliersDetail.address.city;
            supplierAdd.supplierCountry.Text = suppliersDetail.address.country;
            supplierAdd.supplierRegion.Text = suppliersDetail.address.region;
            supplierAdd.supplierPostalCode.Text = suppliersDetail.address.postalCode;
            supplierAdd.supplierPhone.Text = suppliersDetail.address.phone;


            supplierAdd.addSupplier.Content = "Güncelle ";



            supplierAdd.Show();
            
              return null ;
        }




    }
}
