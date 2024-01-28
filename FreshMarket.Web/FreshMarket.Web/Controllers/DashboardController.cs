using Microsoft.AspNetCore.Mvc;

namespace FreshMarket.Web.Controllers
{
    public class DashboardController : Controller
    {
        public DashboardController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
