using System.ComponentModel;

namespace Contracts.Ganre
{
    public class GanreViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; } = string.Empty;
    }
}
