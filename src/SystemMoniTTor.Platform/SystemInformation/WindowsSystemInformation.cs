using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SystemMoniTTor.Infrastructure.Platform;

namespace SystemMoniTTor.Platform.SystemInformation
{
    public class WindowsSystemInformation : ISystemInformation
    {
        public OSPlatform GetOperationSystem()
        {
            throw new NotImplementedException();
        }

        public TimeSpan GetUpTime()
        {
            using (var upTime = new PerformanceCounter("System", "System Up Time"))
            {
                upTime.NextValue();
                return TimeSpan.FromSeconds(upTime.NextValue());
            }
        }

        public int GetUsedMemory()
        {
            throw new NotImplementedException();
        }
    }
}
