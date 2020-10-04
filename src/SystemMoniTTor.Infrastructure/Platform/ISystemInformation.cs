using System;
using System.Runtime.InteropServices;

namespace SystemMoniTTor.Infrastructure.Platform
{
    /// <summary>
    /// Available system information.
    /// </summary>
    public interface ISystemInformation
    {
        /// <summary>
        /// Gets up time.
        /// </summary>
        /// <returns>The uptime of the system</returns>
        TimeSpan GetUpTime();

        /// <summary>
        /// Gets the operation system.
        /// </summary>
        /// <returns>The operation system</returns>
        OSPlatform GetOperationSystem();

        /// <summary>
        /// Gets the used memory.
        /// </summary>
        /// <returns>Currently used memory</returns>
        int GetUsedMemory();
    }
}
