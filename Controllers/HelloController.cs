using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAspDotNet.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //[HttpGet]
           
            public IActionResult Index()
            {

            ViewBag.vegitable = "Rutabaga"; // it is going to call iside view's hello folder's index.cshtml
            ViewBag.name = "Cabinet";
            ViewBag.price = "$200";
            List<string> newList = new List<string>();
            
           
            newList.Add("French roast");
            newList.Add("Espresso");
            newList.Add("Kopi Luwak");
            ViewBag.newList = newList;
            
            return View(); // all the code moved to hello folder's index.cshtml file.

            }

        //------------------------------------------------------------------------------
        // [HttpGet("welcome/{name?}")]
        //[HttpPost]
        //[Route("/helloworld/")]
        //public IActionResult Welcome(string name = "WORLD")           // can not post 2 methods( welcome() & createmessage() ) in same route [Route("/helloworld/")], 
                                                                         //so i need to comment out either one. here i comment out welcome().
        //{
        //    ViewBag.person = name;
        //    return View();
        //}


        [HttpPost] // helloworld
        [Route("/helloworld/")]
        public IActionResult CreateMessage(string name = "world", string language = "language")
        {
            ViewBag.person = name;
            ViewBag.language = language;
            //if (language == "1")
            //{
            //    language = "Namaste";
            //}
            //else if (language == "2")
            //{
            //    language = "Hello";
            //}
            //else if (language == "3")
            //{
            //    language = "Bonjour";
            //}
            //else if (language == "4")
            //{
            //    language = "Kon'nichiwa";
            //}
            //else if (language == "5")
            //{
            //    language = "Hola";
            //}
            //return Content("<h1> " + language + " " + name + " !!!<h1>", "text/html");
            return View();

        }

    }
}
