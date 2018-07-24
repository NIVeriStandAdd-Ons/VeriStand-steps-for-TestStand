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
		<Item Name="Documentation" Type="Folder">
			<Item Name="VeriStand Steps for TestStand Developer Guide.docx" Type="Document" URL="../../../../Documentation/VeriStand Steps for TestStand Developer Guide.docx"/>
			<Item Name="VeriStand Steps for TestStand User Guide.docx" Type="Document" URL="../../../../Documentation/VeriStand Steps for TestStand User Guide.docx"/>
		</Item>
		<Item Name="Examples" Type="Folder">
			<Item Name="Get Rise Time.nivsseq" Type="Document" URL="../../../../Documentation/Tutorial/Get Rise Time.nivsseq"/>
			<Item Name="Monitor Engine Temp.seq" Type="Document" URL="../../../../Documentation/Tutorial/Monitor Engine Temp.seq"/>
			<Item Name="NIVS Engine Demo.seq" Type="Document" URL="../../../../Documentation/Tutorial/NIVS Engine Demo.seq"/>
			<Item Name="Training - NIVS Engine Demo.docx" Type="Document" URL="../../../../Documentation/Tutorial/Training - NIVS Engine Demo.docx"/>
		</Item>
		<Item Name="GAC Utilities" Type="Folder">
			<Item Name="InstallToGAC.exe" Type="Document" URL="../../../CSharp/AddRemoveGACUtils/InstallToGAC.exe"/>
			<Item Name="RemoveFromGAC.exe" Type="Document" URL="../../../CSharp/AddRemoveGACUtils/RemoveFromGAC.exe"/>
		</Item>
		<Item Name="Icon File" Type="Folder">
			<Item Name="Veristand_icon_vista.ico" Type="Document" URL="../../../CustomPaletteFile/Veristand_icon_vista.ico"/>
		</Item>
		<Item Name="Installer Action VIs" Type="Folder">
			<Item Name="Installer Post-Install Action.vi" Type="VI" URL="../Actions/Installer Post-Install Action.vi"/>
			<Item Name="Installer Pre-Uninstall Action.vi" Type="VI" URL="../Actions/Installer Pre-Uninstall Action.vi"/>
			<Item Name="PostInstallAction.exe" Type="Document" URL="../../../../Built/ProgramFiles_32/NI VeriStand Steps for TestStand/PostInstallAction.exe"/>
			<Item Name="PreUninstallAction.exe" Type="Document" URL="../../../../Built/ProgramFiles_32/NI VeriStand Steps for TestStand/PreUninstallAction.exe"/>
		</Item>
		<Item Name="License" Type="Folder">
			<Item Name="LICENSE.txt" Type="Document" URL="../../../../LICENSE.txt"/>
		</Item>
		<Item Name="PPL" Type="Folder">
			<Item Name="x64" Type="Folder">
				<Item Name="ni-veristand-steps-runtime-lib.lvlibp" Type="LVLibp" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp">
					<Item Name="alarms" Type="Folder">
						<Item Name="AlarmGetList.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/alarms/AlarmGetList.vi"/>
						<Item Name="AlarmGetState.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/alarms/AlarmGetState.vi"/>
						<Item Name="AlarmSetState.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/alarms/AlarmSetState.vi"/>
					</Item>
					<Item Name="application" Type="Folder">
						<Item Name="VeristandInitialize.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/application/VeristandInitialize.vi"/>
						<Item Name="VeristandStart.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/application/VeristandStart.vi"/>
						<Item Name="VeristandStop.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/application/VeristandStop.vi"/>
					</Item>
					<Item Name="build" Type="Folder">
						<Item Name="Post-Build Action.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/build/Post-Build Action.vi"/>
					</Item>
					<Item Name="channels" Type="Folder">
						<Item Name="ChannelsGetValues.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/channels/ChannelsGetValues.vi"/>
						<Item Name="ChannelsSetValues.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/channels/ChannelsSetValues.vi"/>
					</Item>
					<Item Name="controls" Type="Folder">
						<Item Name="VeriStand dotNet References.ctl" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/controls/VeriStand dotNet References.ctl"/>
					</Item>
					<Item Name="errors" Type="Folder">
						<Item Name="ResolveError.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/errors/ResolveError.vi"/>
					</Item>
					<Item Name="faults" Type="Folder">
						<Item Name="FaultClear.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultClear.vi"/>
						<Item Name="FaultClearAll.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultClearAll.vi"/>
						<Item Name="FaultGetValue.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultGetValue.vi"/>
						<Item Name="FaultSetValue.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultSetValue.vi"/>
					</Item>
					<Item Name="logging" Type="Folder">
						<Item Name="Start logging.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/logging/Start logging.vi"/>
						<Item Name="Stop Logging.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/logging/Stop Logging.vi"/>
					</Item>
					<Item Name="models" Type="Folder">
						<Item Name="ModelParameterValueGet.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/models/ModelParameterValueGet.vi"/>
						<Item Name="ModelParameterValueSet.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/models/ModelParameterValueSet.vi"/>
						<Item Name="ModelParameterValueUpdateFromFile.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/models/ModelParameterValueUpdateFromFile.vi"/>
					</Item>
					<Item Name="project" Type="Folder">
						<Item Name="ProjectClose.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectClose.vi"/>
						<Item Name="ProjectConnect.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectConnect.vi"/>
						<Item Name="ProjectDeploy.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectDeploy.vi"/>
						<Item Name="ProjectDisconnect.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectDisconnect.vi"/>
						<Item Name="ProjectOpen.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectOpen.vi"/>
						<Item Name="ProjectOpenReferences.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectOpenReferences.vi"/>
						<Item Name="ProjectRun.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectRun.vi"/>
						<Item Name="ProjectSilentConnect.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectSilentConnect.vi"/>
						<Item Name="ProjectSilentDisconnect.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectSilentDisconnect.vi"/>
						<Item Name="ProjectUndeploy.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectUndeploy.vi"/>
					</Item>
					<Item Name="references" Type="Folder">
						<Item Name="FileGlobalsCreate.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/references/FileGlobalsCreate.vi"/>
						<Item Name="ReferencesFGV.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/references/ReferencesFGV.vi"/>
					</Item>
					<Item Name="RTsequences" Type="Folder">
						<Item Name="subVIs" Type="Folder">
							<Item Name="Build Parameter Assignment Array.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/subVIs/Build Parameter Assignment Array.vi"/>
							<Item Name="Expression Array String to Expression Array.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/subVIs/Expression Array String to Expression Array.vi"/>
							<Item Name="Remove First and Last Characters.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/subVIs/Remove First and Last Characters.vi"/>
						</Item>
						<Item Name="Run RT Sequence.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/Run RT Sequence.vi"/>
						<Item Name="Run Stimulus Profile.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/Run Stimulus Profile.vi"/>
					</Item>
					<Item Name="subVIs" Type="Folder">
						<Item Name="64BitOSCheck.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/subVIs/64BitOSCheck.vi"/>
					</Item>
					<Item Name="workspace" Type="Folder">
						<Item Name="WorkspaceOpenClose.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/workspace/WorkspaceOpenClose.vi"/>
					</Item>
					<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
					<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/error.llb/Error Cluster From Error Code.vi"/>
					<Item Name="Get System Directory.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/sysdir.llb/Get System Directory.vi"/>
					<Item Name="LabVIEW Test - Sequence Context.ctl" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSLegacy.llb/LabVIEW Test - Sequence Context.ctl"/>
					<Item Name="MergeError.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Shared/MergeError.vi"/>
					<Item Name="NI_VS AlarmManager ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/AlarmManager/NI_VS AlarmManager ExecutionAPI.lvlib"/>
					<Item Name="nirviCommon.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/express/rvi/timingcommon/nirviCommon.vi"/>
					<Item Name="Space Constant.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/dlg_ctls.llb/Space Constant.vi"/>
					<Item Name="System Directory Type.ctl" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/sysdir.llb/System Directory Type.ctl"/>
					<Item Name="System Exec.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Platform/system.llb/System Exec.vi"/>
					<Item Name="TestStand - Close Termination Monitor.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Close Termination Monitor.vi"/>
					<Item Name="TestStand - Get Termination Monitor Status.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Get Termination Monitor Status.vi"/>
					<Item Name="TestStand - Initialize Termination Monitor.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Initialize Termination Monitor.vi"/>
					<Item Name="TestStand - Status Monitor.ctl" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Status Monitor.ctl"/>
					<Item Name="To .NET Object.vi" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Platform/dotnet.llb/To .NET Object.vi"/>
				</Item>
			</Item>
			<Item Name="x86" Type="Folder">
				<Item Name="ni-veristand-steps-runtime-lib.lvlibp" Type="LVLibp" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp">
					<Item Name="alarms" Type="Folder">
						<Item Name="AlarmGetList.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/alarms/AlarmGetList.vi"/>
						<Item Name="AlarmGetState.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/alarms/AlarmGetState.vi"/>
						<Item Name="AlarmSetState.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/alarms/AlarmSetState.vi"/>
					</Item>
					<Item Name="application" Type="Folder">
						<Item Name="VeristandInitialize.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/application/VeristandInitialize.vi"/>
						<Item Name="VeristandStart.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/application/VeristandStart.vi"/>
						<Item Name="VeristandStop.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/application/VeristandStop.vi"/>
					</Item>
					<Item Name="build" Type="Folder">
						<Item Name="Post-Build Action.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/build/Post-Build Action.vi"/>
					</Item>
					<Item Name="channels" Type="Folder">
						<Item Name="ChannelsGetValues.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/channels/ChannelsGetValues.vi"/>
						<Item Name="ChannelsSetValues.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/channels/ChannelsSetValues.vi"/>
					</Item>
					<Item Name="controls" Type="Folder">
						<Item Name="VeriStand dotNet References.ctl" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/controls/VeriStand dotNet References.ctl"/>
					</Item>
					<Item Name="errors" Type="Folder">
						<Item Name="ResolveError.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/errors/ResolveError.vi"/>
					</Item>
					<Item Name="faults" Type="Folder">
						<Item Name="FaultClear.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultClear.vi"/>
						<Item Name="FaultClearAll.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultClearAll.vi"/>
						<Item Name="FaultGetValue.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultGetValue.vi"/>
						<Item Name="FaultSetValue.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/faults/FaultSetValue.vi"/>
					</Item>
					<Item Name="logging" Type="Folder">
						<Item Name="Start logging.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/logging/Start logging.vi"/>
						<Item Name="Stop Logging.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/logging/Stop Logging.vi"/>
					</Item>
					<Item Name="models" Type="Folder">
						<Item Name="ModelParameterValueGet.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/models/ModelParameterValueGet.vi"/>
						<Item Name="ModelParameterValueSet.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/models/ModelParameterValueSet.vi"/>
						<Item Name="ModelParameterValueUpdateFromFile.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/models/ModelParameterValueUpdateFromFile.vi"/>
					</Item>
					<Item Name="project" Type="Folder">
						<Item Name="ProjectClose.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectClose.vi"/>
						<Item Name="ProjectConnect.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectConnect.vi"/>
						<Item Name="ProjectDeploy.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectDeploy.vi"/>
						<Item Name="ProjectDisconnect.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectDisconnect.vi"/>
						<Item Name="ProjectOpen.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectOpen.vi"/>
						<Item Name="ProjectOpenReferences.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectOpenReferences.vi"/>
						<Item Name="ProjectRun.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectRun.vi"/>
						<Item Name="ProjectSilentConnect.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectSilentConnect.vi"/>
						<Item Name="ProjectSilentDisconnect.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectSilentDisconnect.vi"/>
						<Item Name="ProjectUndeploy.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/project/ProjectUndeploy.vi"/>
					</Item>
					<Item Name="references" Type="Folder">
						<Item Name="FileGlobalsCreate.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/references/FileGlobalsCreate.vi"/>
						<Item Name="ReferencesFGV.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/references/ReferencesFGV.vi"/>
					</Item>
					<Item Name="RTsequences" Type="Folder">
						<Item Name="subVIs" Type="Folder">
							<Item Name="Build Parameter Assignment Array.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/subVIs/Build Parameter Assignment Array.vi"/>
							<Item Name="Expression Array String to Expression Array.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/subVIs/Expression Array String to Expression Array.vi"/>
							<Item Name="Remove First and Last Characters.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/subVIs/Remove First and Last Characters.vi"/>
						</Item>
						<Item Name="Run RT Sequence.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/Run RT Sequence.vi"/>
						<Item Name="Run Stimulus Profile.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/RTsequences/Run Stimulus Profile.vi"/>
					</Item>
					<Item Name="subVIs" Type="Folder">
						<Item Name="64BitOSCheck.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/subVIs/64BitOSCheck.vi"/>
					</Item>
					<Item Name="workspace" Type="Folder">
						<Item Name="WorkspaceOpenClose.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/workspace/WorkspaceOpenClose.vi"/>
					</Item>
					<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
					<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/error.llb/Error Cluster From Error Code.vi"/>
					<Item Name="Get System Directory.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/sysdir.llb/Get System Directory.vi"/>
					<Item Name="LabVIEW Test - Sequence Context.ctl" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSLegacy.llb/LabVIEW Test - Sequence Context.ctl"/>
					<Item Name="MergeError.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI VeriStand/Execution/Shared/MergeError.vi"/>
					<Item Name="NI_FileType.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/lvfile.llb/NI_FileType.lvlib"/>
					<Item Name="NI_PackedLibraryUtility.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/LVLibp/NI_PackedLibraryUtility.lvlib"/>
					<Item Name="NI_VS Alarm ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Alarm/NI_VS Alarm ExecutionAPI.lvlib"/>
					<Item Name="NI_VS AlarmManager ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/AlarmManager/NI_VS AlarmManager ExecutionAPI.lvlib"/>
					<Item Name="NI_VS ChannelFault ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/ChannelFaultManager/NI_VS ChannelFault ExecutionAPI.lvlib"/>
					<Item Name="NI_VS Data Logging API.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/DataLogging/NI_VS Data Logging API.lvlib"/>
					<Item Name="NI_VS ModelManager ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/ModelManager/NI_VS ModelManager ExecutionAPI.lvlib"/>
					<Item Name="NI_VS Project ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Project/NI_VS Project ExecutionAPI.lvlib"/>
					<Item Name="NI_VS Sequence Execution Interface.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/SequenceExecutionInterface/NI_VS Sequence Execution Interface.lvlib"/>
					<Item Name="NI_VS Workspace ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI VeriStand/Execution/Workspace/NI_VS Workspace ExecutionAPI.lvlib"/>
					<Item Name="nirviCommon.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/express/rvi/timingcommon/nirviCommon.vi"/>
					<Item Name="Space Constant.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/dlg_ctls.llb/Space Constant.vi"/>
					<Item Name="System Directory Type.ctl" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/sysdir.llb/System Directory Type.ctl"/>
					<Item Name="System Exec.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Platform/system.llb/System Exec.vi"/>
					<Item Name="TestStand - Close Termination Monitor.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Close Termination Monitor.vi"/>
					<Item Name="TestStand - Get Termination Monitor Status.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Get Termination Monitor Status.vi"/>
					<Item Name="TestStand - Initialize Termination Monitor.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Initialize Termination Monitor.vi"/>
					<Item Name="TestStand - Status Monitor.ctl" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/addons/TestStand/_TSUtility.llb/TestStand - Status Monitor.ctl"/>
					<Item Name="To .NET Object.vi" Type="VI" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Platform/dotnet.llb/To .NET Object.vi"/>
					<Item Name="VariantType.lvlib" Type="Library" URL="../PPLs/x86/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/VariantDataType/VariantType.lvlib"/>
				</Item>
			</Item>
		</Item>
		<Item Name="TypePalette File" Type="Folder">
			<Item Name="NI_VeristandTypes.ini" Type="Document" URL="../../../../Built/documents/National Instruments/TestStand 2014 (32-bit)/Components/TypePalettes/NI_VeristandTypes.ini"/>
		</Item>
		<Item Name="VeriStandStepsAssembly" Type="Folder">
			<Item Name="NationalInstruments.Veristand.VeristandSteps.dll" Type="Document" URL="../../../../Built/ProgramFiles_32/NI VeriStand Steps for TestStand/NationalInstruments.Veristand.VeristandSteps.dll"/>
		</Item>
		<Item Name="BuildVIs.lvlib" Type="Library" URL="../BuildVIs/BuildVIs.lvlib"/>
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
			<Item Name="AlarmManagerAPI.ctl" Type="VI" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/AlarmManager/AlarmManagerAPI.ctl"/>
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
			<Item Name="NI_FileType.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/lvfile.llb/NI_FileType.lvlib"/>
			<Item Name="NI_PackedLibraryUtility.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/LVLibp/NI_PackedLibraryUtility.lvlib"/>
			<Item Name="NI_VS Alarm ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Alarm/NI_VS Alarm ExecutionAPI.lvlib"/>
			<Item Name="NI_VS ChannelFault ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/ChannelFaultManager/NI_VS ChannelFault ExecutionAPI.lvlib"/>
			<Item Name="NI_VS Data Logging API.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/DataLogging/NI_VS Data Logging API.lvlib"/>
			<Item Name="NI_VS ModelManager ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/ModelManager/NI_VS ModelManager ExecutionAPI.lvlib"/>
			<Item Name="NI_VS Project ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Project/NI_VS Project ExecutionAPI.lvlib"/>
			<Item Name="NI_VS Sequence Execution Interface.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/SequenceExecutionInterface/NI_VS Sequence Execution Interface.lvlib"/>
			<Item Name="NI_VS Workspace ExecutionAPI.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/NI Veristand/Execution/Workspace/NI_VS Workspace ExecutionAPI.lvlib"/>
			<Item Name="VariantType.lvlib" Type="Library" URL="../PPLs/x64/ni-veristand-steps-runtime-lib.lvlibp/1abvi3w/vi.lib/Utility/VariantDataType/VariantType.lvlib"/>
		</Item>
		<Item Name="Build Specifications" Type="Build">
			<Item Name="Installer Post Install Action" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{84BBF4BC-FA74-43EA-A06D-9CE7D81B3058}</Property>
				<Property Name="App_INI_GUID" Type="Str">{FDE31525-CC3F-4974-925C-EA6D0551BBD2}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{A230D1A5-26E7-4913-9D60-7CDF1896B358}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Installer Post Install Action</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../build_temp</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_postActionVIID" Type="Ref">/My Computer/BuildVIs.lvlib/Post-Build Action.vi</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{73976618-ACA5-447B-B1E0-43DFC41BBBDE}</Property>
				<Property Name="Bld_version.build" Type="Int">9</Property>
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
				<Property Name="Source[0].itemID" Type="Str">{D5984932-A765-437B-8A55-83983D62CB48}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Installer Action VIs/Installer Post-Install Action.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Installer Post Install Action</Property>
				<Property Name="TgtF_internalName" Type="Str">Installer Post Install Action</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2018 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">Installer Post Install Action</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{665EBAA1-8110-404C-987A-6C035878C6E0}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">PostInstallAction.exe</Property>
			</Item>
			<Item Name="Installer Pre Uninstall Action" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{75877B54-405C-46EB-9CA6-59177D7B20F4}</Property>
				<Property Name="App_INI_GUID" Type="Str">{0C67CD90-2E8D-458C-9E25-F2776C0F53DE}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{2CCBFE03-3BA1-4C03-8297-0B2CDBAB5F42}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Installer Pre Uninstall Action</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../build_temp</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_postActionVIID" Type="Ref">/My Computer/BuildVIs.lvlib/Post-Build Action.vi</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{CE2B453B-BC02-44A3-9391-FE22B26BE852}</Property>
				<Property Name="Bld_version.build" Type="Int">8</Property>
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
				<Property Name="Source[0].itemID" Type="Str">{7AF862C3-D79A-464C-B124-4A951FF7B9C0}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Installer Action VIs/Installer Pre-Uninstall Action.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Installer Pre Uninstall Action</Property>
				<Property Name="TgtF_internalName" Type="Str">Installer Pre Uninstall Action</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2018 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">Installer Pre Uninstall Action</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{5A0734FB-E5DE-461A-AB57-FE9BAF55AFB4}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">PreUninstallAction.exe</Property>
			</Item>
			<Item Name="NI VeriStand Steps for TestStand" Type="Installer">
				<Property Name="Destination[0].name" Type="Str">NI VeriStand Steps for TestStand</Property>
				<Property Name="Destination[0].parent" Type="Str">{3912416A-D2E5-411B-AFEE-B63654D690C0}</Property>
				<Property Name="Destination[0].tag" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="Destination[0].type" Type="Str">userFolder</Property>
				<Property Name="Destination[1].name" Type="Str">Users</Property>
				<Property Name="Destination[1].parent" Type="Str">{C63B6F86-C439-4240-9AAE-EC6A9DDD0A29}</Property>
				<Property Name="Destination[1].tag" Type="Str">{5A3E3B55-31C3-40AB-AD79-D825CDF62554}</Property>
				<Property Name="Destination[1].type" Type="Str">userFolder</Property>
				<Property Name="Destination[10].name" Type="Str">TestStand 2017 (32-bit)</Property>
				<Property Name="Destination[10].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[10].tag" Type="Str">{9D568FD5-8161-4DD2-98E3-DD042FF32884}</Property>
				<Property Name="Destination[10].type" Type="Str">userFolder</Property>
				<Property Name="Destination[11].name" Type="Str">TestStand 2017 (64-bit)</Property>
				<Property Name="Destination[11].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[11].tag" Type="Str">{6281706A-ADFD-40D9-BE54-D20CC16363E9}</Property>
				<Property Name="Destination[11].type" Type="Str">userFolder</Property>
				<Property Name="Destination[12].name" Type="Str">Components</Property>
				<Property Name="Destination[12].parent" Type="Str">{EF661261-986A-4045-B42C-0EE34DB1361E}</Property>
				<Property Name="Destination[12].tag" Type="Str">{72B94A93-38F4-474E-B785-1BBC24E9FF46}</Property>
				<Property Name="Destination[12].type" Type="Str">userFolder</Property>
				<Property Name="Destination[13].name" Type="Str">Components</Property>
				<Property Name="Destination[13].parent" Type="Str">{544A18E1-CA97-44BF-B30A-BED70A16E283}</Property>
				<Property Name="Destination[13].tag" Type="Str">{9AB29ADA-16F9-4632-AEE9-B8A4B1DE25A8}</Property>
				<Property Name="Destination[13].type" Type="Str">userFolder</Property>
				<Property Name="Destination[14].name" Type="Str">Components</Property>
				<Property Name="Destination[14].parent" Type="Str">{B2A1568E-C35E-4D45-9928-24FD0189117D}</Property>
				<Property Name="Destination[14].tag" Type="Str">{B9FF8493-D0CE-4293-B033-BA7F5333C52D}</Property>
				<Property Name="Destination[14].type" Type="Str">userFolder</Property>
				<Property Name="Destination[15].name" Type="Str">Components</Property>
				<Property Name="Destination[15].parent" Type="Str">{A26DA72D-9ADC-45F5-B7A8-D01E7D37CAA8}</Property>
				<Property Name="Destination[15].tag" Type="Str">{B880B46F-34B0-4705-9889-1289678014D4}</Property>
				<Property Name="Destination[15].type" Type="Str">userFolder</Property>
				<Property Name="Destination[16].name" Type="Str">Components</Property>
				<Property Name="Destination[16].parent" Type="Str">{9D568FD5-8161-4DD2-98E3-DD042FF32884}</Property>
				<Property Name="Destination[16].tag" Type="Str">{CA33ACD4-4311-44D7-86B7-6235DB9A9614}</Property>
				<Property Name="Destination[16].type" Type="Str">userFolder</Property>
				<Property Name="Destination[17].name" Type="Str">Components</Property>
				<Property Name="Destination[17].parent" Type="Str">{6281706A-ADFD-40D9-BE54-D20CC16363E9}</Property>
				<Property Name="Destination[17].tag" Type="Str">{226AC91D-CA2A-452E-8359-13B44AB5AA77}</Property>
				<Property Name="Destination[17].type" Type="Str">userFolder</Property>
				<Property Name="Destination[18].name" Type="Str">Examples</Property>
				<Property Name="Destination[18].parent" Type="Str">{D194DA17-F33F-47D4-9890-AB103A4AE432}</Property>
				<Property Name="Destination[18].tag" Type="Str">{B28D317B-65BC-4A2A-AE46-EEBBC4CD062E}</Property>
				<Property Name="Destination[18].type" Type="Str">userFolder</Property>
				<Property Name="Destination[19].name" Type="Str">Icons</Property>
				<Property Name="Destination[19].parent" Type="Str">{72B94A93-38F4-474E-B785-1BBC24E9FF46}</Property>
				<Property Name="Destination[19].tag" Type="Str">{9963B9E1-67A0-4EEA-B97D-97A2BDDCE38E}</Property>
				<Property Name="Destination[19].type" Type="Str">userFolder</Property>
				<Property Name="Destination[2].name" Type="Str">Public</Property>
				<Property Name="Destination[2].parent" Type="Str">{5A3E3B55-31C3-40AB-AD79-D825CDF62554}</Property>
				<Property Name="Destination[2].tag" Type="Str">{AB0C2D8F-F677-4A48-A901-35E3FA000B93}</Property>
				<Property Name="Destination[2].type" Type="Str">userFolder</Property>
				<Property Name="Destination[20].name" Type="Str">Icons</Property>
				<Property Name="Destination[20].parent" Type="Str">{9AB29ADA-16F9-4632-AEE9-B8A4B1DE25A8}</Property>
				<Property Name="Destination[20].tag" Type="Str">{271B04F7-5AF4-4458-8815-BB0CCD0DE147}</Property>
				<Property Name="Destination[20].type" Type="Str">userFolder</Property>
				<Property Name="Destination[21].name" Type="Str">Icons</Property>
				<Property Name="Destination[21].parent" Type="Str">{B9FF8493-D0CE-4293-B033-BA7F5333C52D}</Property>
				<Property Name="Destination[21].tag" Type="Str">{836A15F1-BFA1-4DE4-A1C3-96294C434102}</Property>
				<Property Name="Destination[21].type" Type="Str">userFolder</Property>
				<Property Name="Destination[22].name" Type="Str">Icons</Property>
				<Property Name="Destination[22].parent" Type="Str">{B880B46F-34B0-4705-9889-1289678014D4}</Property>
				<Property Name="Destination[22].tag" Type="Str">{9C24ACF0-55BB-4786-A500-0705631106AB}</Property>
				<Property Name="Destination[22].type" Type="Str">userFolder</Property>
				<Property Name="Destination[23].name" Type="Str">Icons</Property>
				<Property Name="Destination[23].parent" Type="Str">{CA33ACD4-4311-44D7-86B7-6235DB9A9614}</Property>
				<Property Name="Destination[23].tag" Type="Str">{EEF8A9FC-3D26-4BB9-939A-AEABFE837130}</Property>
				<Property Name="Destination[23].type" Type="Str">userFolder</Property>
				<Property Name="Destination[24].name" Type="Str">Icons</Property>
				<Property Name="Destination[24].parent" Type="Str">{226AC91D-CA2A-452E-8359-13B44AB5AA77}</Property>
				<Property Name="Destination[24].tag" Type="Str">{DD2D6E6C-82F1-42A4-B06A-48D8B47BBF30}</Property>
				<Property Name="Destination[24].type" Type="Str">userFolder</Property>
				<Property Name="Destination[25].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[25].parent" Type="Str">{72B94A93-38F4-474E-B785-1BBC24E9FF46}</Property>
				<Property Name="Destination[25].tag" Type="Str">{2648EF7A-C8DD-48E4-8321-DCA17AB06805}</Property>
				<Property Name="Destination[25].type" Type="Str">userFolder</Property>
				<Property Name="Destination[26].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[26].parent" Type="Str">{9AB29ADA-16F9-4632-AEE9-B8A4B1DE25A8}</Property>
				<Property Name="Destination[26].tag" Type="Str">{F3FE6A20-F5DF-4331-A70F-FF424B935C4B}</Property>
				<Property Name="Destination[26].type" Type="Str">userFolder</Property>
				<Property Name="Destination[27].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[27].parent" Type="Str">{B9FF8493-D0CE-4293-B033-BA7F5333C52D}</Property>
				<Property Name="Destination[27].tag" Type="Str">{16AC77D7-7020-40FB-80C1-57CF72062E02}</Property>
				<Property Name="Destination[27].type" Type="Str">userFolder</Property>
				<Property Name="Destination[28].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[28].parent" Type="Str">{B880B46F-34B0-4705-9889-1289678014D4}</Property>
				<Property Name="Destination[28].tag" Type="Str">{22FFCCA4-F0A4-470B-997A-7CF0E998CD7F}</Property>
				<Property Name="Destination[28].type" Type="Str">userFolder</Property>
				<Property Name="Destination[29].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[29].parent" Type="Str">{CA33ACD4-4311-44D7-86B7-6235DB9A9614}</Property>
				<Property Name="Destination[29].tag" Type="Str">{4A7943B5-591C-4C88-933E-2ACF054339EA}</Property>
				<Property Name="Destination[29].type" Type="Str">userFolder</Property>
				<Property Name="Destination[3].name" Type="Str">Documents</Property>
				<Property Name="Destination[3].parent" Type="Str">{AB0C2D8F-F677-4A48-A901-35E3FA000B93}</Property>
				<Property Name="Destination[3].tag" Type="Str">{915C58AE-7DBF-4FB3-A0F0-ED3F1FDAFCC9}</Property>
				<Property Name="Destination[3].type" Type="Str">userFolder</Property>
				<Property Name="Destination[30].name" Type="Str">TypePalettes</Property>
				<Property Name="Destination[30].parent" Type="Str">{226AC91D-CA2A-452E-8359-13B44AB5AA77}</Property>
				<Property Name="Destination[30].tag" Type="Str">{BADF06D2-4BB5-4F47-A791-A81B8137BD81}</Property>
				<Property Name="Destination[30].type" Type="Str">userFolder</Property>
				<Property Name="Destination[4].name" Type="Str">National Instruments</Property>
				<Property Name="Destination[4].parent" Type="Str">{915C58AE-7DBF-4FB3-A0F0-ED3F1FDAFCC9}</Property>
				<Property Name="Destination[4].tag" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[4].type" Type="Str">userFolder</Property>
				<Property Name="Destination[5].name" Type="Str">NI VeriStand Steps for TestStand</Property>
				<Property Name="Destination[5].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[5].tag" Type="Str">{D194DA17-F33F-47D4-9890-AB103A4AE432}</Property>
				<Property Name="Destination[5].type" Type="Str">userFolder</Property>
				<Property Name="Destination[6].name" Type="Str">TestStand 2014 (32-bit)</Property>
				<Property Name="Destination[6].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[6].tag" Type="Str">{EF661261-986A-4045-B42C-0EE34DB1361E}</Property>
				<Property Name="Destination[6].type" Type="Str">userFolder</Property>
				<Property Name="Destination[7].name" Type="Str">TestStand 2014 (64-bit)</Property>
				<Property Name="Destination[7].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[7].tag" Type="Str">{544A18E1-CA97-44BF-B30A-BED70A16E283}</Property>
				<Property Name="Destination[7].type" Type="Str">userFolder</Property>
				<Property Name="Destination[8].name" Type="Str">TestStand 2016 (32-bit)</Property>
				<Property Name="Destination[8].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[8].tag" Type="Str">{B2A1568E-C35E-4D45-9928-24FD0189117D}</Property>
				<Property Name="Destination[8].type" Type="Str">userFolder</Property>
				<Property Name="Destination[9].name" Type="Str">TestStand 2016 (64-bit)</Property>
				<Property Name="Destination[9].parent" Type="Str">{FCC1B181-B961-4317-BFED-6F057CBC440E}</Property>
				<Property Name="Destination[9].tag" Type="Str">{A26DA72D-9ADC-45F5-B7A8-D01E7D37CAA8}</Property>
				<Property Name="Destination[9].type" Type="Str">userFolder</Property>
				<Property Name="DestinationCount" Type="Int">31</Property>
				<Property Name="INST_author" Type="Str">NIC SE</Property>
				<Property Name="INST_buildLocation" Type="Path">../builds/NI VeriStand Steps for TestStand</Property>
				<Property Name="INST_buildLocation.type" Type="Str">relativeToCommon</Property>
				<Property Name="INST_buildSpecName" Type="Str">NI VeriStand Steps for TestStand</Property>
				<Property Name="INST_defaultDir" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="INST_productName" Type="Str">NI VeriStand Steps for TestStand</Property>
				<Property Name="INST_productVersion" Type="Str">7.2.2</Property>
				<Property Name="InstSpecBitness" Type="Str">32-bit</Property>
				<Property Name="InstSpecVersion" Type="Str">15018025</Property>
				<Property Name="MSI_arpCompany" Type="Str">National Instruments Systems Engineering</Property>
				<Property Name="MSI_distID" Type="Str">{81B86D54-CCEF-4708-B575-D8FA2BEEE8BB}</Property>
				<Property Name="MSI_hideNonRuntimes" Type="Bool">true</Property>
				<Property Name="MSI_osCheck" Type="Int">0</Property>
				<Property Name="MSI_upgradeCode" Type="Str">{7C0DA6B1-B18F-4C57-85DC-3B7A90355C75}</Property>
				<Property Name="MSI_windowTitle" Type="Str">Welcome to the NI VeriStand Steps for TestStand</Property>
				<Property Name="RegDest[0].dirName" Type="Str">Software</Property>
				<Property Name="RegDest[0].dirTag" Type="Str">{DDFAFC8B-E728-4AC8-96DE-B920EBB97A86}</Property>
				<Property Name="RegDest[0].parentTag" Type="Str">2</Property>
				<Property Name="RegDestCount" Type="Int">1</Property>
				<Property Name="Source[0].dest" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="Source[0].name" Type="Str">NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[0].tag" Type="Ref">/My Computer/VeriStandStepsAssembly/NationalInstruments.Veristand.VeristandSteps.dll</Property>
				<Property Name="Source[0].type" Type="Str">File</Property>
				<Property Name="Source[1].dest" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="Source[1].name" Type="Str">PostInstallAction.exe</Property>
				<Property Name="Source[1].runEXE" Type="Bool">true</Property>
				<Property Name="Source[1].tag" Type="Ref">/My Computer/Installer Action VIs/PostInstallAction.exe</Property>
				<Property Name="Source[1].type" Type="Str">File</Property>
				<Property Name="Source[10].dest" Type="Str">{271B04F7-5AF4-4458-8815-BB0CCD0DE147}</Property>
				<Property Name="Source[10].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[10].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[10].type" Type="Str">File</Property>
				<Property Name="Source[11].dest" Type="Str">{836A15F1-BFA1-4DE4-A1C3-96294C434102}</Property>
				<Property Name="Source[11].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[11].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[11].type" Type="Str">File</Property>
				<Property Name="Source[12].dest" Type="Str">{9C24ACF0-55BB-4786-A500-0705631106AB}</Property>
				<Property Name="Source[12].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[12].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[12].type" Type="Str">File</Property>
				<Property Name="Source[13].dest" Type="Str">{EEF8A9FC-3D26-4BB9-939A-AEABFE837130}</Property>
				<Property Name="Source[13].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[13].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[13].type" Type="Str">File</Property>
				<Property Name="Source[14].dest" Type="Str">{DD2D6E6C-82F1-42A4-B06A-48D8B47BBF30}</Property>
				<Property Name="Source[14].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[14].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[14].type" Type="Str">File</Property>
				<Property Name="Source[15].dest" Type="Str">{BADF06D2-4BB5-4F47-A791-A81B8137BD81}</Property>
				<Property Name="Source[15].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[15].tag" Type="Ref">/My Computer/PPL/x64/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[15].type" Type="Str">File</Property>
				<Property Name="Source[16].dest" Type="Str">{22FFCCA4-F0A4-470B-997A-7CF0E998CD7F}</Property>
				<Property Name="Source[16].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[16].tag" Type="Ref">/My Computer/PPL/x64/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[16].type" Type="Str">File</Property>
				<Property Name="Source[17].dest" Type="Str">{F3FE6A20-F5DF-4331-A70F-FF424B935C4B}</Property>
				<Property Name="Source[17].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[17].tag" Type="Ref">/My Computer/PPL/x64/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[17].type" Type="Str">File</Property>
				<Property Name="Source[18].dest" Type="Str">{2648EF7A-C8DD-48E4-8321-DCA17AB06805}</Property>
				<Property Name="Source[18].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[18].tag" Type="Ref">/My Computer/PPL/x86/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[18].type" Type="Str">File</Property>
				<Property Name="Source[19].dest" Type="Str">{16AC77D7-7020-40FB-80C1-57CF72062E02}</Property>
				<Property Name="Source[19].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[19].tag" Type="Ref">/My Computer/PPL/x86/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[19].type" Type="Str">File</Property>
				<Property Name="Source[2].dest" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="Source[2].name" Type="Str">PreUninstallAction.exe</Property>
				<Property Name="Source[2].runEXE_uninstall" Type="Bool">true</Property>
				<Property Name="Source[2].tag" Type="Ref">/My Computer/Installer Action VIs/PreUninstallAction.exe</Property>
				<Property Name="Source[2].type" Type="Str">File</Property>
				<Property Name="Source[20].dest" Type="Str">{4A7943B5-591C-4C88-933E-2ACF054339EA}</Property>
				<Property Name="Source[20].name" Type="Str">ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[20].tag" Type="Ref">/My Computer/PPL/x86/ni-veristand-steps-runtime-lib.lvlibp</Property>
				<Property Name="Source[20].type" Type="Str">File</Property>
				<Property Name="Source[21].dest" Type="Str">{2648EF7A-C8DD-48E4-8321-DCA17AB06805}</Property>
				<Property Name="Source[21].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[21].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[21].type" Type="Str">File</Property>
				<Property Name="Source[22].dest" Type="Str">{F3FE6A20-F5DF-4331-A70F-FF424B935C4B}</Property>
				<Property Name="Source[22].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[22].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[22].type" Type="Str">File</Property>
				<Property Name="Source[23].dest" Type="Str">{16AC77D7-7020-40FB-80C1-57CF72062E02}</Property>
				<Property Name="Source[23].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[23].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[23].type" Type="Str">File</Property>
				<Property Name="Source[24].dest" Type="Str">{22FFCCA4-F0A4-470B-997A-7CF0E998CD7F}</Property>
				<Property Name="Source[24].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[24].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[24].type" Type="Str">File</Property>
				<Property Name="Source[25].dest" Type="Str">{4A7943B5-591C-4C88-933E-2ACF054339EA}</Property>
				<Property Name="Source[25].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[25].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[25].type" Type="Str">File</Property>
				<Property Name="Source[26].dest" Type="Str">{BADF06D2-4BB5-4F47-A791-A81B8137BD81}</Property>
				<Property Name="Source[26].name" Type="Str">NI_VeristandTypes.ini</Property>
				<Property Name="Source[26].tag" Type="Ref">/My Computer/TypePalette File/NI_VeristandTypes.ini</Property>
				<Property Name="Source[26].type" Type="Str">File</Property>
				<Property Name="Source[27].dest" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="Source[27].name" Type="Str">InstallToGAC.exe</Property>
				<Property Name="Source[27].tag" Type="Ref">/My Computer/GAC Utilities/InstallToGAC.exe</Property>
				<Property Name="Source[27].type" Type="Str">File</Property>
				<Property Name="Source[28].dest" Type="Str">{5AFC19D6-4EA2-4323-8E43-5E5D7B78490E}</Property>
				<Property Name="Source[28].name" Type="Str">RemoveFromGAC.exe</Property>
				<Property Name="Source[28].tag" Type="Ref">/My Computer/GAC Utilities/RemoveFromGAC.exe</Property>
				<Property Name="Source[28].type" Type="Str">File</Property>
				<Property Name="Source[3].dest" Type="Str">{B28D317B-65BC-4A2A-AE46-EEBBC4CD062E}</Property>
				<Property Name="Source[3].name" Type="Str">Get Rise Time.nivsseq</Property>
				<Property Name="Source[3].tag" Type="Ref">/My Computer/Examples/Get Rise Time.nivsseq</Property>
				<Property Name="Source[3].type" Type="Str">File</Property>
				<Property Name="Source[4].dest" Type="Str">{B28D317B-65BC-4A2A-AE46-EEBBC4CD062E}</Property>
				<Property Name="Source[4].name" Type="Str">Monitor Engine Temp.seq</Property>
				<Property Name="Source[4].tag" Type="Ref">/My Computer/Examples/Monitor Engine Temp.seq</Property>
				<Property Name="Source[4].type" Type="Str">File</Property>
				<Property Name="Source[5].dest" Type="Str">{B28D317B-65BC-4A2A-AE46-EEBBC4CD062E}</Property>
				<Property Name="Source[5].name" Type="Str">NIVS Engine Demo.seq</Property>
				<Property Name="Source[5].tag" Type="Ref">/My Computer/Examples/NIVS Engine Demo.seq</Property>
				<Property Name="Source[5].type" Type="Str">File</Property>
				<Property Name="Source[6].dest" Type="Str">{B28D317B-65BC-4A2A-AE46-EEBBC4CD062E}</Property>
				<Property Name="Source[6].name" Type="Str">Training - NIVS Engine Demo.docx</Property>
				<Property Name="Source[6].tag" Type="Ref">/My Computer/Examples/Training - NIVS Engine Demo.docx</Property>
				<Property Name="Source[6].type" Type="Str">File</Property>
				<Property Name="Source[7].dest" Type="Str">{D194DA17-F33F-47D4-9890-AB103A4AE432}</Property>
				<Property Name="Source[7].name" Type="Str">VeriStand Steps for TestStand Developer Guide.docx</Property>
				<Property Name="Source[7].tag" Type="Ref">/My Computer/Documentation/VeriStand Steps for TestStand Developer Guide.docx</Property>
				<Property Name="Source[7].type" Type="Str">File</Property>
				<Property Name="Source[8].dest" Type="Str">{D194DA17-F33F-47D4-9890-AB103A4AE432}</Property>
				<Property Name="Source[8].name" Type="Str">VeriStand Steps for TestStand User Guide.docx</Property>
				<Property Name="Source[8].tag" Type="Ref">/My Computer/Documentation/VeriStand Steps for TestStand User Guide.docx</Property>
				<Property Name="Source[8].type" Type="Str">File</Property>
				<Property Name="Source[9].dest" Type="Str">{9963B9E1-67A0-4EEA-B97D-97A2BDDCE38E}</Property>
				<Property Name="Source[9].name" Type="Str">Veristand_icon_vista.ico</Property>
				<Property Name="Source[9].tag" Type="Ref">/My Computer/Icon File/Veristand_icon_vista.ico</Property>
				<Property Name="Source[9].type" Type="Str">File</Property>
				<Property Name="SourceCount" Type="Int">29</Property>
			</Item>
		</Item>
	</Item>
</Project>
