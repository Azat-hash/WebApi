namespace web_Приложение.Models
{
    public class PetsAnimal
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Тип животного
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Ссылка на класс
        /// </summary>
        public Animal Animal { get; set; }
    }
}