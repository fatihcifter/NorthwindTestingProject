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
    public class CustomerController
    {
        public Customers products;
        private static HttpContent _content;

        public static async Task<List<Customers>> GetCustomers()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Customers");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Customers> products = JsonConvert.DeserializeObject<List<Customers>>(result);

          


            return products;
        }

        public static  async Task DeleteCustomers(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Customers/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostCustomers(Customers model)
        {
       
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            HttpResponseMessage responseMessage = await client.PostAsync("api/Customers/", _content)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id customer = JsonConvert.DeserializeObject<Id>(postResut);

            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Customers/" + customer.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateCustomers(Customers model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Customers/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Customers> ShowCustomerDetail(string id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Customers/" + id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Customers customerDetail = JsonConvert.DeserializeObject<Customers>(result);
            AddCustomerWindow customer = new AddCustomerWindow();
            customer.id.Text = customerDetail.id;
            customer.name.Text = customerDetail.companyName;
            customer.contactName.Text = customerDetail.contactName;
            customer.contactTitle.Text = customerDetail.contactTitle;
            
            customer.supplierStreet.Text = customerDetail.address.street;
            customer.supplierCity.Text = customerDetail.address.city;
            customer.supplierCountry.Text = customerDetail.address.country;
            customer.supplierRegion
                .Text = customerDetail.address.region;
            customer.supplierPostalCode.Text = customerDetail.address.postalCode;
            customer.supplierPhone.Text = customerDetail.address.phone;

            customer.addCustomer.Content = "Güncelle";
            customer.Show();
            
              return null ;
        }




    }
}
