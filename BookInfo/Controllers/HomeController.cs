using BookInfo.DAL;
using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            BookInfoContext db = new BookInfoContext();
            var books = from b in db.Books
                         select b;
            return View(books);
        }
    }
}