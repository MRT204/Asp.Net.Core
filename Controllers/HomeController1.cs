using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetCoreMVCLab03.Models;

namespace NetCoreMVCLab03.Controllers
{
    public class HomeController1 : Controller
    {
        protected Home home = new Home();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.authors = home.Authors;
            ViewBag.genres = HomeController1.Genres;
            var Homes = book.GetHomeList();
            return View(homes);
        }
        public ActionResult Create()
        {
            ViewBag.authors = home.Authors;
            ViewBag.genres = Home.Genres;
            Home model = new Home();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.authors = home.Authors;
            ViewBag.genres = Home.Genres;
            Home model = book.GetBookById(id);
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var home = home.GetHomeList(); 
            return PartialView(home);
        }
    }
}