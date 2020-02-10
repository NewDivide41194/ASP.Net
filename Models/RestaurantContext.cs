using Microsoft.EntityFrameworkCore;
namespace CoolApi.Models {
    public class RestaurantContext : DbContext {
        public RestaurantContext (DbContextOptions<RestaurantContext> options) : base (options) { }
        public DbSet<Role> tbl_role { get; set; }
        public DbSet<User> tbl_user { get; set; }

    }
}