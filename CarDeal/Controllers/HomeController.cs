using Microsoft.AspNetCore.Mvc;

namespace CarDeal.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}