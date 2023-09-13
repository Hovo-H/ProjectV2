using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public class MyShopDataContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public MyShopDataContext(DbContextOptions<MyShopDataContext> options) : base(options)
        {

        }
    }
}
