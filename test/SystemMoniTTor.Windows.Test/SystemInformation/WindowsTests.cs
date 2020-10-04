using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SystemMoniTTor.Platform.SystemInformation;
using Xunit;

namespace SystemMoniTTor.Windows.Test.SystemInformation
{
    public class WindowsTests
    {
        WindowsSystemInformation sut;

        public WindowsTests()
        {
            sut = new WindowsSystemInformation();
        }

        [Fact]
        public void GetUpTime_ValidCall_AnUpTimeGreaterThanZero()
        {
            // Arrange


            // Act
            var actual = sut.GetUpTime();

            // Assert
            Assert.True(actual > TimeSpan.MinValue);
        }

        [Fact]
        public void GetOperationSystem_ValidCall_Windows()
        {
            // Arrange


            // Act
            var actual = sut.GetOperationSystem();

            // Assert
            Assert.NotNull(actual);
        }

        [Fact]
        public void GetUsedMemory_ValidCall_AMemoryUsageGreaterThanZero()
        {
            // Arrange


            // Act
            var memory = sut.GetUsedMemory();

            // Assert
            Assert.True(memory > 0);
        }
    }
}
