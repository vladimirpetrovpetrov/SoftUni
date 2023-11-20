using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop;

public class StartUp
{
    public static void Main()
    {
        ProductShopContext context = new();
        //1
        //string usersXml = File.ReadAllText("../../../Datasets/users.xml");
        //Console.WriteLine(ImportUsers(context, usersXml));
        //2
        //string productsXml = File.ReadAllText("../../../Datasets/products.xml");
        //Console.WriteLine(ImportProducts(context, productsXml));
        //3
        //string categoriesXml = File.ReadAllText("../../../Datasets/categories.xml");
        //Console.WriteLine(ImportCategories(context, categoriesXml));
        //4
        //string catProdXml = File.ReadAllText("../../../Datasets/categories-products.xml");
        //Console.WriteLine(ImportCategoryProducts(context, catProdXml));
        //5
        //Console.WriteLine(GetProductsInRange(context));
        //6
        //Console.WriteLine(GetSoldProducts(context));
        //7
        //Console.WriteLine(GetCategoriesByProductsCount(context));
        //8
        Console.WriteLine(GetUsersWithProducts(context));
    }
    private static Mapper GetMapper()
    {
        var cfg = new MapperConfiguration(c => c.AddProfile<ProductShopProfile>());
        return new Mapper(cfg);
    }
    //8
    public static string GetUsersWithProducts(ProductShopContext context)
    {
        var users = context.Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(u => u.ProductsSold.Count)
                .Select(u => new UserHelperDto()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductHelper()
                    {
                        Count = u.ProductsSold.Count,
                        Products = u.ProductsSold.Select(p => new ProductNamePriceDTO()
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .OrderByDescending(p => p.Price)
                        .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

        var export = new UsersAndProductsDTO
        {
            Count = context.Users.Count(u => u.ProductsSold.Any()),
            Users = users
        };

        XmlSerializer serializer = new XmlSerializer(typeof(UsersAndProductsDTO),new XmlRootAttribute("Users"));

        var xns = new XmlSerializerNamespaces();
        xns.Add(string.Empty, string.Empty);

        var sb = new StringBuilder();

        using (StringWriter sw = new(sb))
        {
            serializer.Serialize(sw, export,xns);
        }

            return sb.ToString().Trim();
    }
//7
public static string GetCategoriesByProductsCount(ProductShopContext context)
{
    var categories = context.Categories
        .Select(c => new CategoriesFullDTO
        {
            Name = c.Name,
            Count = c.CategoryProducts.Count(),
            AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
            TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
        })
        .OrderByDescending(c => c.Count)
        .ThenBy(c => c.TotalRevenue)
        .ToArray();

    XmlSerializer serializer = new XmlSerializer(typeof(CategoriesFullDTO[]), new XmlRootAttribute("Categories"));

    var xns = new XmlSerializerNamespaces();
    xns.Add(string.Empty, string.Empty);

    StringBuilder sb = new StringBuilder();

    using (StringWriter sw = new StringWriter(sb))
    {
        serializer.Serialize(sw, categories, xns);
    }

    return sb.ToString().Trim();
}
//6
public static string GetSoldProducts(ProductShopContext context)
{
    var users = context.Users
        .Include(u => u.ProductsSold)
        .Where(u => u.ProductsSold.Count > 0)
        .OrderBy(u => u.LastName)
        .ThenBy(u => u.FirstName)
        .Take(5)
        .Select(u => new SoldProductsDTO
        {
            FirstName = u.FirstName,
            LastName = u.LastName,
            SoldProducts = u.ProductsSold.Select(sp => new ProductNamePriceDTO
            {
                Name = sp.Name,
                Price = sp.Price,
            })
            .ToArray()
        })
        .ToArray();
    XmlSerializer serializer = new XmlSerializer(typeof(SoldProductsDTO[]), new XmlRootAttribute("Users"));

    var xns = new XmlSerializerNamespaces();
    xns.Add(string.Empty, string.Empty);

    StringBuilder sb = new StringBuilder();
    using (StringWriter sw = new StringWriter(sb))
    {
        serializer.Serialize(sw, users, xns);
    }
    return sb.ToString().Trim();
}

//5
public static string GetProductsInRange(ProductShopContext context)
{
    var products = context.Products
        .Where(p => p.Price >= 500 && p.Price <= 1000)
        .OrderBy(p => p.Price)
        .Take(10)
        .Select(p => new ProductsInRangeDTO
        {
            Name = p.Name,
            Price = p.Price,
            BuyerName = p.Buyer.FirstName + " " + p.Buyer.LastName
        })
        .ToArray();

    XmlSerializer serializer = new XmlSerializer(typeof(ProductsInRangeDTO[]), new XmlRootAttribute("Products"));

    var xns = new XmlSerializerNamespaces();
    xns.Add(string.Empty, string.Empty);

    StringBuilder sb = new();

    using (StringWriter sw = new StringWriter(sb))
    {
        serializer.Serialize(sw, products, xns);
    }




    return sb.ToString().Trim();

}

//4
public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
{
    var categoriesIds = context.Categories
        .Select(c => c.Id)
        .ToList();

    var productsIds = context.Products
        .Select(c => c.Id)
        .ToList();

    XmlSerializer serializer = new XmlSerializer(typeof(CatProDTO[]), new XmlRootAttribute("CategoryProducts"));

    var catProDtos = (CatProDTO[])serializer.Deserialize(new StringReader(inputXml));

    Mapper mapper = GetMapper();

    CategoryProduct[] categoryProducts = mapper.Map<CategoryProduct[]>(catProDtos.Where(cpd => categoriesIds.Contains(cpd.CategoryId) && productsIds.Contains(cpd.ProductId)));

    context.AddRange(categoryProducts);
    context.SaveChanges();

    return $"Successfully imported {categoryProducts.Length}";
}

//3
public static string ImportCategories(ProductShopContext context, string inputXml)
{
    XmlSerializer serializer = new XmlSerializer(typeof(CategoryDTO[]), new XmlRootAttribute("Categories"));

    CategoryDTO[] catDtos = (CategoryDTO[])serializer.Deserialize(new StringReader(inputXml));

    var mapper = GetMapper();

    Category[] categories = mapper.Map<Category[]>(catDtos.Where(cd => cd.Name != null));

    context.AddRange(categories);
    context.SaveChanges();

    return $"Successfully imported {categories.Length}";
}
//2
public static string ImportProducts(ProductShopContext context, string inputXml)
{
    XmlSerializer serializer = new XmlSerializer(typeof(ProductDTO[]), new XmlRootAttribute("Products"));

    var userIds = context.Users
        .Select(x => x.Id)
        .ToList();

    ProductDTO[] productDTOs = (ProductDTO[])serializer.Deserialize(new StringReader(inputXml));


    var mapper = GetMapper();

    Product[] products = mapper.Map<Product[]>(productDTOs);



    context.AddRange(products);
    context.SaveChanges();

    return $"Successfully imported {products.Length}";
}
//1
public static string ImportUsers(ProductShopContext context, string inputXml)
{
    XmlSerializer serializer = new XmlSerializer(typeof(UsersDTO[]), new XmlRootAttribute("Users"));

    UsersDTO[] usersDtos = (UsersDTO[])serializer.Deserialize(new StringReader(inputXml));

    var mapper = GetMapper();
    User[] users = mapper.Map<User[]>(usersDtos);

    context.AddRange(users);
    context.SaveChanges();

    return $"Successfully imported {users.Length}";
}
}