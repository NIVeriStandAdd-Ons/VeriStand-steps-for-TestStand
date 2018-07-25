## NI VeriStand Steps for TestStand ##

The **NI VeriStand Steps for TestStand** is a set of custom NI TestStand step types used to automate NI VeriStand from an NI TestStand sequence. 

The steps are divided into groups which provide functionality like project control, channel read/write access, alarms, real-time sequences, logging, and faulting.

The NI VeriStand Steps for TestStand are distributed as *open-source* software and released under the *BSD 2-clause "Simplified" License*. 

### Getting Started ###

#### Documentation and Examples ####

A **User Guide**, **Developer Guide**, and **Example Sequences** are installed to:

**`<Public Documents>\National Instruments\NI VeriStand Steps for TestStand`**. 

These files can also be found in the **[Documentation](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/tree/develop/Documentation)** folder in the top-level of this repository.

#### Installing version 8.0.0 and newer (using NI Package Manager) ####
***IMPORTANT: If upgrading from version 7.x.x or older be sure to remove any previous versions using Add/Remove Programs in the Windows Control Panel. If upgrading from version 8.x.x it is not necessary to remove previous versions.***

1. *Download* the .nipkg file from the [Releases](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/releases) page of this repository
1. *Locate* the .nipkg file on your local drive
1. *Install* the .nipkg file by double-clicking the file

#### Installing version 7.2.2 and older (using LabVIEW Installer) ####
1. **Uninstall any previous versions of the NI VeriStand Step Types using the Windows Control Panel**
1. *Download* the .zip file containing the LabVIEW Installer for the new version from the [Releases](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/releases) page of this repository
1. *Unzip* the installer files to your local drive
1. *Run* **setup.exe**.

### Required Software ###

#### Currently supported NI VeriStand versions ####

* NI VeriStand 2015 SP1
* NI VeriStand 2017
* NI VeriStand 2018

Beginning with version 7.2.2 each package or installer for the NI VeriStand Step Types includes support for *one version of VeriStand* and *all currently supported TestStand versions*. It is *not* necessary to have every version of TestStand installed in order to use the step types. It is not necessary to reinstall the VeriStand Step Types after installing a new supported version of NI TestStand. 

#### Currently supported NI TestStand versions ####
* NI TestStand 2014 (32- and 64-bit)
* NI TestStand 2016 (32- and 64-bit)
* NI TestStand 2017 (32- and 64-bit)

For example, the **ni-veristand-2018-steps-for-teststand_7.2.2+001.nipkg** package installs NI VeriStand 2018 compatible step types for all versions of TestStand listed above. 

Beginning with version 8.0.0 the NI VeriStand Step Types are available as an NI Package with the .nipkg file extension. Previous versions were distributed as a LabVIEW Installer. NI Package files can be installed using [NI Package Manager](http://search.ni.com/nisearch/app/main/p/bot/no/ap/tech/lang/en/pg/1/sn/catnav:du/q/ni%20package%20manager/)

Version 7.2.2 is the last version available with a LabVIEW Installer. 

### Accessing Builds ###

#### Current version ####

All current releases are available on the [*Releases*](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/releases) page of this repository. Certain legacy releases are also available here.

#### Legacy versions ####

Legacy versions are also available at the deprecated [NI VeriStand Steps for TestStand Community Page](https://forums.ni.com/t5/NI-VeriStand-Add-Ons-Documents/NI-VeriStand-Add-on-VeriStand-Steps-for-TestStand/ta-p/3535888).  

### Release Notes ###

* **8.0.0**
 1. First version available as an NI Package (.nipkg) instead of a LabVIEW Installer. 

* **7.2.2**
 1. Added *OpenVSTimeout Step Property* to **Initialize VeriStand** and **Start VeriStand** step types. This Step Property allows the user to specify the timeout used when waiting for the VeriStand.exe application to open when using these two steps. *OpenVSTimeout* defaults to 120 seconds.
 1. Added *CloseUIManager Step Property* to **Stop VeriStand** Step Type to toggle whether this step closes the NI VeriStand UI Manager. 
 1. Fixed bug in **Channel Value Limit Test Step** which caused an error when using certain Comparison Types. A legacy **Channel Value Limit Test (TestStand 2014)** Step is now provided. 
 1. Package now installs a **User Guide, Developer Guide, and Example Files** to *`<Public Documents>\National Instruments\NI VeriStand Steps for TestStand`*.

* **7.2.1**
 1. Fixed bug which caused reference errors in some cases when TestStand is configured to use the LabVIEW Development environment as the LabVIEW adapter.


* **7.2**
 1. Fixed bug preventing alarm states from being returned correctly by Get Alarm State Step


* **7.1**
 1. TestStand 2017 Support
 1. Single installer for TestStand 32- and 64-bit
 1. Fixed bug preventing sequences containing the steps from executing when the sequence is called by the TestStand API from the LabVIEW Development Environment.


* **7.0**
 1. Launching VeriStand silently now suppresses both the Workspace and UI Manager.
 1. RT Sequence Steps and Stimulus Profile Steps now include an additional Timeout step property which causes the Step to Timeout. This is different from these Steps' existing Timeout_ms property which is the RT Sequence Timestep Timeout.
 1. Stop VeriStand Step now includes an additional CloseApp step property which closes the VeriStand application.


* **6.0**
 1. Installer is now a LabVIEW installer
 1. TestStand 2016 x64 support


* **5.0**
 1. Fixed bug preventing RT Sequence parameters of data type U32, U32 Array, U64, or U64 Array from being passed to RT Sequence correctly. 


* **4.0**
 1. Fixed bug in Start VeriStand step type which caused the step's InstallationPath property to default to the wrong version of VeriStand. This change only affects the VeriStand.exe installation path in newly created instances of the step type.
 1. Fixed bug which prevented the Channel Value Limit Test step type from returning Units value to the step results.  
 1. Fixed bug which caused TestStand 2016 to crash when configuring the Channel Value Limit Test. 


* **3.0** 
 1. Added the ability to specify the Target for running RT Sequences, and also the ability to specify a Timeout.  
 1. Fixed an issue where Double data-typed parameters were truncated to integers.  This update applies only to the steps for VeriStand 2015 and up, and only affects the following TestStand steps: RT Sequence Action, RT Sequence Numeric Limit Test, and RT Sequence Pass Fail Test.

### Support ###

The VeriStand Steps for TestStand source code and built packages are provided as-is under an open source license. Neither the source code nor built packages are suppported by National Instruments. 

Support for the VeriStand Steps for TestStand package is available from the community at the the [*VeriStand Steps for TestStand Feedback Forum*](https://forums.ni.com/t5/NI-VeriStand-Add-Ons-Discussions/VeriStand-Steps-for-TestStand-Feedback/td-p/3442166). 

We also encourage users to report bugs or issues to the community using the project's [*GitHub Issues page*](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/issues).


### Quality, Limitations ###

This package has been used in many systems over several years and is considered mature and stable.  

### License ###

This source code is provided as-is under the BSD 2-clause "Simplified" open source license. 

*This repository and any materials provided by NI therein are provided AS IS. NI DISCLAIMS ANY AND ALL LIABILITIES FOR AND MAKES NO WARRANTIES, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR  PARTICULAR PURPOSE, OR NON-INFRINGEMENT OF INTELLECTUAL PROPERTY. NI shall have no liability for any direct, indirect, incidental, punitive, special, or consequential damages for your use of the repository or any materials contained therein.*