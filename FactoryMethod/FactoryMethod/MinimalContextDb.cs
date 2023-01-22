using Microsoft.EntityFrameworkCore;

namespace FactoryMethod
{
    public class MinimalContextDb : DbContext
    {
        //The model is discovered by running a set of conventions over the entity classes found in the
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }


        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);


            modelBuilder.Entity<Product>()
                 .Property(p => p.Name)
                 .IsRequired();

            modelBuilder.Entity<Product>()
                .ToTable("Product");
            base.OnModelCreating(modelBuilder);

        }
    }
}
