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
    public class OrdersController : ControllerBase
    #endregion
    {
        private readonly Orders _context;



        // GET: api/GetOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetOrders()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/orders"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/GetOrders/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetOrders(long id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/orders/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/PutOrders/5
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutOrders(long id, Orders order)
        {
             
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(order);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/orders/" + id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return response.ToString();
                }
            }
       
        }
        #endregion

        // POST: api/PostOrder
        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<IEnumerable>> PostOrder()
        {

            
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/orders/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
        }
        #endregion

        // DELETE: api/DeleteOrder/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteOrder(long id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/orders/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(response.ReasonPhrase);
                }
            }
        }
        #endregion


    }


}
