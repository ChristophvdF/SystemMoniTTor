![SystemMoniTTor logo](https://github.com/ChristophvdF/SystemMoniTTor/raw/master/assets/logo_text.png)
# SystemMoniTTor
Application to monitor the state of your computer over MQTT

# Introduction 
SystemMoniTTor is an application to integrate the state of your computer into your home automation system via [MQTT](http://mqtt.org/). The main goal of the application is to be able to check whether a computer is powered on and to be able to shut it down vie a home automation system. Powering the computer back up can be done by other means like WOL (Wakeup on lan).

## Features
- Power state of the computer (ON/OFF)
- Custom MQTT address
- Shutdown the computer remotely

To see all available commands check the Wiki page...

## Why MQTT?
There is a ton of home automation servers/ platforms/ standards out there. To support a variety of these platforms [MQTT](http://mqtt.org/) was the best choice to make. Each of these platforms either make use of a third party broker or come with there own. Additionally there is no need for any additional development of drivers or bindings to integrate the application since one only adds another [MQTT](http://mqtt.org/) client.

# Techstack
### Short version
- [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
- [.NET Desktop App](https://dotnet.microsoft.com/apps/desktop)
- [MQTTNet](https://github.com/chkr1011/MQTTnet)

### Longer version
The core of the application will be developed with [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) to ensure portability of the project. The application which will be installed on the machine will be written as a [.NET Desktop App](https://dotnet.microsoft.com/apps/desktop), since utilizing some of the Windows API is necessary. As a communication platform the team settled with the [MQTTNet](https://github.com/chkr1011/MQTTnet) since it is a well known and stable library for .NET.

# Getting Started

1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

The desktop application comes with an installer (see Releases page for the latest). If you want to build the application on your own machine see [Build and Test](#Build-and-Test) section.

# Limitations
In its current state the application only supports Windows (8.1, 10). If and when there will be a support for Unix  distributions is not decided by now. Either the support will be provided by the development team or the community.

# Build and Test

## Get the code and build it
1. Clone the Repository
2. In the root of the repository you will find an *.sln file, open it with either Visual Studio or Visual Studio Code
3. Build the project for your platform (*.Windows)

## Test
The repository contains all test in the 'test' folder in the root level. All test are written with [xUnit](https://xunit.net/) the simples way of running all test is to open the solution with Visual Studio and run the tests from the TestExplorer.

# Contribute
You want to support our work? Great, please have a look at our [Contribute](doc/CONTRIBUTE.md) page.
