using Microsoft.AspNetCore.Mvc;
using Shop.EndPoint.Models;
using System.Diagnostics;

namespace Shop.EndPoint.Controllers
{
    public class HomeController : SiteBaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}