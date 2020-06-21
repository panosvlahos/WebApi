using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;


namespace WebApplication.Controllers
{

    public class BLController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BLController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static async Task<Resources> GETResource(string lang)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44347/home/");
                //HTTP GET
                var responseTask = client.GetAsync("Resources");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    Resources resource = await result.Content.ReadAsAsync<Resources>();
                    //var readTask = result.Content.ReadAsAsync<]>();
                    //readTask.Wait();

                    //var students = readTask.Result;

                    //foreach (var student in students)
                    //{

                    //}

                    return resource;
                }



                Resources resources = new Resources();






                return resources;


            }

        }
    }
}


