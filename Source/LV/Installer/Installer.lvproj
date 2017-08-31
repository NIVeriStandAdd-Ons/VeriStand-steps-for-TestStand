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
			<Item Name="InstallToGAC.exe" Type="Document" URL="../../../C# Code/InstallToGAC/InstallToGAC.exe"/>
			<Item Name="RemoveFromGAC.exe" Type="Document" URL="../../../C# Code/RemoveFromGAC/RemoveFromGAC.exe"/>
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
			<Item Name="Logging.lvlibp" Type="LVLibp" URL="../../../../build_temp/Logging.lvlibp">
				<Item Name="Start Logging" Type="Folder">
					<Item Name="AddLoggingGlobals.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/AddLoggingGlobals.vi"/>
					<Item Name="dummy menu vi.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/dummy menu vi.vi"/>
					<Item Name="Start logging.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/Start logging.vi"/>
				</Item>
				<Item Name="Stop Logging" Type="Folder">
					<Item Name="Stop Logging.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/Stop Logging.vi"/>
				</Item>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/1abvi3w/vi.lib/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="MergeError.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Shared/MergeError.vi"/>
				<Item Name="NI_VS Data Logging API.lvlib" Type="Library" URL="../../../../build_temp/Logging.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/DataLogging/NI_VS Data Logging API.lvlib"/>
				<Item Name="NI_VS Workspace ExecutionAPI.lvlib" Type="Library" URL="../../../../build_temp/Logging.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Workspace/NI_VS Workspace ExecutionAPI.lvlib"/>
				<Item Name="To .NET Object.vi" Type="VI" URL="../../../../build_temp/Logging.lvlibp/1abvi3w/vi.lib/Platform/dotnet.llb/To .NET Object.vi"/>
				<Item Name="VariantType.lvlib" Type="Library" URL="../../../../build_temp/Logging.lvlibp/1abvi3w/vi.lib/Utility/VariantDataType/VariantType.lvlib"/>
			</Item>
			<Item Name="MiscHelperVIs.lvlibp" Type="LVLibp" URL="../../../../build_temp/MiscHelperVIs.lvlibp">
				<Item Name="Create Reference Locals.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/Create Reference Locals.vi"/>
				<Item Name="Create Reference Locals_Mod.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/Create Reference Locals_Mod.vi"/>
				<Item Name="Get System Directory.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/1abvi3w/vi.lib/Utility/sysdir.llb/Get System Directory.vi"/>
				<Item Name="Launch NIVS.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/Launch NIVS.vi"/>
				<Item Name="NI_VS Workspace ExecutionAPI.lvlib" Type="Library" URL="../../../../build_temp/MiscHelperVIs.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Workspace/NI_VS Workspace ExecutionAPI.lvlib"/>
				<Item Name="OpenVS(Silent).vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/OpenVS(Silent).vi"/>
				<Item Name="OpenVS.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/OpenVS.vi"/>
				<Item Name="PassThrough.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/PassThrough.vi"/>
				<Item Name="Space Constant.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/1abvi3w/vi.lib/dlg_ctls.llb/Space Constant.vi"/>
				<Item Name="StartVeriStandBundle_Create Reference Locals.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/StartVeriStandBundle_Create Reference Locals.vi"/>
				<Item Name="System Directory Type.ctl" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/1abvi3w/vi.lib/Utility/sysdir.llb/System Directory Type.ctl"/>
				<Item Name="System Exec.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/1abvi3w/vi.lib/Platform/system.llb/System Exec.vi"/>
				<Item Name="WINAPI Is 64 Bit OS.vi" Type="VI" URL="../../../../build_temp/MiscHelperVIs.lvlibp/WINAPI Is 64 Bit OS.vi"/>
			</Item>
			<Item Name="RTSequenceVIs.lvlibp" Type="LVLibp" URL="../../../../build_temp/RTSequenceVIs.lvlibp">
				<Item Name="Build Parameter Assignment Array.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Build Parameter Assignment Array.vi"/>
				<Item Name="Expression Array String to Expression Array.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Expression Array String to Expression Array.vi"/>
				<Item Name="MergeError.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Shared/MergeError.vi"/>
				<Item Name="NI_VS Sequence Execution Interface.lvlib" Type="Library" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/SequenceExecutionInterface/NI_VS Sequence Execution Interface.lvlib"/>
				<Item Name="NI_VS Workspace ExecutionAPI.lvlib" Type="Library" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Workspace/NI_VS Workspace ExecutionAPI.lvlib"/>
				<Item Name="Open and Deploy RT Sequence blocking call.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Open and Deploy RT Sequence blocking call.vi"/>
				<Item Name="Remove First and Last Characters.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Remove First and Last Characters.vi"/>
				<Item Name="Run RT Sequence Numeric Limit Test.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Run RT Sequence Numeric Limit Test.vi"/>
				<Item Name="Run RT Sequence Pass Fail Test.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Run RT Sequence Pass Fail Test.vi"/>
				<Item Name="Run Stimulus Profile.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/Run Stimulus Profile.vi"/>
				<Item Name="TestStand - Close Termination Monitor.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Close Termination Monitor.vi"/>
				<Item Name="TestStand - Get Termination Monitor Status.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Get Termination Monitor Status.vi"/>
				<Item Name="TestStand - Initialize Termination Monitor.vi" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Initialize Termination Monitor.vi"/>
				<Item Name="TestStand - Status Monitor.ctl" Type="VI" URL="../../../../build_temp/RTSequenceVIs.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Status Monitor.ctl"/>
			</Item>
			<Item Name="Set Channels.lvlibp" Type="LVLibp" URL="../../../../build_temp/Set Channels.lvlibp">
				<Item Name="MergeError.vi" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Shared/MergeError.vi"/>
				<Item Name="NI_VS Workspace ExecutionAPI.lvlib" Type="Library" URL="../../../../build_temp/Set Channels.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Workspace/NI_VS Workspace ExecutionAPI.lvlib"/>
				<Item Name="Set Channel.vi" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/Set Channel.vi"/>
				<Item Name="Set multiple channels.vi" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/Set multiple channels.vi"/>
				<Item Name="TestStand - Close Termination Monitor.vi" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Close Termination Monitor.vi"/>
				<Item Name="TestStand - Get Termination Monitor Status.vi" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Get Termination Monitor Status.vi"/>
				<Item Name="TestStand - Initialize Termination Monitor.vi" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Initialize Termination Monitor.vi"/>
				<Item Name="TestStand - Status Monitor.ctl" Type="VI" URL="../../../../build_temp/Set Channels.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Status Monitor.ctl"/>
			</Item>
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
			<Item Name="Veristand_icon_vista.ico" Type="Document" URL="../../../TypePalette INI File/Veristand_icon_vista.ico"/>
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
				<Item Name="List Directory and LLBs.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/List Directory and LLBs.vi"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="LVRectTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVRectTypeDef.ctl"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Recursive File List.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Recursive File List.vi"/>
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
			<Item Name="kernel32.dll" Type="Document" URL="kernel32.dll">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="mscorlib" Type="VI" URL="mscorlib">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="NationalInstruments.VeriStand" Type="Document" URL="NationalInstruments.VeriStand">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="NationalInstruments.VeriStand.ClientAPI" Type="Document" URL="NationalInstruments.VeriStand.ClientAPI">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="NationalInstruments.VeriStand.DataTypes" Type="Document" URL="NationalInstruments.VeriStand.DataTypes">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi" Type="Document" URL="NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
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
				<Property Name="Bld_localDestDir" Type="Path">../builds/Actions/Post Install Action</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{B304BD25-3C20-4104-8DAF-694A7DC08EDC}</Property>
				<Property Name="Bld_version.build" Type="Int">50</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/Actions/Post Install Action/PostInstallAction.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/Actions/Post Install Action/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{D3DC109C-4A90-40FF-941F-0F00DBC9F683}</Property>
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
				<Property Name="Bld_localDestDir" Type="Path">../builds/Actions/Pre Uninstall Action</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{DB3A548B-1162-40B0-A1A9-44D31209883C}</Property>
				<Property Name="Bld_version.build" Type="Int">8</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/Actions/Pre Uninstall Action/PreUninstallAction.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/Actions/Pre Uninstall Action/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{4105C8D8-1D8E-4823-B344-D5332EF66AF7}</Property>
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
				<Property Name="Destination[0].name" Type="Str">VeriStand Custom Step Types 2016</Property>
				<Property Name="Destination[0].parent" Type="Str">{3912416A-D2E5-411B-AFEE-B63654D690C0}</Property>
				<Property Name="Destination[0].tag" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Destination[0].type" Type="Str">userFolder</Property>
				<Property Name="DestinationCount" Type="Int">1</Property>
				<Property Name="INST_author" Type="Str">NIC SE</Property>
				<Property Name="INST_autoIncrement" Type="Bool">true</Property>
				<Property Name="INST_buildLocation" Type="Path">../Installer/builds/Installer</Property>
				<Property Name="INST_buildLocation.type" Type="Str">relativeToCommon</Property>
				<Property Name="INST_buildSpecName" Type="Str">VeriStand Custom Step Types</Property>
				<Property Name="INST_defaultDir" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="INST_productName" Type="Str">VeriStand Custom Step Types 2016</Property>
				<Property Name="INST_productVersion" Type="Str">1.0.57</Property>
				<Property Name="InstSpecBitness" Type="Str">32-bit</Property>
				<Property Name="InstSpecVersion" Type="Str">14018008</Property>
				<Property Name="MSI_arpCompany" Type="Str">National Instruments Systems Engineering</Property>
				<Property Name="MSI_distID" Type="Str">{A0B7C8E1-FF10-47F6-A81C-FAC474B85E1E}</Property>
				<Property Name="MSI_osCheck" Type="Int">0</Property>
				<Property Name="MSI_upgradeCode" Type="Str">{B5B389F1-0845-417E-8767-FF8FBBD2EC6B}</Property>
				<Property Name="Source[0].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[0].name" Type="Str">Logging.lvlibp</Property>
				<Property Name="Source[0].tag" Type="Ref">/My Computer/PPLs/Logging.lvlibp</Property>
				<Property Name="Source[0].type" Type="Str">File</Property>
				<Property Name="Source[1].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[1].name" Type="Str">MiscHelperVIs.lvlibp</Property>
				<Property Name="Source[1].tag" Type="Ref">/My Computer/PPLs/MiscHelperVIs.lvlibp</Property>
				<Property Name="Source[1].type" Type="Str">File</Property>
				<Property Name="Source[10].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[10].name" Type="Str">PostInstallAction.ini</Property>
				<Property Name="Source[10].tag" Type="Ref">/My Computer/Install Actions/PostInstallAction.ini</Property>
				<Property Name="Source[10].type" Type="Str">File</Property>
				<Property Name="Source[11].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[11].File[0].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[11].File[0].name" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Source[11].File[0].Shortcut[0].destIndex" Type="Int">0</Property>
				<Property Name="Source[11].File[0].Shortcut[0].name" Type="Str">PreUninstallAction</Property>
				<Property Name="Source[11].File[0].Shortcut[0].subDir" Type="Str">VeriStand Custom Step Types 2016</Property>
				<Property Name="Source[11].File[0].tag" Type="Str">{6A868695-0396-416C-B3C6-331127C1834F}</Property>
				<Property Name="Source[11].name" Type="Str">PreUninstallAction.aliases</Property>
				<Property Name="Source[11].tag" Type="Ref">/My Computer/Install Actions/PreUninstallAction.aliases</Property>
				<Property Name="Source[11].type" Type="Str">File</Property>
				<Property Name="Source[12].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[12].name" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Source[12].tag" Type="Ref">/My Computer/Install Actions/PreUninstallAction.exe</Property>
				<Property Name="Source[12].type" Type="Str">File</Property>
				<Property Name="Source[13].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[13].name" Type="Str">PreUninstallAction.ini</Property>
				<Property Name="Source[13].tag" Type="Ref">/My Computer/Install Actions/PreUninstallAction.ini</Property>
				<Property Name="Source[13].type" Type="Str">File</Property>
				<Property Name="Source[14].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[14].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[14].tag" Type="Ref">/My Computer/TypePalette File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[14].type" Type="Str">File</Property>
				<Property Name="Source[15].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[15].name" Type="Str">InstallToGAC.exe</Property>
				<Property Name="Source[15].tag" Type="Ref">/My Computer/GAC Install Utilities/InstallToGAC.exe</Property>
				<Property Name="Source[15].type" Type="Str">File</Property>
				<Property Name="Source[16].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[16].name" Type="Str">RemoveFromGAC.exe</Property>
				<Property Name="Source[16].tag" Type="Ref">/My Computer/GAC Install Utilities/RemoveFromGAC.exe</Property>
				<Property Name="Source[16].type" Type="Str">File</Property>
				<Property Name="Source[2].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[2].name" Type="Str">RTSequenceVIs.lvlibp</Property>
				<Property Name="Source[2].tag" Type="Ref">/My Computer/PPLs/RTSequenceVIs.lvlibp</Property>
				<Property Name="Source[2].type" Type="Str">File</Property>
				<Property Name="Source[3].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[3].name" Type="Str">Set Channels.lvlibp</Property>
				<Property Name="Source[3].tag" Type="Ref">/My Computer/PPLs/Set Channels.lvlibp</Property>
				<Property Name="Source[3].type" Type="Str">File</Property>
				<Property Name="Source[4].dest" Type="Str">{8A84B098-97AA-4F5B-8F0A-427266B807F6}</Property>
				<Property Name="Source[4].File[0].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[4].File[0].name" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Source[4].File[0].tag" Type="Str">{6B1F5EA1-F3F7-42B3-822A-6F64DBEACC14}</Property>
				<Property Name="Source[4].name" Type="Str">veristand_steps_install_log.txt</Property>
				<Property Name="Source[4].tag" Type="Ref">/My Computer/Install Log File/veristand_steps_install_log.txt</Property>
				<Property Name="Source[4].type" Type="Str">File</Property>
				<Property Name="Source[5].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[5].File[0].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[5].File[0].name" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Source[5].File[0].Shortcut[0].destIndex" Type="Int">0</Property>
				<Property Name="Source[5].File[0].Shortcut[0].name" Type="Str">PostInstallAction</Property>
				<Property Name="Source[5].File[0].Shortcut[0].subDir" Type="Str">VeriStand Custom Step Types 2016</Property>
				<Property Name="Source[5].File[0].tag" Type="Str">{6B1F5EA1-F3F7-42B3-822A-6F64DBEACC14}</Property>
				<Property Name="Source[5].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[5].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[5].type" Type="Str">File</Property>
				<Property Name="Source[6].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[6].name" Type="Str">NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[6].tag" Type="Ref">/My Computer/VeristandSteps Assembly/NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[6].type" Type="Str">File</Property>
				<Property Name="Source[7].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[7].File[0].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[7].File[0].name" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Source[7].File[0].tag" Type="Str">{6A868695-0396-416C-B3C6-331127C1834F}</Property>
				<Property Name="Source[7].name" Type="Str">SilentVeriStand.exe</Property>
				<Property Name="Source[7].tag" Type="Ref">/My Computer/Silent VeriStand Executable/SilentVeriStand.exe</Property>
				<Property Name="Source[7].type" Type="Str">File</Property>
				<Property Name="Source[8].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[8].name" Type="Str">PostInstallAction.aliases</Property>
				<Property Name="Source[8].tag" Type="Ref">/My Computer/Install Actions/PostInstallAction.aliases</Property>
				<Property Name="Source[8].type" Type="Str">File</Property>
				<Property Name="Source[9].dest" Type="Str">{B1C272DB-7A45-4FF9-BC63-49FC8311081D}</Property>
				<Property Name="Source[9].name" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Source[9].tag" Type="Ref">/My Computer/Install Actions/PostInstallAction.exe</Property>
				<Property Name="Source[9].type" Type="Str">File</Property>
				<Property Name="SourceCount" Type="Int">17</Property>
			</Item>
			<Item Name="VeriStand Step Types Package" Type="{E661DAE2-7517-431F-AC41-30807A3BDA38}">
				<Property Name="NIPKG_license" Type="Ref"></Property>
				<Property Name="NIPKG_releaseNotes" Type="Str"></Property>
				<Property Name="PKG_actions.Count" Type="Int">0</Property>
				<Property Name="PKG_autoIncrementBuild" Type="Bool">true</Property>
				<Property Name="PKG_buildNumber" Type="Int">1</Property>
				<Property Name="PKG_buildSpecName" Type="Str">VeriStand Step Types Package</Property>
				<Property Name="PKG_dependencies.Count" Type="Int">0</Property>
				<Property Name="PKG_description" Type="Str"></Property>
				<Property Name="PKG_destinations.Count" Type="Int">6</Property>
				<Property Name="PKG_destinations[0].ID" Type="Str">{4AD83A8A-F9B8-48B1-AD05-C0B18FF2CD53}</Property>
				<Property Name="PKG_destinations[0].Subdir.Directory" Type="Str">National Instruments</Property>
				<Property Name="PKG_destinations[0].Subdir.Parent" Type="Str">root_5</Property>
				<Property Name="PKG_destinations[0].Type" Type="Str">Subdir</Property>
				<Property Name="PKG_destinations[1].ID" Type="Str">{5AD47F14-FC6C-40DC-84B8-FCE5BC907A92}</Property>
				<Property Name="PKG_destinations[1].Subdir.Directory" Type="Str">National Instruments</Property>
				<Property Name="PKG_destinations[1].Subdir.Parent" Type="Str">root_2</Property>
				<Property Name="PKG_destinations[1].Type" Type="Str">Subdir</Property>
				<Property Name="PKG_destinations[2].ID" Type="Str">{7DD6CE53-2E67-41EE-ABDC-E8CC0317DFD7}</Property>
				<Property Name="PKG_destinations[2].Subdir.Directory" Type="Str">TestStand 2014 (32-bit)</Property>
				<Property Name="PKG_destinations[2].Subdir.Parent" Type="Str">{5AD47F14-FC6C-40DC-84B8-FCE5BC907A92}</Property>
				<Property Name="PKG_destinations[2].Type" Type="Str">Subdir</Property>
				<Property Name="PKG_destinations[3].ID" Type="Str">{8A6C4811-2550-4DE9-B789-FBFFE9871D9B}</Property>
				<Property Name="PKG_destinations[3].Subdir.Directory" Type="Str">VeriStand Custom Step Types</Property>
				<Property Name="PKG_destinations[3].Subdir.Parent" Type="Str">{4AD83A8A-F9B8-48B1-AD05-C0B18FF2CD53}</Property>
				<Property Name="PKG_destinations[3].Type" Type="Str">Subdir</Property>
				<Property Name="PKG_destinations[4].ID" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_destinations[4].Subdir.Directory" Type="Str">TypePalettes</Property>
				<Property Name="PKG_destinations[4].Subdir.Parent" Type="Str">{C26FBC41-34EF-4A2C-904F-15587B56FE31}</Property>
				<Property Name="PKG_destinations[4].Type" Type="Str">Subdir</Property>
				<Property Name="PKG_destinations[5].ID" Type="Str">{C26FBC41-34EF-4A2C-904F-15587B56FE31}</Property>
				<Property Name="PKG_destinations[5].Subdir.Directory" Type="Str">Components</Property>
				<Property Name="PKG_destinations[5].Subdir.Parent" Type="Str">{7DD6CE53-2E67-41EE-ABDC-E8CC0317DFD7}</Property>
				<Property Name="PKG_destinations[5].Type" Type="Str">Subdir</Property>
				<Property Name="PKG_displayName" Type="Str">My Package</Property>
				<Property Name="PKG_displayVersion" Type="Str"></Property>
				<Property Name="PKG_homepage" Type="Str"></Property>
				<Property Name="PKG_maintainer" Type="Str">NIC SE &lt;&gt;</Property>
				<Property Name="PKG_output" Type="Path">/C/NI Package/VeriStand Step Types</Property>
				<Property Name="PKG_packageName" Type="Str">veristand-step-types-package</Property>
				<Property Name="PKG_ProviderVersion" Type="Int">17</Property>
				<Property Name="PKG_section" Type="Str">Application Software</Property>
				<Property Name="PKG_shortcuts.Count" Type="Int">0</Property>
				<Property Name="PKG_sources.Count" Type="Int">12</Property>
				<Property Name="PKG_sources[0].Destination" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_sources[0].ID" Type="Ref">/My Computer/PPLs/Logging.lvlibp</Property>
				<Property Name="PKG_sources[0].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[1].Destination" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_sources[1].ID" Type="Ref">/My Computer/PPLs/MiscHelperVIs.lvlibp</Property>
				<Property Name="PKG_sources[1].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[10].Destination" Type="Str">root_7</Property>
				<Property Name="PKG_sources[10].ID" Type="Ref">/My Computer/GAC Install Utilities/InstallToGAC.exe</Property>
				<Property Name="PKG_sources[10].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[11].Destination" Type="Str">root_7</Property>
				<Property Name="PKG_sources[11].ID" Type="Ref">/My Computer/GAC Install Utilities/RemoveFromGAC.exe</Property>
				<Property Name="PKG_sources[11].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[2].Destination" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_sources[2].ID" Type="Ref">/My Computer/PPLs/RTSequenceVIs.lvlibp</Property>
				<Property Name="PKG_sources[2].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[3].Destination" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_sources[3].ID" Type="Ref">/My Computer/PPLs/Set Channels.lvlibp</Property>
				<Property Name="PKG_sources[3].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[4].Destination" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_sources[4].ID" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="PKG_sources[4].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[5].Destination" Type="Str">{B1173D03-0D70-4AEB-8E03-3EC08F8BE540}</Property>
				<Property Name="PKG_sources[5].ID" Type="Ref">/My Computer/TypePalette File/Veristand_icon_vista.ico</Property>
				<Property Name="PKG_sources[5].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[6].Destination" Type="Str">root_7</Property>
				<Property Name="PKG_sources[6].ID" Type="Ref">/My Computer/VeristandSteps Assembly/NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="PKG_sources[6].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[7].Destination" Type="Str">{8A6C4811-2550-4DE9-B789-FBFFE9871D9B}</Property>
				<Property Name="PKG_sources[7].ID" Type="Ref">/My Computer/Install Log File/veristand_steps_install_log.txt</Property>
				<Property Name="PKG_sources[7].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[8].Destination" Type="Str">root_7</Property>
				<Property Name="PKG_sources[8].ID" Type="Ref">/My Computer/Install Actions/PostInstallAction.exe</Property>
				<Property Name="PKG_sources[8].Type" Type="Str">File</Property>
				<Property Name="PKG_sources[9].Destination" Type="Str">root_7</Property>
				<Property Name="PKG_sources[9].ID" Type="Ref">/My Computer/Install Actions/PreUninstallAction.exe</Property>
				<Property Name="PKG_sources[9].Type" Type="Str">File</Property>
				<Property Name="PKG_synopsis" Type="Str">Installer</Property>
				<Property Name="PKG_version" Type="Str">1.0.0</Property>
			</Item>
		</Item>
	</Item>
</Project>
