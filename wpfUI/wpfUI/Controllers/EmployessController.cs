


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
    public class EmployessController
    {
        public Employess order;
        private static HttpContent _content;

        public static async Task<List<Employess>> GetEmployess()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Employess");
            string result = await responseMessage.Content.ReadAsStringAsync();
            List<Employess> Employess = JsonConvert.DeserializeObject<List<Employess>>(result);

          


            return Employess;
        }

        public static  async Task DeleteEmployess(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.DeleteAsync("api/Employess/"+id);
            string result = await responseMessage.Content.ReadAsStringAsync();           

        }

        public static async Task PostEmployess(Employess model)
        {
       
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            HttpResponseMessage responseMessage = await client.PostAsync("api/Employess/",_content)  ;
            string postResut = await responseMessage.Content.ReadAsStringAsync();
            Id Employess = JsonConvert.DeserializeObject<Id>(postResut);

            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Employess/"+ Employess.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }

        public static async Task UpdateEmployess(Employess model)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");

            
            var abc = JsonConvert.SerializeObject(model);
            var acontent = new StringContent(abc, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessagePut = await client.PutAsync("api/Employess/" + model.id, acontent);



            string result = await responseMessagePut.Content.ReadAsStringAsync();

        }
        public static async Task<Employess> ShowEmployessDetail(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44351/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Employess/"+id);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Employess eDetail = JsonConvert.DeserializeObject<Employess>(result);
            EmployeesAddWindow add = new EmployeesAddWindow();
            add.id.Text = eDetail.id.ToString();
            add.lastName.Text = eDetail.lastName;
            add.firstName.Text = eDetail.firstName.ToString();
            add.title.Text = eDetail.title;
            add.titleOfCourtesy.Text = eDetail.titleOfCourtesy;
            add.birthDate.Text = eDetail.birthDate;
            add.hireDate.Text = eDetail.hireDate;
            add.notes.Text = eDetail.notes;
            add.reportsTo.Text = eDetail.reportsTo.ToString();



            add.EmployeeBtn.Content = "Güncelle";
            add.street.Text = eDetail.address.street;
            add.city.Text = eDetail.address.city;
            add.region.Text = eDetail.address.region;

            add.postalCode.Text = eDetail.address.postalCode;
            add.country.Text = eDetail.address.country;
            add.phone.Text = eDetail.address.phone;

            //foreach (var order in eDetail.territoryIds)
            //{
            //    ListViewItem item = new ListViewItem(order.ToString());            
            //                    add.territoryView.Items.Add(item);

            //                }



            add.Show();
            
              return null ;
        }




    }
}
