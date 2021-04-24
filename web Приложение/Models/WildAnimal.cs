namespace web_Приложение.Models
{
    public class WildAnimal
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Тип живоного
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Ссылка на класс
        /// </summary>
        public Animal Animal { get; set; }
    }
}