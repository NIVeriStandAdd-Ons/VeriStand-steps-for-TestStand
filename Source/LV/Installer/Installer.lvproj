<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="15008000">
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="GAC Utilities" Type="Folder">
			<Item Name="InstallToGAC.exe" Type="Document" URL="../../../../built/ProgramFiles_32/VeriStand Steps for TestStand/InstallToGAC.exe"/>
			<Item Name="RemoveFromGAC.exe" Type="Document" URL="../../../../built/ProgramFiles_32/VeriStand Steps for TestStand/RemoveFromGAC.exe"/>
		</Item>
		<Item Name="Icon File" Type="Folder">
			<Item Name="Veristand_icon_vista.ico" Type="Document" URL="../../../CustomPaletteFile/Veristand_icon_vista.ico"/>
		</Item>
		<Item Name="Install Actions" Type="Folder">
			<Item Name="Post-Install Action.vi" Type="VI" URL="../Actions/Post-Install Action.vi"/>
			<Item Name="PostInstallAction.exe" Type="Document" URL="../../../../built/ProgramFiles_32/VeriStand Steps for TestStand/PostInstallAction.exe"/>
			<Item Name="Pre-Build Action.vi" Type="VI" URL="../Actions/Pre-Build Action.vi"/>
			<Item Name="Pre-Uninstall Action.vi" Type="VI" URL="../Actions/Pre-Uninstall Action.vi"/>
			<Item Name="PreUninstallAction.exe" Type="Document" URL="../../../../built/ProgramFiles_32/VeriStand Steps for TestStand/PreUninstallAction.exe"/>
		</Item>
		<Item Name="License" Type="Folder">
			<Item Name="LICENSE.txt" Type="Document" URL="../../../../LICENSE.txt"/>
		</Item>
		<Item Name="Packed Libraries" Type="Folder">
			<Item Name="x64" Type="Folder">
				<Item Name="ni-veristand-steps-runtime-lib.lvlibp" Type="LVLibp" URL="../../../../built/documents/National Instruments/TestStand 2014 (32-bit)/Components/TypePalettes/ni-veristand-steps-runtime-lib.lvlibp"/>
			</Item>
			<Item Name="x86" Type="Folder">
				<Item Name="ni-veristand-steps-runtime-lib.lvlibp" Type="LVLibp" URL="../../../../built/documents/National Instruments/TestStand 2014 (64-bit)/Components/TypePalettes/ni-veristand-steps-runtime-lib.lvlibp"/>
			</Item>
		</Item>
		<Item Name="TypePalette File" Type="Folder">
			<Item Name="NI_VeristandTypes.ini" Type="Document" URL="../../../../built/documents/National Instruments/TestStand 2014 (32-bit)/Components/TypePalettes/NI_VeristandTypes.ini"/>
		</Item>
		<Item Name="VeriStandStepsAssembly" Type="Folder">
			<Item Name="NationalInstruments.Veristand.VeristandSteps.dll" Type="Document" URL="../../../../built/ProgramFiles_32/VeriStand Steps for TestStand/NationalInstruments.Veristand.VeristandSteps.dll"/>
		</Item>
		<Item Name="BuildVIs.lvlib" Type="Library" URL="../../BuildVIs/BuildVIs.lvlib"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Application Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/file.llb/Application Directory.vi"/>
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
				<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
				<Item Name="Check Special Tags.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Check Special Tags.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="Convert property node font to graphics font.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Convert property node font to graphics font.vi"/>
				<Item Name="Details Display Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Details Display Dialog.vi"/>
				<Item Name="DialogType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogType.ctl"/>
				<Item Name="DialogTypeEnum.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogTypeEnum.ctl"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Error Code Database.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Code Database.vi"/>
				<Item Name="ErrWarn.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/ErrWarn.ctl"/>
				<Item Name="eventvkey.ctl" Type="VI" URL="/&lt;vilib&gt;/event_ctls.llb/eventvkey.ctl"/>
				<Item Name="Find Tag.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Find Tag.vi"/>
				<Item Name="Format Message String.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Format Message String.vi"/>
				<Item Name="General Error Handler Core CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler Core CORE.vi"/>
				<Item Name="General Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler.vi"/>
				<Item Name="Get String Text Bounds.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Get String Text Bounds.vi"/>
				<Item Name="Get System Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/sysdir.llb/Get System Directory.vi"/>
				<Item Name="Get Text Rect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Get Text Rect.vi"/>
				<Item Name="GetHelpDir.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetHelpDir.vi"/>
				<Item Name="GetRTHostConnectedProp.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetRTHostConnectedProp.vi"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="LVRectTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVRectTypeDef.ctl"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
				<Item Name="NI_PackedLibraryUtility.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/LVLibp/NI_PackedLibraryUtility.lvlib"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Search and Replace Pattern.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Search and Replace Pattern.vi"/>
				<Item Name="Set Bold Text.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set Bold Text.vi"/>
				<Item Name="Set String Value.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set String Value.vi"/>
				<Item Name="Simple Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Simple Error Handler.vi"/>
				<Item Name="Space Constant.vi" Type="VI" URL="/&lt;vilib&gt;/dlg_ctls.llb/Space Constant.vi"/>
				<Item Name="System Directory Type.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/sysdir.llb/System Directory Type.ctl"/>
				<Item Name="System Exec.vi" Type="VI" URL="/&lt;vilib&gt;/Platform/system.llb/System Exec.vi"/>
				<Item Name="TagReturnType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/TagReturnType.ctl"/>
				<Item Name="Three Button Dialog CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog CORE.vi"/>
				<Item Name="Three Button Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog.vi"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build">
			<Item Name="Installer" Type="Installer">
				<Property Name="Destination[0].name" Type="Str">VeriStand Steps for TestStand</Property>
				<Property Name="Destination[0].parent" Type="Str">{3912416A-D2E5-411B-AFEE-B63654D690C0}</Property>
				<Property Name="Destination[0].tag" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Destination[0].type" Type="Str">userFolder</Property>
				<Property Name="Destination[1].name" Type="Str">National Instruments</Property>
				<Property Name="Destination[1].parent" Type="Str">{115F5F59-DED6-42E2-8467-4CD042208C47}</Property>
				<Property Name="Destination[1].tag" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[1].type" Type="Str">userFolder</Property>
				<Property Name="Destination[10].name" Type="Str">Icons</Property>
				<Property Name="Destination[10].parent" Type="Str">{4AC69F4B-D657-4477-9F11-6195C6A686A6}</Property>
				<Property Name="Destination[10].tag" Type="Str">{208D8916-E177-46B4-AB4F-AD24A3BBCDED}</Property>
				<Property Name="Destination[10].type" Type="Str">userFolder</Property>
				<Property Name="Destination[11].name" Type="Str">Components</Property>
				<Property Name="Destination[11].parent" Type="Str">{67450134-2A8E-4D92-AB22-D48A719DC20F}</Property>
				<Property Name="Destination[11].tag" Type="Str">{B30A26DC-EB10-4BBB-B9C0-13F0F7FC8081}</Property>
				<Property Name="Destination[11].type" Type="Str">userFolder</Property>
				<Property Name="Destination[12].name" Type="Str">Components</Property>
				<Property Name="Destination[12].parent" Type="Str">{B395C667-7988-45CB-A728-01E95151783B}</Property>
				<Property Name="Destination[12].tag" Type="Str">{D970C25E-B835-4C37-A0E6-01959DD6C87F}</Property>
				<Property Name="Destination[12].type" Type="Str">userFolder</Property>
				<Property Name="Destination[13].name" Type="Str">Components</Property>
				<Property Name="Destination[13].parent" Type="Str">{DBF00A53-AA95-4B35-94C8-8895D49603BD}</Property>
				<Property Name="Destination[13].tag" Type="Str">{275E099B-6522-4018-B4A2-158B0A985AEE}</Property>
				<Property Name="Destination[13].type" Type="Str">userFolder</Property>
				<Property Name="Destination[14].name" Type="Str">Components</Property>
				<Property Name="Destination[14].parent" Type="Str">{6EF9F3C7-30E4-492B-A83E-EB0C421220E1}</Property>
				<Property Name="Destination[14].tag" Type="Str">{49BBD9F6-2BC4-428F-A91F-D37A3B3B8C86}</Property>
				<Property Name="Destination[14].type" Type="Str">userFolder</Property>
				<Property Name="Destination[15].name" Type="Str">Components</Property>
				<Property Name="Destination[15].parent" Type="Str">{96E4292A-AEB5-49B5-A47E-C77BF5930771}</Property>
				<Property Name="Destination[15].tag" Type="Str">{52F26B5D-F6F6-44F9-8643-0A21002F6BBB}</Property>
				<Property Name="Destination[15].type" Type="Str">userFolder</Property>
				<Property Name="Destination[16].name" Type="Str">Icons</Property>
				<Property Name="Destination[16].parent" Type="Str">{B30A26DC-EB10-4BBB-B9C0-13F0F7FC8081}</Property>
				<Property Name="Destination[16].tag" Type="Str">{F2D31B52-5AD1-4E13-821D-381E5459530C}</Property>
				<Property Name="Destination[16].type" Type="Str">userFolder</Property>
				<Property Name="Destination[17].name" Type="Str">Icons</Property>
				<Property Name="Destination[17].parent" Type="Str">{D970C25E-B835-4C37-A0E6-01959DD6C87F}</Property>
				<Property Name="Destination[17].tag" Type="Str">{6D564DF2-C025-4298-A5A8-C8A33D303E34}</Property>
				<Property Name="Destination[17].type" Type="Str">userFolder</Property>
				<Property Name="Destination[18].name" Type="Str">Icons</Property>
				<Property Name="Destination[18].parent" Type="Str">{275E099B-6522-4018-B4A2-158B0A985AEE}</Property>
				<Property Name="Destination[18].tag" Type="Str">{12D23933-1584-4A6D-9CA9-641A86AE7B0D}</Property>
				<Property Name="Destination[18].type" Type="Str">userFolder</Property>
				<Property Name="Destination[19].name" Type="Str">Icons</Property>
				<Property Name="Destination[19].parent" Type="Str">{49BBD9F6-2BC4-428F-A91F-D37A3B3B8C86}</Property>
				<Property Name="Destination[19].tag" Type="Str">{98473B90-D7F4-4236-9CE1-E18830E362CD}</Property>
				<Property Name="Destination[19].type" Type="Str">userFolder</Property>
				<Property Name="Destination[2].name" Type="Str">TestStand 2014 (32-bit)</Property>
				<Property Name="Destination[2].parent" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[2].tag" Type="Str">{61CE855B-2C97-48BF-AFED-48022123B012}</Property>
				<Property Name="Destination[2].type" Type="Str">userFolder</Property>
				<Property Name="Destination[20].name" Type="Str">Icons</Property>
				<Property Name="Destination[20].parent" Type="Str">{52F26B5D-F6F6-44F9-8643-0A21002F6BBB}</Property>
				<Property Name="Destination[20].tag" Type="Str">{A2981AF9-DE20-4DB4-94EC-597288B5F23D}</Property>
				<Property Name="Destination[20].type" Type="Str">userFolder</Property>
				<Property Name="Destination[21].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[21].parent" Type="Str">{B30A26DC-EB10-4BBB-B9C0-13F0F7FC8081}</Property>
				<Property Name="Destination[21].tag" Type="Str">{265654FD-C930-4215-A4A0-34E2D4B94207}</Property>
				<Property Name="Destination[21].type" Type="Str">userFolder</Property>
				<Property Name="Destination[22].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[22].parent" Type="Str">{D970C25E-B835-4C37-A0E6-01959DD6C87F}</Property>
				<Property Name="Destination[22].tag" Type="Str">{B86CD178-DDCE-40A6-82AB-AB34427A454F}</Property>
				<Property Name="Destination[22].type" Type="Str">userFolder</Property>
				<Property Name="Destination[23].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[23].parent" Type="Str">{275E099B-6522-4018-B4A2-158B0A985AEE}</Property>
				<Property Name="Destination[23].tag" Type="Str">{CB915E63-F77E-4386-AA08-7813B421EF17}</Property>
				<Property Name="Destination[23].type" Type="Str">userFolder</Property>
				<Property Name="Destination[24].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[24].parent" Type="Str">{49BBD9F6-2BC4-428F-A91F-D37A3B3B8C86}</Property>
				<Property Name="Destination[24].tag" Type="Str">{04A93A51-C323-4921-8AA0-B0BEFE82DF61}</Property>
				<Property Name="Destination[24].type" Type="Str">userFolder</Property>
				<Property Name="Destination[25].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[25].parent" Type="Str">{52F26B5D-F6F6-44F9-8643-0A21002F6BBB}</Property>
				<Property Name="Destination[25].tag" Type="Str">{42F4D869-DC12-49C3-899F-1EF5F9B25DD6}</Property>
				<Property Name="Destination[25].type" Type="Str">userFolder</Property>
				<Property Name="Destination[3].name" Type="Str">TestStand 2014 (64-bit)</Property>
				<Property Name="Destination[3].parent" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[3].tag" Type="Str">{67450134-2A8E-4D92-AB22-D48A719DC20F}</Property>
				<Property Name="Destination[3].type" Type="Str">userFolder</Property>
				<Property Name="Destination[4].name" Type="Str">TestStand 2016 (32-bit)</Property>
				<Property Name="Destination[4].parent" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[4].tag" Type="Str">{B395C667-7988-45CB-A728-01E95151783B}</Property>
				<Property Name="Destination[4].type" Type="Str">userFolder</Property>
				<Property Name="Destination[5].name" Type="Str">TestStand 2016 (64-bit)</Property>
				<Property Name="Destination[5].parent" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[5].tag" Type="Str">{DBF00A53-AA95-4B35-94C8-8895D49603BD}</Property>
				<Property Name="Destination[5].type" Type="Str">userFolder</Property>
				<Property Name="Destination[6].name" Type="Str">TestStand 2017 (32-bit)</Property>
				<Property Name="Destination[6].parent" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[6].tag" Type="Str">{6EF9F3C7-30E4-492B-A83E-EB0C421220E1}</Property>
				<Property Name="Destination[6].type" Type="Str">userFolder</Property>
				<Property Name="Destination[7].name" Type="Str">TestStand 2017 (64-bit)</Property>
				<Property Name="Destination[7].parent" Type="Str">{F1BBEBB5-6105-4781-BBEB-DD282B7BF196}</Property>
				<Property Name="Destination[7].tag" Type="Str">{96E4292A-AEB5-49B5-A47E-C77BF5930771}</Property>
				<Property Name="Destination[7].type" Type="Str">userFolder</Property>
				<Property Name="Destination[8].name" Type="Str">Components</Property>
				<Property Name="Destination[8].parent" Type="Str">{61CE855B-2C97-48BF-AFED-48022123B012}</Property>
				<Property Name="Destination[8].tag" Type="Str">{4AC69F4B-D657-4477-9F11-6195C6A686A6}</Property>
				<Property Name="Destination[8].type" Type="Str">userFolder</Property>
				<Property Name="Destination[9].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[9].parent" Type="Str">{4AC69F4B-D657-4477-9F11-6195C6A686A6}</Property>
				<Property Name="Destination[9].tag" Type="Str">{E2C476E5-6CCC-4AD4-B946-A602E8C945B9}</Property>
				<Property Name="Destination[9].type" Type="Str">userFolder</Property>
				<Property Name="DestinationCount" Type="Int">26</Property>
				<Property Name="DistPart[0].flavorID" Type="Str">DefaultFull</Property>
				<Property Name="DistPart[0].productID" Type="Str">{ABC18A44-459C-45F9-82F4-828B3D6A78D7}</Property>
				<Property Name="DistPart[0].productName" Type="Str">NI LabVIEW Runtime 2015 SP1 f9</Property>
				<Property Name="DistPart[0].SoftDep[0].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[0].productName" Type="Str">NI LabVIEW Runtime 2015 SP1 Non-English Support.</Property>
				<Property Name="DistPart[0].SoftDep[0].upgradeCode" Type="Str">{128ABF1E-5F69-40D1-8A81-33DCF8229F08}</Property>
				<Property Name="DistPart[0].SoftDep[1].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[1].productName" Type="Str">NI ActiveX Container</Property>
				<Property Name="DistPart[0].SoftDep[1].upgradeCode" Type="Str">{1038A887-23E1-4289-B0BD-0C4B83C6BA21}</Property>
				<Property Name="DistPart[0].SoftDep[10].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[10].productName" Type="Str">NI mDNS Responder 17.0</Property>
				<Property Name="DistPart[0].SoftDep[10].upgradeCode" Type="Str">{9607874B-4BB3-42CB-B450-A2F5EF60BA3B}</Property>
				<Property Name="DistPart[0].SoftDep[11].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[11].productName" Type="Str">NI Deployment Framework 2017</Property>
				<Property Name="DistPart[0].SoftDep[11].upgradeCode" Type="Str">{838942E4-B73C-492E-81A3-AA1E291FD0DC}</Property>
				<Property Name="DistPart[0].SoftDep[12].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[12].productName" Type="Str">NI Error Reporting 2017</Property>
				<Property Name="DistPart[0].SoftDep[12].upgradeCode" Type="Str">{42E818C6-2B08-4DE7-BD91-B0FD704C119A}</Property>
				<Property Name="DistPart[0].SoftDep[2].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[2].productName" Type="Str">NI System Web Server 15.5</Property>
				<Property Name="DistPart[0].SoftDep[2].upgradeCode" Type="Str">{FCF64B73-B7D4-4971-8F11-24BAF7CC3E6C}</Property>
				<Property Name="DistPart[0].SoftDep[3].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[3].productName" Type="Str">Math Kernel Libraries</Property>
				<Property Name="DistPart[0].SoftDep[3].upgradeCode" Type="Str">{4C0854AD-9BFC-4494-A4E0-D96C0C07F1F2}</Property>
				<Property Name="DistPart[0].SoftDep[4].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[4].productName" Type="Str">NI Logos 5.9</Property>
				<Property Name="DistPart[0].SoftDep[4].upgradeCode" Type="Str">{5E4A4CE3-4D06-11D4-8B22-006008C16337}</Property>
				<Property Name="DistPart[0].SoftDep[5].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[5].productName" Type="Str">NI TDM Streaming 17.0</Property>
				<Property Name="DistPart[0].SoftDep[5].upgradeCode" Type="Str">{4CD11BE6-6BB7-4082-8A27-C13771BC309B}</Property>
				<Property Name="DistPart[0].SoftDep[6].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[6].productName" Type="Str">NI LabVIEW Web Server 2015</Property>
				<Property Name="DistPart[0].SoftDep[6].upgradeCode" Type="Str">{78AAB900-C712-11E3-9C1A-0800200C9A66}</Property>
				<Property Name="DistPart[0].SoftDep[7].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[7].productName" Type="Str">NI LabVIEW Real-Time NBFifo 2015</Property>
				<Property Name="DistPart[0].SoftDep[7].upgradeCode" Type="Str">{25643B9A-90E8-4100-B30C-10EC4DE2EE68}</Property>
				<Property Name="DistPart[0].SoftDep[8].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[8].productName" Type="Str">NI VC2008MSMs</Property>
				<Property Name="DistPart[0].SoftDep[8].upgradeCode" Type="Str">{FDA3F8BB-BAA9-45D7-8DC7-22E1F5C76315}</Property>
				<Property Name="DistPart[0].SoftDep[9].exclude" Type="Bool">false</Property>
				<Property Name="DistPart[0].SoftDep[9].productName" Type="Str">NI VC2010MSMs</Property>
				<Property Name="DistPart[0].SoftDep[9].upgradeCode" Type="Str">{EFBA6F9E-F934-4BD7-AC51-60CCA480489C}</Property>
				<Property Name="DistPart[0].SoftDepCount" Type="Int">13</Property>
				<Property Name="DistPart[0].upgradeCode" Type="Str">{CA8FF739-2EDA-4134-9A70-0F5DD933FDED}</Property>
				<Property Name="DistPartCount" Type="Int">1</Property>
				<Property Name="INST_author" Type="Str">NIC SE</Property>
				<Property Name="INST_autoIncrement" Type="Bool">true</Property>
				<Property Name="INST_buildLocation" Type="Path">../Installer/build_temp</Property>
				<Property Name="INST_buildLocation.type" Type="Str">relativeToCommon</Property>
				<Property Name="INST_buildSpecName" Type="Str">Installer</Property>
				<Property Name="INST_defaultDir" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="INST_productName" Type="Str">Installer</Property>
				<Property Name="INST_productVersion" Type="Str">1.0.1</Property>
				<Property Name="InstSpecBitness" Type="Str">32-bit</Property>
				<Property Name="InstSpecVersion" Type="Str">15018004</Property>
				<Property Name="MSI_arpCompany" Type="Str">NIC SE</Property>
				<Property Name="MSI_autoselectDrivers" Type="Bool">true</Property>
				<Property Name="MSI_distID" Type="Str">{848F8109-331F-475B-9EEC-DB01B352F467}</Property>
				<Property Name="MSI_hideNonRuntimes" Type="Bool">true</Property>
				<Property Name="MSI_osCheck" Type="Int">0</Property>
				<Property Name="MSI_upgradeCode" Type="Str">{772D42A5-7D01-42F7-937E-0A2AF958322E}</Property>
				<Property Name="RegDest[0].dirName" Type="Str">Software</Property>
				<Property Name="RegDest[0].dirTag" Type="Str">{DDFAFC8B-E728-4AC8-96DE-B920EBB97A86}</Property>
				<Property Name="RegDest[0].parentTag" Type="Str">2</Property>
				<Property Name="RegDestCount" Type="Int">1</Property>
				<Property Name="Source[0].dest" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Source[0].name" Type="Str">InstallToGAC.exe</Property>
				<Property Name="Source[0].tag" Type="Ref">/My Computer/GAC Utilities/InstallToGAC.exe</Property>
				<Property Name="Source[0].type" Type="Str">File</Property>
				<Property Name="Source[1].dest" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Source[1].name" Type="Str">NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[1].tag" Type="Ref">/My Computer/VeriStandStepsAssembly/NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[1].type" Type="Str">File</Property>
				<Property Name="Source[10].dest" Type="Str">{A2981AF9-DE20-4DB4-94EC-597288B5F23D}</Property>
				<Property Name="Source[10].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[10].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[10].type" Type="Str">File</Property>
				<Property Name="Source[11].dest" Type="Str">{E2C476E5-6CCC-4AD4-B946-A602E8C945B9}</Property>
				<Property Name="Source[11].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[11].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[11].type" Type="Str">File</Property>
				<Property Name="Source[12].dest" Type="Str">{E2C476E5-6CCC-4AD4-B946-A602E8C945B9}</Property>
				<Property Name="Source[12].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[12].tag" Type="Ref">/My Computer/Packed Libraries/x64/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[12].type" Type="Str">File</Property>
				<Property Name="Source[13].dest" Type="Str">{B86CD178-DDCE-40A6-82AB-AB34427A454F}</Property>
				<Property Name="Source[13].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[13].tag" Type="Ref">/My Computer/Packed Libraries/x64/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[13].type" Type="Str">File</Property>
				<Property Name="Source[14].dest" Type="Str">{B86CD178-DDCE-40A6-82AB-AB34427A454F}</Property>
				<Property Name="Source[14].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[14].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[14].type" Type="Str">File</Property>
				<Property Name="Source[15].dest" Type="Str">{04A93A51-C323-4921-8AA0-B0BEFE82DF61}</Property>
				<Property Name="Source[15].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[15].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[15].type" Type="Str">File</Property>
				<Property Name="Source[16].dest" Type="Str">{04A93A51-C323-4921-8AA0-B0BEFE82DF61}</Property>
				<Property Name="Source[16].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[16].tag" Type="Ref">/My Computer/Packed Libraries/x64/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[16].type" Type="Str">File</Property>
				<Property Name="Source[17].dest" Type="Str">{42F4D869-DC12-49C3-899F-1EF5F9B25DD6}</Property>
				<Property Name="Source[17].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[17].tag" Type="Ref">/My Computer/Packed Libraries/x86/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[17].type" Type="Str">File</Property>
				<Property Name="Source[18].dest" Type="Str">{CB915E63-F77E-4386-AA08-7813B421EF17}</Property>
				<Property Name="Source[18].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[18].tag" Type="Ref">/My Computer/Packed Libraries/x86/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[18].type" Type="Str">File</Property>
				<Property Name="Source[19].dest" Type="Str">{265654FD-C930-4215-A4A0-34E2D4B94207}</Property>
				<Property Name="Source[19].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[19].tag" Type="Ref">/My Computer/Packed Libraries/x86/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[19].type" Type="Str">File</Property>
				<Property Name="Source[2].dest" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Source[2].name" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Source[2].runEXE" Type="Bool">true</Property>
				<Property Name="Source[2].tag" Type="Ref">/My Computer/Install Actions/PostInstallAction.exe</Property>
				<Property Name="Source[2].type" Type="Str">File</Property>
				<Property Name="Source[20].dest" Type="Str">{265654FD-C930-4215-A4A0-34E2D4B94207}</Property>
				<Property Name="Source[20].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[20].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[20].type" Type="Str">File</Property>
				<Property Name="Source[21].dest" Type="Str">{CB915E63-F77E-4386-AA08-7813B421EF17}</Property>
				<Property Name="Source[21].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[21].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[21].type" Type="Str">File</Property>
				<Property Name="Source[22].dest" Type="Str">{42F4D869-DC12-49C3-899F-1EF5F9B25DD6}</Property>
				<Property Name="Source[22].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[22].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[22].type" Type="Str">File</Property>
				<Property Name="Source[23].dest" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Source[23].name" Type="Str">LICENSE.txt</Property>
				<Property Name="Source[23].tag" Type="Ref">/My Computer/License/LICENSE.txt</Property>
				<Property Name="Source[23].type" Type="Str">File</Property>
				<Property Name="Source[3].dest" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Source[3].name" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Source[3].runEXE_uninstall" Type="Bool">true</Property>
				<Property Name="Source[3].tag" Type="Ref">/My Computer/Install Actions/PreUninstallAction.exe</Property>
				<Property Name="Source[3].type" Type="Str">File</Property>
				<Property Name="Source[4].dest" Type="Str">{D217104D-D4A1-46B5-BDF1-D31BF7C8204A}</Property>
				<Property Name="Source[4].name" Type="Str">RemoveFromGAC.exe</Property>
				<Property Name="Source[4].tag" Type="Ref">/My Computer/GAC Utilities/RemoveFromGAC.exe</Property>
				<Property Name="Source[4].type" Type="Str">File</Property>
				<Property Name="Source[5].dest" Type="Str">{208D8916-E177-46B4-AB4F-AD24A3BBCDED}</Property>
				<Property Name="Source[5].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[5].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[5].type" Type="Str">File</Property>
				<Property Name="Source[6].dest" Type="Str">{F2D31B52-5AD1-4E13-821D-381E5459530C}</Property>
				<Property Name="Source[6].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[6].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[6].type" Type="Str">File</Property>
				<Property Name="Source[7].dest" Type="Str">{6D564DF2-C025-4298-A5A8-C8A33D303E34}</Property>
				<Property Name="Source[7].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[7].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[7].type" Type="Str">File</Property>
				<Property Name="Source[8].dest" Type="Str">{12D23933-1584-4A6D-9CA9-641A86AE7B0D}</Property>
				<Property Name="Source[8].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[8].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[8].type" Type="Str">File</Property>
				<Property Name="Source[9].dest" Type="Str">{98473B90-D7F4-4236-9CE1-E18830E362CD}</Property>
				<Property Name="Source[9].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[9].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[9].type" Type="Str">File</Property>
				<Property Name="SourceCount" Type="Int">24</Property>
			</Item>
			<Item Name="Post Install Action" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{84BBF4BC-FA74-43EA-A06D-9CE7D81B3058}</Property>
				<Property Name="App_INI_GUID" Type="Str">{FDE31525-CC3F-4974-925C-EA6D0551BBD2}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{A230D1A5-26E7-4913-9D60-7CDF1896B358}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Post Install Action</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../build_temp</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_postActionVIID" Type="Ref">/My Computer/BuildVIs.lvlib/Post-Build Action Post Pre Install.vi</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{73976618-ACA5-447B-B1E0-43DFC41BBBDE}</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../build_temp/PostInstallAction.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../build_temp/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Source[0].itemID" Type="Str">{1AD98DB4-26C3-44E1-98E3-84E757F74738}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Install Actions/Post-Install Action.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Post Install Action</Property>
				<Property Name="TgtF_internalName" Type="Str">Post Install Action</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2018 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">Post Install Action</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{665EBAA1-8110-404C-987A-6C035878C6E0}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">PostInstallAction.exe</Property>
			</Item>
			<Item Name="Pre Uninstall Action" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{75877B54-405C-46EB-9CA6-59177D7B20F4}</Property>
				<Property Name="App_INI_GUID" Type="Str">{0C67CD90-2E8D-458C-9E25-F2776C0F53DE}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{2CCBFE03-3BA1-4C03-8297-0B2CDBAB5F42}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Pre Uninstall Action</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../build_temp</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_postActionVIID" Type="Ref">/My Computer/BuildVIs.lvlib/Post-Build Action Post Pre Install.vi</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{CE2B453B-BC02-44A3-9391-FE22B26BE852}</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../build_temp/PreUninstallAction.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../build_temp/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Source[0].itemID" Type="Str">{1AD98DB4-26C3-44E1-98E3-84E757F74738}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Install Actions/Pre-Uninstall Action.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Pre Uninstall Action</Property>
				<Property Name="TgtF_internalName" Type="Str">Pre Uninstall Action</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2018 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">Pre Uninstall Action</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{5A0734FB-E5DE-461A-AB57-FE9BAF55AFB4}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">PreUninstallAction.exe</Property>
			</Item>
		</Item>
	</Item>
</Project>
