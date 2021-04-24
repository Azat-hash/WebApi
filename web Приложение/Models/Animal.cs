using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Приложение.Models
{
    public class Animal
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название животного
        /// </summary>
        public string Name { get; set; }
     
        public ICollection<WildAnimal> Wilds { get; set; }
        public ICollection<PetsAnimal> Pets { get; set; }
    }
}