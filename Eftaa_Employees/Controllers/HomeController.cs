using Microsoft.AspNetCore.Mvc;

namespace Eftaa_Employees.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 


        }
    }
}
