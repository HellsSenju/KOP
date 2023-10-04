using System.ComponentModel;

namespace Contracts.Book
{
    public class BookViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Название")]
        public string Title { get; set; } = string.Empty;
        [DisplayName("Описание")]
        public string Description { get; set; } = string.Empty;
        [DisplayName("Жанр")]
        public string Ganre { get; set; } = string.Empty;
        [DisplayName("Цена")]
        public int? Price { get; set; }
    }
}
