using System.Configuration;

namespace MicrokernelHandsOn.Core
{
    public class PluginConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("plugins", IsRequired = true)]
        public PluginElementCollection PluginElementCollection
        {
            get { return (PluginElementCollection) base["plugins"]; }
            set { base["plugins"] = value; }
        }
    }
}