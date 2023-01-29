using FactoryMethod.Translator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FactoryMethod
{
    public class MinimalContextDb : DbContext
    {
        //The model is discovered by running a set of conventions over the entity classes found in the
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

      

            base.OnModelCreating(modelBuilder);

        }
    }
}
