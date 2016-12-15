using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testMvc.Models;
using testMvc.ViewModels;

namespace testMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "測試網站";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "測試網站";
          var model = new ProductListView();
           var products = new List<Product>();
           Product p1 = new Product();
           p1.Id = 1;
           p1.ProductName = "test1";
           Product p2 = new Product();
           p2.Id = 2;
           p2.ProductName = "test2";
           products.Add(p1);
           products.Add(p2);
           model.prdState = products;
            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
