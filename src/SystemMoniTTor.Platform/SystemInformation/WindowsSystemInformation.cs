using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SystemMoniTTor.Core.Model;
using SystemMoniTTor.Infrastructure.Platform;

namespace SystemMoniTTor.Platform.SystemInformation
{
    /// <summary>
    /// System information for windows platform.
    /// </summary>
    /// <seealso cref="SystemMoniTTor.Infrastructure.Platform.ISystemInformation" />
    public class WindowsSystemInformation : ISystemInformation
    {
        /// <summary>
        /// The get memory file name
        /// </summary>
        private const string GetMemoryFileName = "wmic";

        /// <summary>
        /// The get memory arguments
        /// </summary>
        private const string GetMemoryArguments = "OS get FreePhysicalMemory,TotalVisibleMemorySize /Value";

        /// <summary>
        /// Gets the used memory.
        /// </summary>
        /// <returns>
        /// Currently used memory
        /// </returns>
        public MemoryMetrics GetMemoryInformation()
        {
            var output = string.Empty;

            var info = new ProcessStartInfo()
            {
                FileName = GetMemoryFileName,
                Arguments = GetMemoryArguments,
                RedirectStandardOutput = true
            };

            using (var process = Process.Start(info))
            {
                output = process.StandardOutput.ReadToEnd();
            }

            return ProcessMemoryValues(output);
        }

        /// <summary>
        /// Gets the operation system.
        /// </summary>
        /// <returns>
        /// The operation system
        /// </returns>
        public OperatingSystems GetOperationSystem()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return OperatingSystems.Windows;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return OperatingSystems.Linux;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return OperatingSystems.MacOs;
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                return OperatingSystems.FreeBds;
            }
            else
            {
                return OperatingSystems.Unknown;
            }
        }

        /// <summary>
        /// Gets up time.
        /// </summary>
        /// <returns>
        /// The uptime of the system
        /// </returns>
        public TimeSpan GetUpTime()
        {
            using (var upTime = new PerformanceCounter("System", "System Up Time"))
            {
                upTime.NextValue();
                return TimeSpan.FromSeconds(upTime.NextValue());
            }
        }

        /// <summary>
        /// Processes the memory values.
        /// </summary>
        /// <param name="output">The output.</param>
        /// <returns>A <see cref="MemoryMetrics"/> with all details.</returns>
        private MemoryMetrics ProcessMemoryValues(string output)
        {
            var lines = output.Trim().Split("\n");
            var freeMemory = lines[0].Split("=", StringSplitOptions.RemoveEmptyEntries);
            var totalMemory = lines[1].Split("=", StringSplitOptions.RemoveEmptyEntries);

            return new MemoryMetrics
            {
                Total = Math.Round(double.Parse(totalMemory[1]) / 1024, 0),
                Free = Math.Round(double.Parse(freeMemory[1]) / 1024, 0)
            };
        }
    }
}
