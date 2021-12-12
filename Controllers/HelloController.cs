
using Microsoft.AspNetCore.Mvc;

namespace taskManager.Controllers
{
    public class HelloController : Controller
    {
        public HelloController()
        {
            //I'm the constructor        
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Content(": HelloController : Hello there");
        }

    }
}