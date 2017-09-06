<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="14008000">
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
		<Item Name="GAC Install Utilities" Type="Folder">
			<Item Name="InstallToGAC.exe" Type="Document" URL="../../../CSharp/InstallToGAC/InstallToGAC.exe"/>
			<Item Name="RemoveFromGAC.exe" Type="Document" URL="../../../CSharp/RemoveFromGAC/RemoveFromGAC.exe"/>
		</Item>
		<Item Name="Install Actions" Type="Folder">
			<Item Name="Post-Install Action.vi" Type="VI" URL="../Actions/Post-Install Action.vi"/>
			<Item Name="PostInstallAction.aliases" Type="Document" URL="../../../../build_temp/PostInstallAction.aliases"/>
			<Item Name="PostInstallAction.exe" Type="Document" URL="../../../../build_temp/PostInstallAction.exe"/>
			<Item Name="PostInstallAction.ini" Type="Document" URL="../../../../build_temp/PostInstallAction.ini"/>
			<Item Name="Pre-Build Action.vi" Type="VI" URL="../Actions/Pre-Build Action.vi"/>
			<Item Name="Pre-Uninstall Action.vi" Type="VI" URL="../Actions/Pre-Uninstall Action.vi"/>
			<Item Name="PreUninstallAction.aliases" Type="Document" URL="../../../../build_temp/PreUninstallAction.aliases"/>
			<Item Name="PreUninstallAction.exe" Type="Document" URL="../../../../build_temp/PreUninstallAction.exe"/>
			<Item Name="PreUninstallAction.ini" Type="Document" URL="../../../../build_temp/PreUninstallAction.ini"/>
		</Item>
		<Item Name="Install Log File" Type="Folder">
			<Item Name="veristand_steps_install_log.txt" Type="Document" URL="../veristand_steps_install_log.txt"/>
		</Item>
		<Item Name="PPLs" Type="Folder">
			<Item Name="Logging.lvlibp" Type="LVLibp" URL="../../../../build_temp/Logging.lvlibp"/>
			<Item Name="MiscHelperVIs.lvlibp" Type="LVLibp" URL="../../../../build_temp/MiscHelperVIs.lvlibp"/>
			<Item Name="RTSequenceVIs.lvlibp" Type="LVLibp" URL="../../../../build_temp/RTSequenceVIs.lvlibp"/>
			<Item Name="Set Channels.lvlibp" Type="LVLibp" URL="../../../../build_temp/Set Channels.lvlibp"/>
		</Item>
		<Item Name="Silent VeriStand Executable" Type="Folder">
			<Item Name="SilentVeriStand.exe" Type="Document" URL="../../../../build_temp/SilentVeriStand.exe"/>
		</Item>
		<Item Name="subVIs" Type="Folder">
			<Item Name="Log.RetrievePaths.vi" Type="VI" URL="../subVIs/Log.RetrievePaths.vi"/>
			<Item Name="Log.StorePaths.vi" Type="VI" URL="../subVIs/Log.StorePaths.vi"/>
			<Item Name="PreUninstall.RemoveFiles.vi" Type="VI" URL="../subVIs/PreUninstall.RemoveFiles.vi"/>
		</Item>
		<Item Name="TypePalette File" Type="Folder">
			<Item Name="NI_VeristandTypes.ini" Type="Document" URL="../../../../build_temp/NI_VeristandTypes.ini"/>
			<Item Name="Veristand_icon_vista.ico" Type="Document" URL="../../../../build_temp/Veristand_icon_vista.ico"/>
		</Item>
		<Item Name="Types" Type="Folder">
			<Item Name="Components Directory Install Files String Array.ctl" Type="VI" URL="../Types/Components Directory Install Files String Array.ctl"/>
		</Item>
		<Item Name="VeristandSteps Assembly" Type="Folder">
			<Item Name="NationalInstruments.Veristand.VeristandSteps.dll" Type="Document" URL="../../../../build_temp/NationalInstruments.Veristand.VeristandSteps.dll"/>
		</Item>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Application Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/file.llb/Application Directory.vi"/>
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
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
			<Item Name="Post Install Action" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{63DF8DB3-B9EB-44E4-BD07-A349216AECC8}</Property>
				<Property Name="App_INI_GUID" Type="Str">{AB27C412-FB06-4A10-8D17-4E77E6E7EC57}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{1C68C13D-F4C0-4D4E-941A-368C896DC504}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Post Install Action</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{B304BD25-3C20-4104-8DAF-694A7DC08EDC}</Property>
				<Property Name="Bld_version.build" Type="Int">50</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/PostInstallAction.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{F4ECBAD1-C8A2-4DCB-B04F-0D4FD1F1A9E4}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Install Actions/Pre-Build Action.vi</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="Source[2].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[2].itemID" Type="Ref">/My Computer/Install Actions/Post-Install Action.vi</Property>
				<Property Name="Source[2].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[2].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">3</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Post Install Action</Property>
				<Property Name="TgtF_internalName" Type="Str">Post Install Action</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">Post Install Action</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{6B1F5EA1-F3F7-42B3-822A-6F64DBEACC14}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">PostInstallAction.exe</Property>
			</Item>
			<Item Name="Pre Uninstall Action" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{A5D2564D-812F-4E72-A539-4378F6430D98}</Property>
				<Property Name="App_INI_GUID" Type="Str">{FBFEF369-B5C2-4853-B6C8-007460721629}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{CFD21FFA-5876-4A43-9FC1-1DF8421A9368}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Pre Uninstall Action</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{DB3A548B-1162-40B0-A1A9-44D31209883C}</Property>
				<Property Name="Bld_version.build" Type="Int">8</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/PreUninstallAction.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{F4ECBAD1-C8A2-4DCB-B04F-0D4FD1F1A9E4}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Install Actions/Pre-Uninstall Action.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Pre Uninstall Action</Property>
				<Property Name="TgtF_internalName" Type="Str">Pre Uninstall Action</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">Pre Uninstall Action</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{6A868695-0396-416C-B3C6-331127C1834F}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">PreUninstallAction.exe</Property>
			</Item>
			<Item Name="VeriStand Custom Step Types" Type="Installer">
				<Property Name="Destination[0].name" Type="Str">VeriStand 2014 Custom Step Types</Property>
				<Property Name="Destination[0].parent" Type="Str">{3912416A-D2E5-411B-AFEE-B63654D690C0}</Property>
				<Property Name="Destination[0].tag" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Destination[0].type" Type="Str">userFolder</Property>
				<Property Name="Destination[1].name" Type="Str">National Instruments</Property>
				<Property Name="Destination[1].parent" Type="Str">{3912416A-D2E5-411B-AFEE-B63654D690C0}</Property>
				<Property Name="Destination[1].tag" Type="Str">{17DAAC9C-E192-4350-B727-6F41C6E35DE0}</Property>
				<Property Name="Destination[1].type" Type="Str">userFolder</Property>
				<Property Name="Destination[10].name" Type="Str">Icons</Property>
				<Property Name="Destination[10].parent" Type="Str">{FC770C68-A456-41BE-B3EA-F8A5A2087763}</Property>
				<Property Name="Destination[10].tag" Type="Str">{968110B2-0B8A-47E2-8AF7-B02E77CECE2C}</Property>
				<Property Name="Destination[10].type" Type="Str">userFolder</Property>
				<Property Name="Destination[2].name" Type="Str">NI VeriStand 2014</Property>
				<Property Name="Destination[2].parent" Type="Str">{17DAAC9C-E192-4350-B727-6F41C6E35DE0}</Property>
				<Property Name="Destination[2].tag" Type="Str">{07CB2EDC-AE7E-4885-8E98-72AAB33FFEBB}</Property>
				<Property Name="Destination[2].type" Type="Str">userFolder</Property>
				<Property Name="Destination[3].name" Type="Str">Users</Property>
				<Property Name="Destination[3].parent" Type="Str">{C63B6F86-C439-4240-9AAE-EC6A9DDD0A29}</Property>
				<Property Name="Destination[3].tag" Type="Str">{C06F42D9-8548-4D1E-8C81-A5F0400B34FC}</Property>
				<Property Name="Destination[3].type" Type="Str">userFolder</Property>
				<Property Name="Destination[4].name" Type="Str">Public</Property>
				<Property Name="Destination[4].parent" Type="Str">{C06F42D9-8548-4D1E-8C81-A5F0400B34FC}</Property>
				<Property Name="Destination[4].tag" Type="Str">{F9BFCB0A-3881-447F-9DE7-8BFE6068B4CC}</Property>
				<Property Name="Destination[4].type" Type="Str">userFolder</Property>
				<Property Name="Destination[5].name" Type="Str">Documents</Property>
				<Property Name="Destination[5].parent" Type="Str">{F9BFCB0A-3881-447F-9DE7-8BFE6068B4CC}</Property>
				<Property Name="Destination[5].tag" Type="Str">{8B54A63F-F1CA-47EE-95D3-F3152757A407}</Property>
				<Property Name="Destination[5].type" Type="Str">userFolder</Property>
				<Property Name="Destination[6].name" Type="Str">National Instruments</Property>
				<Property Name="Destination[6].parent" Type="Str">{8B54A63F-F1CA-47EE-95D3-F3152757A407}</Property>
				<Property Name="Destination[6].tag" Type="Str">{F434B829-AA04-43D8-AB92-6BE88BF55E0F}</Property>
				<Property Name="Destination[6].type" Type="Str">userFolder</Property>
				<Property Name="Destination[7].name" Type="Str">TestStand 2014 (32-bit)</Property>
				<Property Name="Destination[7].parent" Type="Str">{F434B829-AA04-43D8-AB92-6BE88BF55E0F}</Property>
				<Property Name="Destination[7].tag" Type="Str">{C4C299A5-A16B-4251-A638-73B631234187}</Property>
				<Property Name="Destination[7].type" Type="Str">userFolder</Property>
				<Property Name="Destination[8].name" Type="Str">Components</Property>
				<Property Name="Destination[8].parent" Type="Str">{C4C299A5-A16B-4251-A638-73B631234187}</Property>
				<Property Name="Destination[8].tag" Type="Str">{FC770C68-A456-41BE-B3EA-F8A5A2087763}</Property>
				<Property Name="Destination[8].type" Type="Str">userFolder</Property>
				<Property Name="Destination[9].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[9].parent" Type="Str">{FC770C68-A456-41BE-B3EA-F8A5A2087763}</Property>
				<Property Name="Destination[9].tag" Type="Str">{3370C310-171D-4863-93D3-AF04A10FD864}</Property>
				<Property Name="Destination[9].type" Type="Str">userFolder</Property>
				<Property Name="DestinationCount" Type="Int">11</Property>
				<Property Name="INST_author" Type="Str">NIC SE</Property>
				<Property Name="INST_autoIncrement" Type="Bool">true</Property>
				<Property Name="INST_buildLocation" Type="Path">../Installer/builds/Installer</Property>
				<Property Name="INST_buildLocation.type" Type="Str">relativeToCommon</Property>
				<Property Name="INST_buildSpecName" Type="Str">VeriStand Custom Step Types</Property>
				<Property Name="INST_defaultDir" Type="Str">{C4C299A5-A16B-4251-A638-73B631234187}</Property>
				<Property Name="INST_includeError" Type="Bool">false</Property>
				<Property Name="INST_productName" Type="Str">VeriStand 2014 Custom Step Types</Property>
				<Property Name="INST_productVersion" Type="Str">1.0.57</Property>
				<Property Name="InstSpecBitness" Type="Str">32-bit</Property>
				<Property Name="InstSpecVersion" Type="Str">14018008</Property>
				<Property Name="MSI_arpCompany" Type="Str">National Instruments Systems Engineering</Property>
				<Property Name="MSI_distID" Type="Str">{A0B7C8E1-FF10-47F6-A81C-FAC474B85E1E}</Property>
				<Property Name="MSI_osCheck" Type="Int">0</Property>
				<Property Name="MSI_upgradeCode" Type="Str">{B5B389F1-0845-417E-8767-FF8FBBD2EC6B}</Property>
				<Property Name="Source[0].dest" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Source[0].name" Type="Str">veristand_steps_install_log.txt</Property>
				<Property Name="Source[0].tag" Type="Ref">/My Computer/Install Log File/veristand_steps_install_log.txt</Property>
				<Property Name="Source[0].type" Type="Str">File</Property>
				<Property Name="Source[1].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[1].name" Type="Str">InstallToGAC.exe</Property>
				<Property Name="Source[1].tag" Type="Ref">/My Computer/GAC Install Utilities/InstallToGAC.exe</Property>
				<Property Name="Source[1].type" Type="Str">File</Property>
				<Property Name="Source[10].dest" Type="Str">{3370C310-171D-4863-93D3-AF04A10FD864}</Property>
				<Property Name="Source[10].name" Type="Str">RTSequenceVIs.lvlibp</Property>
				<Property Name="Source[10].tag" Type="Ref">/My Computer/PPLs/RTSequenceVIs.lvlibp</Property>
				<Property Name="Source[10].type" Type="Str">File</Property>
				<Property Name="Source[11].dest" Type="Str">{3370C310-171D-4863-93D3-AF04A10FD864}</Property>
				<Property Name="Source[11].name" Type="Str">Set Channels.lvlibp</Property>
				<Property Name="Source[11].tag" Type="Ref">/My Computer/PPLs/Set Channels.lvlibp</Property>
				<Property Name="Source[11].type" Type="Str">File</Property>
				<Property Name="Source[12].dest" Type="Str">{968110B2-0B8A-47E2-8AF7-B02E77CECE2C}</Property>
				<Property Name="Source[12].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[12].tag" Type="Ref">/My Computer/TypePalette File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[12].type" Type="Str">File</Property>
				<Property Name="Source[2].dest" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Source[2].name" Type="Str">RemoveFromGAC.exe</Property>
				<Property Name="Source[2].tag" Type="Ref">/My Computer/GAC Install Utilities/RemoveFromGAC.exe</Property>
				<Property Name="Source[2].type" Type="Str">File</Property>
				<Property Name="Source[3].cmdArg" Type="Str">2014 2014</Property>
				<Property Name="Source[3].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[3].name" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Source[3].runEXE" Type="Bool">true</Property>
				<Property Name="Source[3].tag" Type="Ref">/My Computer/Install Actions/PostInstallAction.exe</Property>
				<Property Name="Source[3].type" Type="Str">File</Property>
				<Property Name="Source[4].cmdArg_uninstall" Type="Str">2014 </Property>
				<Property Name="Source[4].dest" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Source[4].name" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Source[4].runEXE_uninstall" Type="Bool">true</Property>
				<Property Name="Source[4].tag" Type="Ref">/My Computer/Install Actions/PreUninstallAction.exe</Property>
				<Property Name="Source[4].type" Type="Str">File</Property>
				<Property Name="Source[5].dest" Type="Str">{07CB2EDC-AE7E-4885-8E98-72AAB33FFEBB}</Property>
				<Property Name="Source[5].name" Type="Str">SilentVeriStand.exe</Property>
				<Property Name="Source[5].tag" Type="Ref">/My Computer/Silent VeriStand Executable/SilentVeriStand.exe</Property>
				<Property Name="Source[5].type" Type="Str">File</Property>
				<Property Name="Source[6].dest" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Source[6].name" Type="Str">NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[6].tag" Type="Ref">/My Computer/VeristandSteps Assembly/NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[6].type" Type="Str">File</Property>
				<Property Name="Source[7].dest" Type="Str">{3370C310-171D-4863-93D3-AF04A10FD864}</Property>
				<Property Name="Source[7].name" Type="Str">Logging.lvlibp</Property>
				<Property Name="Source[7].tag" Type="Ref">/My Computer/PPLs/Logging.lvlibp</Property>
				<Property Name="Source[7].type" Type="Str">File</Property>
				<Property Name="Source[8].dest" Type="Str">{3370C310-171D-4863-93D3-AF04A10FD864}</Property>
				<Property Name="Source[8].name" Type="Str">MiscHelperVIs.lvlibp</Property>
				<Property Name="Source[8].tag" Type="Ref">/My Computer/PPLs/MiscHelperVIs.lvlibp</Property>
				<Property Name="Source[8].type" Type="Str">File</Property>
				<Property Name="Source[9].dest" Type="Str">{3370C310-171D-4863-93D3-AF04A10FD864}</Property>
				<Property Name="Source[9].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[9].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[9].type" Type="Str">File</Property>
				<Property Name="SourceCount" Type="Int">13</Property>
			</Item>
		</Item>
	</Item>
</Project>
