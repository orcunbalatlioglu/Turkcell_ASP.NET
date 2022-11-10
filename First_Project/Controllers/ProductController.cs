using First_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;
        public ProductController() { 
            _productRepository = new ProductRepository();
        }
        public IActionResult ProductPage()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            _productRepository.Remove(id);
            return RedirectToAction("ProductPage");
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}
