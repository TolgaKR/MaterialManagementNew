using MaterialManagement.Data.Abstract;
using MaterialManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaterialManagement.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IMalzemeDal _malzemeDal;

        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger/*IMalzemeDal malzemeDal*/)
        {
            // _malzemeDal = malzemeDal;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var malzeme = _malzemeDal.List();
            //var a = 7;
            var b = 8; 
            
            var c= 9;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
