using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext context = new ProductShopContext();
            //var inputJson = File.ReadAllText("../../../Datasets\\users.json");
            //Console.WriteLine(ImportUsers(context, inputJson));
            //var productsJson = File.ReadAllText("../../../Datasets/products.json");
            //Console.WriteLine(ImportProducts(context,productsJson));
            //var categoriesJson = File.ReadAllText("../../../Datasets/categories.json");
            //Console.WriteLine(ImportCategories(context,categoriesJson));
            //var categoriesProductsJson = File.ReadAllText("../../../Datasets/categories-products.json");
            //Console.WriteLine(ImportCategoryProducts(context, categoriesProductsJson));
            //Console.WriteLine(GetProductsInRange(context));
            //Console.WriteLine(GetSoldProducts(context));
            //Console.WriteLine(GetCategoriesByProductsCount(context));
            Console.WriteLine(GetUsersWithProducts(context));
        }
        //8

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Count() > 0 && u.ProductsSold.Any(ps => ps.Buyer != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = u.ProductsSold
                        .Where(p => p.BuyerId != null)
                        .Select(ps => new
                        {
                            name = ps.Name,
                            price = ps.Price,
                        })
                })
                .OrderByDescending(u => u.soldProducts.Count())
                .ToList();

            var jsonPrep = new
            {
                usersCount = users.Count(),
                users = users.Select(u => new
                {
                    u.firstName,
                    u.lastName,
                    u.age,
                    soldProducts = new
                    {
                        count = u.soldProducts.Count(),
                        products = u.soldProducts
                    }
                }) 
            };

            var usersJson = JsonConvert.SerializeObject(jsonPrep, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            });
            return usersJson;
        }

        //7

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var cats = context.Categories
                .Select(c => new
                {
                   category = c.Name,
                   productsCount = c.CategoriesProducts.Count(),
                   averagePrice = $"{c.CategoriesProducts.Average(cp=>cp.Product.Price):f2}",
                   totalRevenue = $"{c.CategoriesProducts.Sum(cp=>cp.Product.Price):f2}"
                })
                .OrderByDescending(c => c.productsCount)
                .ToList();
            
            var catsJson = JsonConvert.SerializeObject(cats,Formatting.Indented);

            return catsJson;

        }

        //6

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(ps=> ps.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = p.Buyer.FirstName,
                            buyerLastName = p.Buyer.LastName
                        })
                })
                .ToList();

            var usersJson = JsonConvert.SerializeObject(users);

            return usersJson;

        }

        //5
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p=>p.Price>= 500 && p.Price <= 1000)
                .OrderBy(p=>p.Price)
                .Select(p=> new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .ToList();

            var productsJson = JsonConvert.SerializeObject(products, Formatting.Indented);
            return productsJson;
        }


        //Import

        //4
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var catPro = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);
            if (catPro != null)
            {
                context.CategoriesProducts.AddRange(catPro);
                context.SaveChanges();
                return $"Successfully imported {catPro.Length}";
            }
                return $"Successfully imported 0";




        }

        //3
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<Category[]>(inputJson);
            var categoriesToAdd = categories?
                .Where(c => c.Name is not null)
                .ToArray();
            if (categoriesToAdd is not null)
            {
                context.Categories.AddRange(categoriesToAdd);
                context.SaveChanges();
                return $"Successfully imported {categoriesToAdd.Length}";
            }
            return $"Successfully imported 0";

        }

        //2
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<Product[]>(inputJson);
            context.Products.AddRange(products);
            context.SaveChanges();
            return $"Successfully imported {products.Length}";
        }

        //1
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<User[]>(inputJson);
            context.Users.AddRange(users);
            context.SaveChanges();
            return $"Successfully imported {users.Length}";

        }
        //Import
    }
}