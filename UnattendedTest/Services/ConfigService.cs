using System.Configuration;
using UnattendedTest.Services.Interfaces;

namespace UnattendedTest.Services
{
    /// <summary>
    /// Class which models an implementation the config service interface
    /// </summary>
    public class ConfigService : IConfigService
    {
        /// <summary>
        /// Returns the configuration specified by <paramref name="name"/>
        /// </summary>
        /// <param name="name">The configuration item name</param>
        /// <returns>A <see cref="string"/></returns>
        public string GetSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}