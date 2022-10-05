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
    public class EmployessController : ControllerBase
    #endregion
    {
        private readonly Employess _context;



        // GET: api/GetEmployess
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetEmployess()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/employess"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
        }

        // GET: api/GetEmployess/5
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetEmployess(int id)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://northwind.now.sh/api/employess/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse;
                }
            }
            
        }
        #endregion

        // PUT: api/PutEmployess/5

        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable>> PutEmployess(int id, Employess employess)
        {
             
            using (var httpClient = new HttpClient())
            {   
                var abc = JsonConvert.SerializeObject(employess);
                StringContent content = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://northwind.now.sh/api/employess/" + id, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return apiResponse.ToString();
                }
            }
       
        }
        #endregion

        // POST: api/PostEmployess

        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<IEnumerable>> PostEmployess()
        {

            
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://northwind.now.sh/api/employess/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
        }
        #endregion

        // DELETE: api/DeleteEmployess/5
        #region snippet_Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable>> DeleteEmployess(int id)
        {
            using (var httpClient = new HttpClient())
            {
        

                using (var response = await httpClient.DeleteAsync("https://northwind.now.sh/api/employess/" + id))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(response.ReasonPhrase);
                }
            }
        }
        #endregion


    }


}
