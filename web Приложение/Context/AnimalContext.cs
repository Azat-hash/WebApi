using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using web_Приложение.Models;

namespace web_Приложение
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<WildAnimal> Wilds { get; set; }
        public DbSet<PetsAnimal> Pets { get; set; }
    }
}