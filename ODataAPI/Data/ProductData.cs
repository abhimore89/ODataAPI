using ODataAPI.Models;
using System;
using System.Collections.Generic;

namespace ODataAPI.Data
{
    public static class ProductData
    {
        private static Product p1 = new Product()
        {
            Id = 1,
            Name = "Bread",
            Category = "Food",
            Description = "Britannia Bread (450 gms)",
            Slug = "britannia-bread-450gms",
            Reviews = new List<ProductReview>()
            {
                new ProductReview()
                {
                    Id = 1,
                    CreatedOn = DateTime.Now,
                    Description = "this is a good product",
                    EmailId = "test@test.com",
                    Title = "ok ok",
                    //Product = p1
                }
            }
        };

        private static Product p2 = new Product()
        {
            Id = 2,
            Name = "Echo Dot",
            Category = "Electronics",
            Description = "Echo Dot 3rd Gen",
            Slug = "echo-dot-3rdgen",
            Reviews = new List<ProductReview>()
            {
                new ProductReview()
                {
                    Id = 2,
                    CreatedOn = DateTime.Now,
                    Description = "this is a good product",
                    EmailId = "test@test.com",
                    Title = "ok ok",
                    // Product = p1
                }
            }

        };
        private static Product p3 = new Product()
        {
            Id = 3,
            Name = "Echo",
            Category = "Electronics",
            Description = "Echo 4th Gen, 2020 release, Premium sound powered by Dolby and Alexa(white)",
            Slug = "echo-4thgen",
            Reviews = new List<ProductReview>()
            {
                new ProductReview()
                {
                    Id = 3,
                    CreatedOn = DateTime.Now,
                    Description = "this is a good product",
                    EmailId = "test@test.com",
                    Title = "ok ok",
                    //Product = p1
                }
            }

        };
        public static List<Product> products = new List<Product>()
        {
            p1,p2,p3
            
        };


    }
}
