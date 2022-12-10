using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models.Account;

namespace Shop.InfraData.Context
{
    public class ShopDbContext:DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options):base(options)
        {

        }
        #region User
        public DbSet<User> Users { set; get; }
        #endregion
    }
}
