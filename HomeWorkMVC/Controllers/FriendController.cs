﻿using Microsoft.AspNetCore.Mvc;

namespace HomeWorkMVC.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index() // /friends
        {
            return View();
        }

        public IActionResult Create()
        {
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

    }
}
