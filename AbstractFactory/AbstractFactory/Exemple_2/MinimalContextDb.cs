using AbstractFactory.Exemple_2.Domain;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Exemple_2
{
    public class MinimalContextDb :DbContext
    {
        //The model is discovered by running a set of conventions over the entity classes found in the
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                 .Property(p => p.Name)
                 .IsRequired();

              modelBuilder.Entity<Product>()
                 .Property(p => p.Size)
                 .IsRequired();

modelBuilder.Entity<Product>()
                 .Property(p => p.Size)
                 .IsRequired();
modelBuilder.Entity<Product>()
                 .Property(p => p.Size)
                 .IsRequired();





        }
    }
}
