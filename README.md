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
***IMPORTANT: If upgrading from version 7.x.x or older be sure to remove any previous versions using Add/Remove Programs in the Windows Control Panel. If upgrading from version 8.x.x or later it is not necessary to remove previous versions.***

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
* NI VeriStand 2016
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

See [Release Notes Wiki](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/wiki/Release-Notes).

### Support ###

The VeriStand Steps for TestStand source code and built packages are provided as-is under an open source license. Neither the source code nor built packages are suppported by National Instruments. 

Support for the VeriStand Steps for TestStand package is available from the community at the the [*VeriStand Steps for TestStand Feedback Forum*](https://forums.ni.com/t5/NI-VeriStand-Add-Ons-Discussions/VeriStand-Steps-for-TestStand-Feedback/td-p/3442166). 

We also encourage users to report bugs or issues to the community using the project's [*GitHub Issues page*](https://github.com/NIVeriStandAdd-Ons/VeriStand-steps-for-TestStand/issues).


### Quality, Limitations ###

This package has been used in many systems over several years and is considered mature and stable.  

### License ###

This source code and all releases are provided under the Apache 2.0 open-source software license.

 Copyright 2018 National Instruments
 

  Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
  You may obtain a copy of the License at 
  http://www.apache.org/licenses/LICENSE-2.0
  Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  See the License for the specific language governing permissions and limitations under the License.

*This repository and any materials provided by NI therein are provided AS IS. NI DISCLAIMS ANY AND ALL LIABILITIES FOR AND MAKES NO WARRANTIES, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR  PARTICULAR PURPOSE, OR NON-INFRINGEMENT OF INTELLECTUAL PROPERTY. NI shall have no liability for any direct, indirect, incidental, punitive, special, or consequential damages for your use of the repository or any materials contained therein.*
