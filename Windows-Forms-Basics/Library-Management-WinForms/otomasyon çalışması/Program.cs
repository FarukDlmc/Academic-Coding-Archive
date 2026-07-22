using Microsoft.EntityFrameworkCore;
namespace otomasyon_çalışması
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
     public class ECommerceDbContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Customer> Customers { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=YourDatabaseName;Trusted_Connection=True;");
            }
        }
       //entitiy
       public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public float Price { get; set; }
        }
        //entitiy
        public class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
    }
}