using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopProject_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject_1.Controllers
{ 
    public class HomeController : Controller
    {
        GameContext db;
        public HomeController(GameContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Games.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }
    }
}