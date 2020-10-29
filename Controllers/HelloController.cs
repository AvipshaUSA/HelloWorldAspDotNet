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
            //[Route("/helloworld")]
            public IActionResult Index()
            {
            string html = "<h1> Hello World!!!</h1>" + "<form method = 'POST' action = '/helloworld/'>" + " <input type = 'text' name = 'name'>" +
            "    <input type = 'submit' value= 'greet Me!'  />" + "        <select name ='language'><option value = '1'>Indian<option value ='2'>English<option value ='3'>French <option value = '4'> Japanees <option value = '5'> Spanish" +
          "</form>";
                   
                
                return Content(html, "text/html");

            }
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        [Route("helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "WORLD")
        {
            return Content("<h1> Welcome to my App, " + name + " !!!<h1>", "text/html");
        }

        // [HttpGet]
        // [Route("helloworld/welcome/{name?}")]
        //[HttpGet("message/{name?}")]
        [HttpPost]
      // [Route("/helloworld/")]
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
