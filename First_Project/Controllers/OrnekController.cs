using Microsoft.AspNetCore.Mvc;

namespace First_Project.Controllers
{
    public class Ornek : Controller
    {
        public IActionResult ViewBagExample()
        {
            ViewBag.name = "Asp.NET ViewBag String";
            ViewBag.list = new List<string>() { "Orçun", "Ayşe", "Mehmet", "Ahmet" };
            
            return View();
        }
        public IActionResult TempDataExampleFrom()
        {
            ViewBag.name = "Ahmet";
            TempData["surname"] = "Yıldız";

            return View();
        }
        public IActionResult TempDataExampleTo() 
        {
            return View();
        }
        public class Product
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
        public IActionResult ViewModelExample()
        {
            var productList = new List<Product>()
            {
                new(){Id = 1,Name="A"},
                new(){Id = 2,Name="B"},
                new(){Id = 3,Name="C"}
            };
            return View(productList);
        }
    }
}
