using System;
using System.Runtime.InteropServices;

namespace SystemMoniTTor.Core.Model
{
    /// <summary>
    /// Meta information about the system.
    /// </summary>
    public class SystemInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInformation"/> class.
        /// </summary>
        /// <param name="oSPlatform">The o s platform.</param>
        /// <param name="upTime">Up time.</param>
        public SystemInformation(OSPlatform oSPlatform, TimeSpan upTime)
        {
            OSPlatform = oSPlatform;
            UpTime = upTime;
        }

        /// <summary>
        /// Gets the os platform.
        /// </summary>
        /// <value>
        /// The os platform.
        /// </value>
        public OSPlatform OSPlatform { get; }

        /// <summary>
        /// Gets up time.
        /// </summary>
        /// <value>
        /// Up time.
        /// </value>
        public TimeSpan UpTime { get; }
    }
}
