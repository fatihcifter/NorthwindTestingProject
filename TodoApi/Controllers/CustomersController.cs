using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json;
using TodoApi.Models;
using System.Collections;
using System.Text;

namespace TodoApi.Controllers
{
    #region snippet_Route
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    #endregion
    {
        private readonly Customers _context;



        // GET: api/GetCustomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetCustomers()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/customers"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/GetCustomers/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetCustomers(string id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/customers/"+ id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/PutCustomers/5
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutCustomers(string id, Customers todoItem)
        {
             
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(todoItem);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");
                
                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/customers/" + id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse.ToString();
                }
            }
       
        }
        #endregion

        // POST: api/PostCustomers
        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<IEnumerable>> PostCustomers()
        {

            
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/customers/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
        }
        #endregion

        // DELETE: api/DeleteCustomers/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteCustomers(string id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/customers/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(response.ReasonPhrase);
                }
            }
        }
        #endregion


    }


}
