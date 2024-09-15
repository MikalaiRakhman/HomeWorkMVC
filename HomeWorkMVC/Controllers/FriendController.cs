using HomeWorkMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HomeWorkMVC.Controllers
{
    public class FriendController : Controller
    {
	    private static List<Friend> _friends = new List<Friend>();
	    
	    public IActionResult Index() // /friends
        {
            return View();
        }

        public IActionResult Create()
        {
	        return View();
        }
        [HttpPost]
        public IActionResult Create(Friend friend)
        {
	        if (ModelState.IsValid)
	        {
                _friends.Add(friend);
	        }
            return View();
        }

        public IActionResult Edit()
        {
	        return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public string Hello()
        {
	        return "Hello";
        }

    }
}
