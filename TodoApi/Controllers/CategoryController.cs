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
    public class CategoryController : ControllerBase
    #endregion
    {
        private readonly Categories _context;



        // GET: api/GetCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetCategories()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/categories"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/GetCategories/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetCategories(int id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/categories/"+ id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/PutCategory/5
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutCategory(long id, Categories categories)
        {
            
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(categories);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/categories/"+id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return response.ToString();
                }
            }
       
        }
        #endregion

        // POST: api/PostCategory

        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostCategory()
        {

            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/categories/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
        }
        #endregion

        // DELETE: api/DeleteCategory/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteCategory(long id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/categories/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return response.ReasonPhrase;
                }
            }
        }
        #endregion


    }


}
