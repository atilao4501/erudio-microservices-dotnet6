using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Model.Context
{
    public class MySqlContext : DbContext
    {
        private readonly IConfiguration _configuration; 

        public MySqlContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public MySqlContext(DbContextOptions<MySqlContext> options, IConfiguration configuration) : base(options) {

        //    _configuration = configuration;
        //} 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8,3,0)));
        }

        public DbSet<Product> Products { get; set; }

        
    }
}
