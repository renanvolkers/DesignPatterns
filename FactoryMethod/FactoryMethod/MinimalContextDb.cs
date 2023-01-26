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

            modelBuilder.Entity<Word>()
                .HasKey(p => p.Id);



            modelBuilder.Entity<Word>()
                 .Property(p => p.Name)
                 .IsRequired();

            modelBuilder.Entity<Word>()
                 .Property(p => p.Type)
                 .IsRequired();


            modelBuilder.Entity<Word>()
                .ToTable("Word");



            modelBuilder.Entity<Word>()
                .HasKey(p => p.Id);



            modelBuilder.Entity<PromonounsObject>()
                 .Property(p => p.Id)
                 .IsRequired();

            modelBuilder.Entity<PromonounsObject>()
                 .Property(p => p.WordId)
                 .IsRequired();


            modelBuilder.Entity<PromonounsObject>()
                .ToTable("PromonounsObject");


            base.OnModelCreating(modelBuilder);

        }
    }
}
