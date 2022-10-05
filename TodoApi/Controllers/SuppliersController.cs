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
    public class SuppliersController : ControllerBase
    #endregion
    {
        private readonly Suppliers _context;



        // GET: api/suppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetSuppliers()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/suppliers"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/suppliers/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetSuppliers(int id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/suppliers/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/suppliers/5
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutSuppliers(int id, Suppliers suppliers)
        {
             
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(suppliers);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/suppliers/" + id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse.ToString();
                }
            }
       
        }
        #endregion

        // POST: api/suppliers
        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<IEnumerable>> PostSuppliers()
        {

            
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/suppliers/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
        }
        #endregion

        // DELETE: api/suppliers/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteCategory(long id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/suppliers/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(response.ReasonPhrase);
                }
            }
        }
        #endregion


    }


}
