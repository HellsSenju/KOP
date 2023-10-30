using PluginsConvention.Plugins;

namespace Plugins
{
    public class ConventionElement : PluginsConventionElement
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Ganre { get; set; } = string.Empty;
        public int? Price { get; set; }
    }
}
