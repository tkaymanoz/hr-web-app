using Microsoft.AspNetCore.Mvc;

namespace PeopleFit.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}