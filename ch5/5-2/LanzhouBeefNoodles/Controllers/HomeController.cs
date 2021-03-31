using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;

        public HomeController(INoodleRepository noodleRepository)
        {
            _noodleRepository = noodleRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var noodels = _noodleRepository.GetAllNoodles();
            return View(noodels);
        }

        public String About()
        {
            return "Hello from About";
        }
    }
}
