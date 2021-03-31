using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    [Route("")]
    //[Route("home")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        //[Route("index")]
        [Route("[action]")]
        public String Index()
        {
            return "Hello from home";
        }

        //[Route("about")]
        [Route("[action]")]
        public String About()
        {
            return "Hello from About";
        }
    }
}
