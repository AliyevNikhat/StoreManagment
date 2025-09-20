namespace OnlineStore.Data
{
    public class OnlineStoreDBFactory : IDesignTimeDbContextFactory<OnlineStoreDB>
    {
        public OnlineStoreDB CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<OnlineStoreDB>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            return new OnlineStoreDB(optionsBuilder.Options);
        }
    }
}