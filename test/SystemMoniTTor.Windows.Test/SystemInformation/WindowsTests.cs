using System;
using SystemMoniTTor.Core.Model;
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
        public void GetMemoryInformation_ValidCall_AnUpTimeGreaterThanZero()
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
            Assert.Equal(OperatingSystems.Windows, actual);
        }

        [Fact]
        public void GetUsedMemory_ValidCall_AMemoryUsageGreaterThanZero()
        {
            // Arrange


            // Act
            var memory = sut.GetMemoryInformation();

            // Assert
            Assert.True(memory.Free > 0);
            Assert.True(memory.Total > 0);
            Assert.True(memory.Used > 0);
        }
    }
}
