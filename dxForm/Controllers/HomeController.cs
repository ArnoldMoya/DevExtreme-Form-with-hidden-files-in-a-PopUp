using dxForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dxForm.Controllers
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
            return View(SampleData.Orders);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post(Order order)
        {
            //USE A BREAKPOINT HERE TO SEE
            //VALUE OF order 
            return View("Index");
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