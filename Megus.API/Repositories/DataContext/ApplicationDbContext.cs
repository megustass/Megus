using Megus.API.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace Megus.API.Repositories.DataContext
{
    /// <inheritdoc />
    /// <summary>
    /// The database representational model for our application.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> User { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<ImageTypeEntity> ImageType { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductStatusEntity> ProductStatus { get; set; }
        public DbSet<SizeEntity> Size { get; set; }
        public DbSet<ProductSizeEntity> ProductSize { get; set; }

        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
