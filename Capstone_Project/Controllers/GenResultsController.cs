using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Capstone_Project.Models;
using System.Net.Http;

namespace Capstone_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenResultsController : ControllerBase
    {
        // GET: api/GenResults
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GenResults/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        public async static Task<string> GetGenResults()
        {
            var guid = "ALMNH:ES";
            var catNum = 4;
            var url = "https://arctos.database.museum/SpecimenResultsJSON.cfm?" + "?guid_prefix=" + guid + "&catnum=" + catNum;
            using (var client = new HttpClient())
            {
                

            }
            var data = "";
            return data;
        }
        
    }

}
