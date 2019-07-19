using System.Linq;
using shop.Models;

namespace shop
{
    public static class SampleData
    {
        public static void Initialize(ShopContext context)
        {
            if (!context.Product.Any())
            {
                context.Product.AddRange(
                    new Product
                    {
                        IdProduct = 1,
                        Name = "iPhone 6S",
                        Quantity = 100,
                        Price = 600,
                        TypeProduct=1,
                        Company = "Apple"

                    },
                    new Product
                    {
                        IdProduct = 2,
                        Name = "Samsung Galaxy Edge",
                        Quantity = 100,
                        Price = 550,
                        TypeProduct = 1,
                        Company = "Samsung"
                    },
                    new Product
                    {
                        IdProduct = 3,
                        Name = "Lumia 950",
                        Quantity = 100,
                        Price = 500,
                        TypeProduct = 1,
                        Company = "Microsoft"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}