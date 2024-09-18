using HomeWorkMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkMVC.Controllers
{
    public class FriendController : Controller
    {
        public static List<Friend> _friends = new List<Friend>()
        {
            new Friend{FriendID = 1, FriendName = "Vasia", Place = "Minsk"},
            new Friend{FriendID = 2, FriendName = "Petia", Place = "Lida" },
            new Friend{FriendID = 3, FriendName = "Katia", Place = "Warsaw" }
        };
	    
	    public IActionResult Index() 
        {
            return View(_friends);
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
                return RedirectToAction("Index");
            }
            return View(friend);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var friend = _friends.FirstOrDefault(f => f.FriendID == id);
            if (friend != null)
            {
                _friends.Remove(friend);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
	        return View();
        }        
    }
}
