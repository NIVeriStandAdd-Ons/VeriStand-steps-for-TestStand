## VeriStand Steps for TestStand ##

The **VeriStand Steps for TestStand** is a set of custom step types designed to be used with NI TestStand. The VeriStand Steps allow the user to control VeriStand from a TestStand sequence thereby providing a wide range of automation capability. 

The VeriStand Steps are divided into several groups of steps which provide functionality like project control, channel read/write access, control of functions like alarms, real-time sequences, logging, faulting.

These custom step types are **open-source** and released under the *BSD 2-clause "Simplified" License*. 

### Support ###

The VeriStand Steps for TestStand source code and built packages are provided as-is under an open source license. Neither the source code nor built packages are suppported by National Instruments. 

Support for the VeriStand Steps for TestStand package is available from the community at the the [VeriStand Steps for TestStand Feedback Forum](https://forums.ni.com/t5/NI-VeriStand-Add-Ons-Discussions/VeriStand-Steps-for-TestStand-Feedback/td-p/3442166). 

We also encourage users to report bugs or issues to the community using the project's [Github Issues page](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/issues).

### Repository Structure ###

**Documentation** 

The **\documentation** directory at the top level of the repository contains the existing public documentation for this package. This documentation currently includes:

+ **VeriStand Steps for TestStand User Guide.docx**
    The user guide provides a description of each VeriStand Step Type as well as comments on how to use them. 
+ **VeriStand Steps for TestStand Developer Guide.docx** The developer guide provides basic background on how the source code for the step types is structured. *Sections of this document are out of date*.
+ **Documentation\Tutorial** The \Tutorial directory contains a small tutorial to demonstrate use of the steps.

**Source**

The **\Source** directory at the top level of the repository contains all source code comprising the VeriStand Steps.

+ **\Source\LV** The \LV directory contains all LabVIEW source code required to create the steps.
+ **\Source\CSharp** The \Csharp directory contains all C# code required to create the steps.
+ **\Source\CustomPaletteFile** The \CustomPaletteFile directory contains the TestStand custom type palette .ini file used by the steps. It also contains a VeriStand .ico file.
+ **\Source\Test** The \Test directory contains several TestStand sequences which may be used to validate the functionality of the VeriStand Steps after they are installed. 
    

### Built Availability ###

There are builds of this code available on the [community page](https://forums.ni.com/t5/NI-VeriStand-Add-Ons-Documents/NI-VeriStand-Add-on-VeriStand-Steps-for-TestStand/ta-p/3535888). 

### Quality, Limitations ###

This package has been used in many systems over several years and is considered mature and stable.  

### License ###

This source code is provided as-is under the BSD 2-clause "Simplified" open source license. 

*This repository and any materials provided by NI therein are provided AS IS. NI DISCLAIMS ANY AND ALL LIABILITIES FOR AND MAKES NO WARRANTIES, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR  PARTICULAR PURPOSE, OR NON-INFRINGEMENT OF INTELLECTUAL PROPERTY. NI shall have no liability for any direct, indirect, incidental, punitive, special, or consequential damages for your use of the repository or any materials contained therein.*