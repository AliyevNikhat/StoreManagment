namespace OnlineStore.Data
{
    public class OnlineStoreDB : DbContext
    {
        public OnlineStoreDB(DbContextOptions<OnlineStoreDB> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Electronic>().ToTable("Electronics");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Electronic> Electronics { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}