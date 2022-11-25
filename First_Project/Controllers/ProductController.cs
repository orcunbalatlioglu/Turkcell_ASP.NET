using First_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_Project.Controllers
{
    
    public class ProductController : Controller
    {
        private AppDbContext _context;
        private readonly ProductRepository _productRepository;

        public ProductController(AppDbContext context) { 
            _productRepository = new ProductRepository();
            _context = context;
            if (!_context.Products.Any()) { 
                _context.Products.Add(new Product() { Name = "Kalem1", Price = 100, Stock = 3 ,Color="Red",Width=10,Height=20});
                _context.Products.Add(new Product() { Name = "Kalem2", Price = 200, Stock = 4 ,Color="Blue",Width=11});
                _context.Products.Add(new Product() { Name = "Kalem3", Price = 300, Stock = 5 ,Color="Yellow"});
                _context.Products.Add(new Product() { Name = "Kalem4", Price = 400, Stock = 6 });
                
                _context.SaveChanges();
            }
        }
        public IActionResult ProductPage()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            var _product = _context.Products.Find(id);
            _context.Products.Remove(_product);
            _context.SaveChanges();
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
