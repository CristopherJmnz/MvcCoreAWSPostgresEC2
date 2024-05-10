using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSPostgresEC2.Models;
using MvcCoreAWSPostgresEC2.Repositories;
using System.Diagnostics;

namespace MvcCoreAWSPostgresEC2.Controllers
{
    public class HomeController : Controller
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
