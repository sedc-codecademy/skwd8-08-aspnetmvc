using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Class02.App.Models;

namespace SEDC.AspNet.Class02.App.Controllers
{
    //[Route("[controller]/[action]")]
    [Route("post-sedc")]
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // httpverbs GET,POST,PUT,DELETE,PATCH,OPTION
            return View();
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(TestModel request)
        {
            return Json(request);
        }

        [HttpGet("read-post/{id:int}")]
        //[Route("read-post/{id:int}")]
        public IActionResult ReadPostById(int id)
        {
            var testModel = new
            {
                Name = "Trajan",
                Id = id
            };
            return Json(testModel);
        }

        [HttpGet("read-post/{id:alpha}")]
        //[Route("read-post/{id:alpha}")]
        public IActionResult ReadPostByName(string id)
        {
            var testModel = new
            {
                Name = "Trajan_NamePost",
                Id = id
            };
            return Json(testModel);
        }
    }
}


// Order controler
// 2 actions
// get order by id - integer
// get order by id - string
// conventional routing
// atribute routing
