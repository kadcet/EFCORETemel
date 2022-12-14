using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreIntroduction
{
    public class NorthwindDbContext:DbContext
    {
        //public NorthwindDbContext(DbContextOptions opt):base(opt)
        //{
        //    dbcontextoptions ı opt ismiyle parametre alalım. bana bir dbcontextoptions verilsin bende base ye göndereyim

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=.;Database=Northwnd;Integrated Security=True");//windows auth
            optionsBuilder.UseSqlServer("Server=.;Database=Northwnd;User Id=sa;Password=123456!a");//Sql Server auth
        }

        public DbSet<Product> Products { get; set; }

        
    }
}





// Northwind database sini bir şekilde işaret edebilmeliyim. Bu class onun için.
// ben istiyorum NorthwindDbContext im Northwind veritabanını temsil etsin. Veritabanımın içerisinde tablolar var.
// Bu tablolardan sadece Products tablosunu mapp lemek isiyorum. Bunun için buraya bir property yazmalıyım
// buraya ürün listesi ürün koleksiyonu gibi bir tip vermeliyim. Bunu Collection olarak vermiycez. DbSet olarak tanımlıycaz.

//public NorthwindDbContext(DbContextOptions opt):base(opt)
//{
//    dbcontextoptions ı opt ismiyle parametre alalım. bana bir dbcontextoptions verilsin bende base ye göndereyim

//}

