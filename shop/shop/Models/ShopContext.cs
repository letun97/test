using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace shop.Models
{
    public class ShopContext : DbContext
    {
       // public DbSet<History> History { get; set; }
        public DbSet<Product> Product { get; set; }

        //проверка: если базы данных данных нет, то создается база данных
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
