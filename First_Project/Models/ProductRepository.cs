using First_Project.Models;

namespace First_Project.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product> {
            new() { Id = 1, Name = "Kalem 1", Price = 1, Stock = 100 },
            new() { Id = 2, Name = "Kalem 2", Price = 2, Stock = 200 },
            new () { Id = 3, Name = "Kalem 3", Price = 3, Stock = 300 },
            new() { Id = 4, Name = "Kalem 4", Price = 4, Stock = 400 }
        };
        public List<Product> GetAll() => _products;
        public void Add(Product newProduct) => _products.Add(newProduct);
        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == id);

            if (hasProduct == null)
                throw new Exception($"Bu id({id})'ye sahip ürün bulunmamaktadır.");
            _products.Remove(hasProduct);
        }
        public void Update(Product product)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == product.Id);

            if (hasProduct == null)
                throw new Exception($"Bu id({product.Id})'ye sahip ürün bulunmamaktadır.");
            
            hasProduct.Id = product.Id;
            hasProduct.Name = product.Name;
            hasProduct.Stock = product.Stock;

            var index = _products.IndexOf(hasProduct);

            _products[index] = hasProduct;

        }

        
    }
}
