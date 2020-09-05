using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SEDC.PizzaApp.v1.Controllers
{
    //[Route("App/[Action]")]
    //[Route("App")]
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index() //https://localhost:5001/home/index
        {
            return View();
        }

        [HttpGet]
        //[Route("Start")]
        public IActionResult Contact() //https://localhost:5001/home/contact
        {
            return View();
        }

        //[HttpGet("Callme")]
        public IActionResult About() //https://localhost:5001/home/about
        {
            return View();
        }

        //view result
        public IActionResult Test() //https://localhost:5001/home/test
        {
            return View("Contact");
        }

        //empty result
        public IActionResult Alert() //https://localhost:5001/home/alert
        {
            return new EmptyResult(); 
        }

        //redirect reuslt
        public IActionResult Order(int? id)  
        {
            if(id.HasValue) 
            {
                return View("Contact"); //https://localhost:5001/home/order/5
            }

            return new RedirectResult("Index"); //https://localhost:5001/home/order
        }

        //json result
        public IActionResult OrderData()  //https://localhost:5001/home/orderdata
        {
            var order = new { Id = 12, Delivery = false }; 
            return new JsonResult(order);
        }

        //retieve data from appsettins.json
        public IActionResult GetEmails() 
        {
            var contactEmail = Configuration.GetSection("emailAdresses").GetValue<string>("email1");
            var customerSuportEmail = Configuration.GetSection("emailAdresses").GetValue<string>("email2");

            var emails = new { email1 = contactEmail, email2 = customerSuportEmail };

            return new JsonResult(emails);        
        }

    }
}
