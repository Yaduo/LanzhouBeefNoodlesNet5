using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;

        public HomeController(INoodleRepository noodleRepository, IFeedbackRepository feedbackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            var viewModle = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList()
            };
            return View(viewModle);
        }

        public String About()
        {
            return "Hello from About";
        }

        public IActionResult Detail(int id)
        {
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
