using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    [AllowAnonymous]
    public class ChartController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Index2()
        {
            return View();
        }
        
        public IActionResult Statistics()
        {
            Context c = new Context();
            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;

            var foid = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            ViewBag.d = foid;

            var deger3 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(z => z.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d3= deger3;


            var deger4 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(z => z.CategoryName == "Vegatables").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d4 = deger4;

            var deger5 = c.Foods.Sum(x => x.Stock);
            ViewBag.d5 = deger5;


            var deger6 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(z => z.CategoryName == "Lagumes").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;

            return View();
        }

       
        public IActionResult VisualizeProductResult()
        {
            return Json(FoodList());
        }
     
        public List<Chart> FoodList()
        {
            List<Chart> chrt = new List<Chart>();

            using(var c = new Context())
            {
                chrt = c.Foods.Select(x => new Chart
                {
                    foodname = x.Name,
                    stock = x.Stock
                }).ToList();
            }
            return chrt;
        }
    }
}
