namespace shop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "rubiks",
                        Description = "987654321",
                        ImageUrl = "https://cattalesinc.org/wp-content/uploads/slider2/DSC_0029-2048x1360.jpeg",
                        Price = 10.0m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "kubiks",
                        Description = "123456789",
                        ImageUrl = "https://cattalesinc.org/wp-content/uploads/slider2/DSC_0029-2048x1360.jpeg",
                        Price = 100.0m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "rubiks kubiks",
                        Description = "147852369",
                        ImageUrl = "https://cattalesinc.org/wp-content/uploads/slider2/DSC_0029-2048x1360.jpeg",
                        Price = 75.0m
                    }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
