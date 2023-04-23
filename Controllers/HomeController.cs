using DoChoiThongMinh.Models;
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
                var topSells = db.Products.Where(x => x.IsTopSell ==true).ToList();
                var news = db.Products.Where(x => x.IsNew == true).ToList();
                //var categories = db.Categories.ToList();
                ProductListViewModel productListViewModel = new ProductListViewModel()
                {
                    camps = camps,
                    rcs = rcs,
                    others = others,
                    topStars = topStars,
                    topSells = topSells,
                    news = news
                };
                //List<ProductViewModel> products = new List<ProductViewModel>();
                return View(productListViewModel);
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