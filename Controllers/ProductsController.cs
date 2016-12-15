using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testMvc.Models;
using testMvc.ViewModels;


namespace testMvc.Controllers
{
    public class ProductsController : Controller
    {

        [RouteAttribute("Products")]
        public IActionResult Index()
        {
            ViewData["Title"] = "測試產品網站";
            return View();
        }

        [RouteAttribute("Products/Create")]
        public IActionResult Create(){
            ViewData["Title"] = "測試產品新增";
            return View();
            
        }

        [HttpPostAttribute("Products/Create")]
        public IActionResult CreateProduct(){
            ViewData["Title"] = "測試產品新增";
            return View();
            
        }


    }
}