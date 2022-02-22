using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct)
                productCollection.InsertManyAsync(GetMyProducts());

        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "j9ioSGWf12PfpETwba5darlQ",
                    Name = "IPhone 13",
                    Category = "SmartPhone",
                    Description = "Descrição do IPhone",
                    Image = "product-1.png",
                    Price = 8899.99m
                },
                  new Product()
                {
                    Id = "QAMLmwo118E12uLwNO3MnZs2",
                    Name = "Samsumg s21",
                    Category = "SmartPhone",
                    Description = "Descrição do Samsumg",
                    Image = "product-2.png",
                    Price = 6999.00m
                },
                  new Product()
                {
                    Id = "KgyhCzTaHYBWpbaWPSkpbMEn",
                    Name = "Playstation 5",
                    Category = "Games",
                    Description = "Descrição do Play 5",
                    Image = "product-3.png",
                    Price = 3899.99M
                },
            };

        }
    }
}
