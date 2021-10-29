using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ODataAPI.Models;

namespace ODataAPI.Data
{
    public class ProductContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions options) : base(options)
        {
            LoadProducts();

        }

        public void LoadProducts()
        {
            Products.AddRange(ProductData.products);
        }


        public List<Product> GetProducts()
        {
            return Products.Local.ToList<Product>();
        }

        public List<ProductReview> GetProductReviews()
        {
            return Products.Local.ToList<Product>().SelectMany(s => s.Reviews).ToList();
        }


        public Product AddProduct(Product product)
        {
            Products.Add(product);
            return product;
        }

        public void UpdateProduct(Product product, int Id)
        {
            Products.Update(product);
        }

        public bool ArchiveProduct(int Id)
        {
            var product = GetProduct(Id);
            if(product != null)
            {
                Products.Remove(product);
                return true;
            }

            return false;
        }

        public Product GetProduct(int Id)
        {
            return Products.Local.Where(s => s.Id == Id).FirstOrDefault();
        }


    }
}
