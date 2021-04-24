using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using web_Приложение.Models;

namespace web_Приложение.Context
{
    public class Initializer : CreateDatabaseIfNotExists<AnimalContext>
    {
        AnimalContext context = new AnimalContext();
        protected override void Seed(AnimalContext context)
        {
            var animal1 = new Animal()
            {
                Name = "Тигр",
                Wilds = new List<WildAnimal>()
                {
                    new WildAnimal()
                    {
                        Type = "Дикий животный"
                    }
                }
            };

            var animal2 = new Animal()
            {
                Name = "Кошка",
                Pets = new List<PetsAnimal>()
                {
                    new PetsAnimal()
                    {
                        Type = "Домашний животный"
                    }
                }
            };

            var animal3 = new Animal()
            {
                Name = "Собака",
                Pets = new List<PetsAnimal>()
                {
                    new PetsAnimal()
                    {
                        Type = "Домашний животный"
                    }
                }
            };
            var animal4 = new Animal()
            {
                Name = "Лощадь",
                Pets = new List<PetsAnimal>()
                {
                    new PetsAnimal()
                    {
                        Type = "Домашний животный"
                    }
                }
            };

            var animal5 = new Animal()
            {
                Name = "Буйвол",
                Wilds = new List<WildAnimal>()
                {
                    new WildAnimal()
                    {
                        Type = "Дикий животный"
                    }
                }
            };
            var animal6 = new Animal()
            {
                Name = "Слон",
                Wilds = new List<WildAnimal>()
                {
                    new WildAnimal()
                    {
                        Type = "Дикий животный"
                    }
                }
            };
            var animal7 = new Animal()
            {
                Name = "Ягуар",
                Wilds = new List<WildAnimal>()
                {
                    new WildAnimal()
                    {
                        Type = "Дикий животный"
                    }
                }
            };
            context.Animals.AddRange(new List<Animal>() { animal1, animal2, animal3, animal4, animal5, animal6, animal7 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}