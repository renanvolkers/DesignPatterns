﻿using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Exemple_2
{
    public class MinimalContextDb :DbContext
    {
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
        
        }
    }
}
