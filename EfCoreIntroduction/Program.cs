// See https://aka.ms/new-console-template for more information
using EfCoreIntroduction;

Console.WriteLine("Program Başladı");
Console.WriteLine("Ürün Listesi");
Console.WriteLine("---------------------------------------");

NorthwindDbContext northwindDbContext = new NorthwindDbContext();

// Products.ToList() dedim çünkü.Demezsem products a başvurduğum zaman o anda bana canlı canlı veritabanına
//  bağlanıp dataları getirmeye çalışır ve connection açık kalır foreach bitinceye kadar.
//  sonuna tolist demezsem var product dbset oluyor. ToList yazarsam ;
// git Products ları getir onu bir generic list e dönüştür ve bu generic list i product ın içine koy.
// tip List<Product> oldu. ToList koymazsam DbSet<Product> olur.
var products = northwindDbContext.Products.ToList();
Console.WriteLine($"Product Id\tProductName\tProduct Price");
Console.WriteLine($"----------\t-----------\t-------------");

foreach (Product p in products)
{
    Console.WriteLine($"{p.ProductID}\t{p.ProductName}\t{p.UnitPrice}");
}

Console.ReadLine();

