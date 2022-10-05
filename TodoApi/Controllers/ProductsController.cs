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
    public class ProductsController : ControllerBase
    #endregion
    {
        private readonly Products _context;



        // GET: api/GetProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetProducts()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/GetProducts/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetProducts(long id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/products/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/PutProducts/5
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutProducts(long id, Products products)
        {
             
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(products);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/products/" + id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return response.ToString();
                }
            }       
        }
        #endregion

        // POST: api/PostProducts
        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<IEnumerable>> PostProducts()
        {

            
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/products/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
        }
        #endregion

        // DELETE: api/DeleteProducts/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteProducts(long id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/products/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(response.ReasonPhrase);
                }
            }
        }
        #endregion


    }


}
