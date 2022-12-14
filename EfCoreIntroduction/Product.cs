using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreIntroduction
{
    // Property deki isimler Sql de kolon adları ile aynı olmalı
    // Ben bu sınıfı SQL deki Products ile mapp lemiyorum. Ben bu sınıfı Products tablosundaki tek bir satır kayıt ile mapp lıyorum

    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string? QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }
    }
}

// SQL C# veri türleri karşılıları
// https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
