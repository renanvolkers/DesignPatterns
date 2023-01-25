using FactoryMethod.Translator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FactoryMethod
{
    public class MinimalContextDb : DbContext
    {
        //The model is discovered by running a set of conventions over the entity classes found in the
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }


        public DbSet<PossessiveAdjective> PossessiveAdjectives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PossessiveAdjective>()
                .HasKey(p => p.Id);



            modelBuilder.Entity<PossessiveAdjective>()
                 .Property(p => p.WordId)
                 .IsRequired();

            modelBuilder.Entity<PossessiveAdjective>()
                .ToTable("PossessiveAdjective");


            base.OnModelCreating(modelBuilder);

        }
    }
}
