using Microsoft.AspNetCore.Mvc;

namespace HomeWorkMVC.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index() // /friends
        {
            return View();
        }
    }
}
