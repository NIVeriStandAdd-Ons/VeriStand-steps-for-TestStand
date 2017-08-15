<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="13008000">
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
		<Item Name="Assembly Redirection VIs.lvlib" Type="Library" URL="../Assembly Redirection VIs.lvlib"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="NI_XML.lvlib" Type="Library" URL="/&lt;vilib&gt;/xml/NI_XML.lvlib"/>
				<Item Name="Simple XML.lvlib" Type="Library" URL="/&lt;vilib&gt;/ni/Simple XML/Simple XML.lvlib"/>
				<Item Name="Space Constant.vi" Type="VI" URL="/&lt;vilib&gt;/dlg_ctls.llb/Space Constant.vi"/>
			</Item>
			<Item Name="DOMUserDefRef.dll" Type="Document" URL="DOMUserDefRef.dll">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build">
			<Item Name="RedirectLabviewConfigFile" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{2E3861A9-51BD-4AEF-8226-41FE0C6106C5}</Property>
				<Property Name="App_INI_GUID" Type="Str">{A3C893C0-0A16-4E91-9908-A27D92A2A07E}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{A491D11F-7AA6-4ADE-89E8-B77E6825322C}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">RedirectLabviewConfigFile</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds/RedirectLabviewConfigFile</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{0509EADE-C23A-499F-B5AB-7FDBF3DABB3E}</Property>
				<Property Name="Bld_version.build" Type="Int">3</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">RedirectLabviewConfigFileApp.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/RedirectLabviewConfigFile/RedirectLabviewConfigFileApp.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/RedirectLabviewConfigFile/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{70132C71-6083-44E5-B147-C2FDA8F02649}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Assembly Redirection VIs.lvlib/Redirect Assemblies in LabVIEW Config File.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE</Property>
				<Property Name="TgtF_fileDescription" Type="Str">RedirectLabviewConfigFile</Property>
				<Property Name="TgtF_internalName" Type="Str">RedirectLabviewConfigFile</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE</Property>
				<Property Name="TgtF_productName" Type="Str">RedirectLabviewConfigFile</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{981E064E-5324-4B7F-8382-2D595E7819AA}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">RedirectLabviewConfigFileApp.exe</Property>
			</Item>
			<Item Name="RedirectRemovePaletteItemsProjectXML" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{6BB74D6B-17D6-4BA6-8BF5-8CBDC5DC1426}</Property>
				<Property Name="App_INI_GUID" Type="Str">{E2EFD820-6BFC-4C2A-BF6B-45DE21B52CE5}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{5B4AA03C-0033-49E4-A167-640B3EA13865}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">RedirectRemovePaletteItemsProjectXML</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds/RedirectRemovePaletteItemsProjectXML</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{061F5C6F-46EB-4D65-A032-CBF31EF5F9B7}</Property>
				<Property Name="Bld_version.build" Type="Int">6</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">RedirectRemovePaletteItemsProjectXMLApp.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/RedirectRemovePaletteItemsProjectXML/RedirectRemovePaletteItemsProjectXMLApp.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/RedirectRemovePaletteItemsProjectXML/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{E0AD1BE6-5CD5-40C3-914C-F92491549A30}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Assembly Redirection VIs.lvlib/Redirect Assemblies in RemoveOldInsertionPaletteItems Project XML.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE Embedded</Property>
				<Property Name="TgtF_fileDescription" Type="Str">RedirectRemovePaletteItemsProjectXML</Property>
				<Property Name="TgtF_internalName" Type="Str">RedirectRemovePaletteItemsProjectXML</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE Embedded</Property>
				<Property Name="TgtF_productName" Type="Str">RedirectRemovePaletteItemsProjectXML</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{CBA15950-7D4F-4FF5-9865-1888D145D266}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">RedirectRemovePaletteItemsProjectXMLApp.exe</Property>
			</Item>
			<Item Name="RedirectTestStandPaletteFile" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{4B366AEF-1435-41D4-9874-5A9F7884E1B0}</Property>
				<Property Name="App_INI_GUID" Type="Str">{E2AEC02D-5FAE-4F16-81CD-50F9B2D1FCA6}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{A6BA38A3-56D2-4186-9258-28FC19B62416}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">RedirectTestStandPaletteFile</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds/RedirectTestStandPaletteFile</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{E3BF0415-0541-4070-9709-DF54BC192EFA}</Property>
				<Property Name="Bld_version.build" Type="Int">9</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">RedirectTestStandPaletteFileApp.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/RedirectTestStandPaletteFile/RedirectTestStandPaletteFileApp.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/RedirectTestStandPaletteFile/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{DF19E162-91DB-4A89-B497-712E1A15DEDD}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Assembly Redirection VIs.lvlib/Redirect Assemblies in TestStand Palette ini File.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE Embedded</Property>
				<Property Name="TgtF_fileDescription" Type="Str">RedirectTestStandPaletteFile</Property>
				<Property Name="TgtF_internalName" Type="Str">RedirectTestStandPaletteFile</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE Embedded</Property>
				<Property Name="TgtF_productName" Type="Str">RedirectTestStandPaletteFile</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{893CD7E9-E1B3-48AA-ACF1-9A97FD81EBEB}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">RedirectTestStandPaletteFileApp.exe</Property>
			</Item>
			<Item Name="RedirectVeriStandsStepsProjectXML" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{57F8455F-6028-4BBC-873C-509B8539F4D3}</Property>
				<Property Name="App_INI_GUID" Type="Str">{8CE79CCA-3F2C-44F8-829B-7392E739D838}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{D2F3BA38-5F7C-436F-8256-BFDC5965DC0F}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">RedirectVeriStandsStepsProjectXML</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds/RedirectVeriStandsStepsProjectXML</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{EDD40C4C-4E29-4869-B11E-27E53E07D517}</Property>
				<Property Name="Bld_version.build" Type="Int">15</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">RedirectVeriStandsStepsProjectXML.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/RedirectVeriStandsStepsProjectXML/RedirectVeriStandsStepsProjectXML.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/RedirectVeriStandsStepsProjectXML/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{8F94EA9A-975B-4269-B96C-6C3DFA7B3D38}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Assembly Redirection VIs.lvlib/Redirect Assemblies in Veristand Steps Project XML.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE Embedded</Property>
				<Property Name="TgtF_fileDescription" Type="Str">RedirectVeriStandsStepsProjectXML</Property>
				<Property Name="TgtF_internalName" Type="Str">RedirectVeriStandsStepsProjectXML</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE Embedded</Property>
				<Property Name="TgtF_productName" Type="Str">RedirectVeriStandsStepsProjectXML</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{358D0931-2F8F-4142-BD4B-A2CB0ACDC27D}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">RedirectVeriStandsStepsProjectXML.exe</Property>
			</Item>
			<Item Name="RedirectVersionsSetupProjectFile" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{379399F0-B2A2-4402-9964-B5F7144B85BE}</Property>
				<Property Name="App_INI_GUID" Type="Str">{672C6CFC-C2F6-4367-9574-3561D5B713AF}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{4F99C509-6C4D-458C-8D83-39859F188866}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">RedirectVersionsSetupProjectFile</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds/RedirectVersionsSetupProjectFile</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{E91F1A47-96F2-4DD0-9CE1-153FA1F212E3}</Property>
				<Property Name="Bld_version.build" Type="Int">4</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">RedirectVersionsSetupProjectFileApp.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/RedirectVersionsSetupProjectFile/RedirectVersionsSetupProjectFileApp.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/RedirectVersionsSetupProjectFile/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_cmdLineArgs" Type="Bool">true</Property>
				<Property Name="Source[0].itemID" Type="Str">{70132C71-6083-44E5-B147-C2FDA8F02649}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Assembly Redirection VIs.lvlib/Redirect Versions in Deployment Project File.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_companyName" Type="Str">NIC SE Embedded</Property>
				<Property Name="TgtF_fileDescription" Type="Str">RedirectVersionsSetupProjectFile</Property>
				<Property Name="TgtF_internalName" Type="Str">RedirectVersionsSetupProjectFile</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright © 2017 NIC SE Embedded</Property>
				<Property Name="TgtF_productName" Type="Str">RedirectVersionsSetupProjectFile</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{EE15556A-F954-44AF-9F06-F24517556647}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">RedirectVersionsSetupProjectFileApp.exe</Property>
			</Item>
		</Item>
	</Item>
</Project>
