using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "STEP #1",
                    Description =
                        "RECEIVE 3 DOCUMENTS BACK - UCC1 Birth Certificate, Social Security Card accepted for value stamp, copy of Treasury Department Interest account",
                    Price = 600,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Type = "STEP1",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "STEP #2",
                    Description =
                     "Get your Security Agreement done",
                    Price = 250,
                    PictureUrl = "/images/products/sb-ang2.png",
                    Type = "Consumer Freedoms",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "STEP #3",
                    Description =
                        "Gain complete access to your riches NOTE: Security Agreement as well as UCC1 is required prior to purchasing this service. Or, Full Service option",
                    Price = 250,
                    PictureUrl = "/images/products/sb-core1.png",
                    Type = "Consumer Freedoms",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Full Process",
                    Description = "Whole process done for you, including Secured Party Creditor to your Strawman, Security Agreement, etc",
                    Price = 995,
                    PictureUrl = "/images/products/sbcore-core1.png",
                    Type = "Complete Freedom",
                    QuantityInStock = 100
                },
                 new Product
                {
                    Name = "CUSIP",
                    Description = "Get your CUSIP",
                    Price = 399,
                    PictureUrl = "/images/products/sbcore-core1.png",
                    Type = "Find your Account Number",
                    QuantityInStock = 100
                }
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}