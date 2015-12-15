namespace UnattendedTest.Services.Interfaces
{
    /// <summary>
    /// Interface which defines the config service contract
    /// </summary>
    public interface IConfigService
    {
        /// <summary>
        /// Returns the configuration specified by <paramref name="name"/>
        /// </summary>
        /// <param name="name">The configuration item name</param>
        /// <returns>A <see cref="string"/></returns>
        string GetSetting(string name);
    }
}
