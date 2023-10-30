using PluginsConvention.Plugins;

namespace PluginsConvention
{
    public class ConventionElement : PluginsConventionElement
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Ganre { get; set; } = string.Empty;
        public int? Price { get; set; }
        public string PriceToString
        {
            set
            {
            }
            get
            {
                if (Price == null) return "Бесплатная";
                else return Price.ToString();
            }
        }
    }
}
