
namespace WebApplication7.DAL
{
    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        public ApplicationDbContext() : base("server=.\\sqlexpress;database=eShopMvc;user id=sa;password=1234")
        {
        }
        System.Data.Entity.DbSet<Models.User> Users { get; set; }
        System.Data.Entity.DbSet<Models.Cart> Carts { get; set; }
        System.Data.Entity.DbSet<Models.Orders> Orders { get; set; }
    }
}