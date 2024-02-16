using Microsoft.EntityFrameworkCore;
using NETCorePortfolio_API.DAL.Entity;

namespace NETCorePortfolio_API.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0DTVQK3\\SQLEXPRESS;database=NETCorePortfolioDB2; integrated security=true;");
        }

        public DbSet<Category> Categories{ get; set; }
    }
}
