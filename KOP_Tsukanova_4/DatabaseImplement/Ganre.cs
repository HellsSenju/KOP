using System.ComponentModel.DataAnnotations;

namespace DatabaseImplement
{
    public class Ganre
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
