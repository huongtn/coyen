﻿using DoChoiThongMinh.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoChoiThongMinh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using(var db= new CoyenContext())
            {
                var rcs = db.Products.Where(x => x.Categories == "Xe đồ chơi").ToList();
                var camps = db.Products.Where(x => x.Categories == "Lều").ToList();
                var others = db.Products.Where(x => x.Categories == "Khác").ToList();
                var topStars = db.Products.Where(x => x.Star>=4).ToList();
                var topSells = db.Products.Where(x => x.Discount>0 && x.Discount<x.Cost).ToList();
                var news = db.Products.Where(x => x.IsNew == true).ToList();
                var top3s = db.Products.Where(x => x.Top3 == true).ToList();
                //var categories = db.Categories.ToList();
                ProductListViewModel productListViewModel = new ProductListViewModel()
                {
                    camps = camps,
                    rcs = rcs,
                    others = others,
                    topStars = topStars,
                    topSells = topSells,
                    news = news,
                    top3s = top3s
                }; 
                //ISession["Cart"] = new List<CartViewModel>();
                return View(productListViewModel);
            }
          
        }
        public IActionResult SingleProduct(int id)
        {
            using (var db = new CoyenContext())
            {
                var product = db.Products.FirstOrDefault(x => x.Id == id);
                return View(product);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}