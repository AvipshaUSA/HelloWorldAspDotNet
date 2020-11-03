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
        [HttpGet]
           
            public IActionResult Index()
            {


            return View(); // all the code moved to hello folder's index.cshtml file.

            }

        //------------------------------------------------------------------------------
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        [Route("helloworld/welcome/{name?}")] // helloworls/welcome 
        public IActionResult Welcome(string name = "WORLD")
        {
            return Content("<h1> Welcome to my App, " + name + " !!!<h1>", "text/html");
        }

        
        [HttpPost] // helloworld
    
        public IActionResult CreateMessage(string name = "world", string language = "language")
        {
            if (language == "1")
            {
                language = "Namaste";
            }else if(language == "2")
            {
                language = "Hello";
            }else if (language == "3")
            {
                language = "Bonjour";
            }
            else if (language == "4")
            {
                language = "Kon'nichiwa";
            }
            else if (language == "5")
            {
                language = "Hola";
            }
            return Content("<h1> " + language+ " " + name + " !!!<h1>", "text/html");
            
        }

    }
}
