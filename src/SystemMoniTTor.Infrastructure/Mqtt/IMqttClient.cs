using System.Threading.Tasks;
using SystemMoniTTor.Core.Model;

namespace SystemMoniTTor.Infrastructure.Mqtt
{
    /// <summary>
    /// Defines an MQTT client.
    /// </summary>
    public interface IMqttClient
    {
        /// <summary>
        /// Sends the system information asynchronously.
        /// </summary>
        /// <param name="systemInformation">The system information.</param>
        /// <returns>A <see cref="Task"/> for the asynchronous operations.</returns>
        Task SendSystemInformationAsync(SystemInformation systemInformation);

        /// <summary>
        /// Sends the heart beat asynchronously.
        /// </summary>
        /// <param name="heartBeat">The heart beat.</param>
        /// <returns>A <see cref="Task"/> for the asynchronous operations.</returns>
        Task SendHeartBeatAsync(HeartBeat heartBeat);
    }
}
