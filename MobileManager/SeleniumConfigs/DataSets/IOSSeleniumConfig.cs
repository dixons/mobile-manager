using System;
using System.Linq;
using MobileManager.Models.Devices;
using MobileManager.Models.Devices.Interfaces;
using MobileManager.Configuration.Interfaces;
using MobileManager.SeleniumConfigs.DataSets.Interfaces;
using DotLiquid;

namespace MobileManager.SeleniumConfigs.DataSets
{
    /// <inheritdoc />
    /// <summary>
    /// IosSeleniumConfig.
    /// </summary>
    public class IosSeleniumConfig : Drop, ISeleniumConfig
    {
        /// <summary>
        /// Initializes a new instance of the IosSeleniumConfig class.
        /// </summary>
        /// <param name="device">IDevice Device</param>
        /// <param name="configuration">IManagerConfiguration configuration</param>
        public IosSeleniumConfig(IDevice device, IManagerConfiguration configuration) { 
            this.Id = device.Id;
            this.Name = device.Name;
            this.AppiumEndpoint = device.AppiumEndpoint;
            this.Host = !string.IsNullOrEmpty(device.AppiumEndpoint) ? new Uri(device.AppiumEndpoint).Host : "";
            this.Port = !string.IsNullOrEmpty(device.AppiumEndpoint) ? new Uri(device.AppiumEndpoint).Port.ToString() : "";
            this.Version = device.Properties.First(x => x.Key == "ProductVersion").Value;
            this.TeamId = configuration.IosDeveloperCertificateTeamId;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>The Id.</value>
        public string Id { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the AppiumEndpoint.
        /// </summary>
        /// <value>The AppiumEndpoint.</value>
        public string AppiumEndpoint { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        /// <value>The Host.</value>
        public string Host { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        /// <value>The Port.</value>
        public string Port { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        /// <value>The Version.</value>
        public string Version { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the TeamId.
        /// </summary>
        /// <value>The TeamId.</value>
        public string TeamId { get; set; }
    }

}