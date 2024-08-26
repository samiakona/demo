using Microsoft.AspNetCore.Mvc;

namespace purchase.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
