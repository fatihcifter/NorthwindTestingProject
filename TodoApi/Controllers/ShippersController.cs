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
    public class ShippersController : ControllerBase
    #endregion
    {
        private readonly Shippers _context;



        // GET: api/shippers 
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetShippers()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/shippers"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/shippers/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetShippers(int id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/shippers/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/shippers/5
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutShippers(int id, Shippers todoItem)
        {
            
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(todoItem);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/shippers/"+id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return response.ToString();
                }
            }
       
        }
        #endregion

        // POST: api/shippers
        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostShippers()
        {


            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/shippers/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
;        }
        #endregion

        // DELETE: api/shippers/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteShippers(long id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/shipper/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return response.ReasonPhrase;
                }
            }
        }
        #endregion


    }


}
