


using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWind.Models;
using NorthwindUI;
using System.Collections;
using System.Text;
using System.Text.Json;

namespace NorthWind.Controller
{
    public class CustomerController
    {
        public Customers products;
        private static HttpContent? _content;

        public static async Task<List<Customers>> GetCustomers()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Customers");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Customers> products = JsonConvert.DeserializeObject<List<Customers>>(result);

          


            return products;
        }

        public static  async Task DeleteCustomers(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Category/" + id);
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
            UpdateCustomers customer = new UpdateCustomers();
            customer.customerUpdateId.Text = customerDetail.id;
            customer.companyUpdateName.Text = customerDetail.companyName;
            customer.contactUpdateName.Text = customerDetail.contactName;
            customer.contactUpdateTitle.Text = customerDetail.contactTitle;
            
            customer.customerUpdateStreet.Text = customerDetail.address.street;
            customer.customerCity.Text = customerDetail.address.city;
            customer.customerCountry.Text = customerDetail.address.country;
            customer.customerRegion.Text = customerDetail.address.region;
            customer.customerPostalCode.Text = customerDetail.address.postalCode;
            customer.customerPhone.Text = customerDetail.address.phone;


            customer.Show();
            
              return null ;
        }




    }
}
