using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class HomeController : Controller
    { 
        BookContext db = new BookContext();  // создание контекста данных

        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books; // получение всех обїектов Book  из бд

            ViewBag.Books = books; // передаем все объекты в динамическое свойство Books в ViewBag

            return View(); // возрващение представления
        }

        


    }
}
