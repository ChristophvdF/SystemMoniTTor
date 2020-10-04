using System;

namespace SystemMoniTTor.Core.Model
{
    /// <summary>
    /// Meta information about the system.
    /// </summary>
    public class SystemInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInformation" /> class.
        /// </summary>
        /// <param name="os">The os platform.</param>
        /// <param name="upTime">Up time.</param>
        /// <param name="memoryMetrics">The memory metrics.</param>
        public SystemInformation(OperatingSystems os, TimeSpan upTime, MemoryMetrics memoryMetrics
        {
            OperatingSystem = os;
            UpTime = upTime;
            MemoryMetrics = memoryMetrics;
        }

        /// <summary>
        /// Gets the os platform.
        /// </summary>
        /// <value>
        /// The os platform.
        /// </value>
        public OperatingSystems OperatingSystem { get; }

        /// <summary>
        /// Gets up time.
        /// </summary>
        /// <value>
        /// Up time.
        /// </value>
        public TimeSpan UpTime { get; }

        /// <summary>
        /// Gets the memory metrics.
        /// </summary>
        /// <value>
        /// The memory metrics.
        /// </value>
        public MemoryMetrics MemoryMetrics { get; }
    }
}
