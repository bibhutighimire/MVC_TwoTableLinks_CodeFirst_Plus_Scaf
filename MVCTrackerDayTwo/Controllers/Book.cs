using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDAYTWO.Models;

namespace MVCTrackerDayTwo.Controllers
{
    public class Book : Controller
    {
        LibraryContext context = new LibraryContext();
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View(context.Books.ToList());
        }

    }
}
