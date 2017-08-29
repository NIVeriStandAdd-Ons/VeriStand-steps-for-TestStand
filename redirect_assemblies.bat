echo off

::    Arguments
:: 1: Source directory
:: 2: New VeriStand Version (e.g. 2014.0)
:: 3: New TestStand Version (e.g. 2014.0)
:: 4: New TestStand Registry Version (e.g. 5.1)

SETLOCAL

:: Set up source path variables.
SET RedirectRemovePaletteItemsProjectAppPath="%~1\LabVIEW Code\Assembly Redirection\builds\RedirectRemovePaletteItemsProjectXML\RedirectRemovePaletteItemsProjectXMLApp.exe"
SET OldRemovePaletteItemsProjectPath="%~1\C# Code\VeristandStepsInstaller\RemoveOldInsertionPaletteItems\RemoveOldInsertionPaletteItems.csproj"
SET NewRemovePaletteItemsProjectPath="%~1\C# Code\VeristandStepsInstaller\RemoveOldInsertionPaletteItems\RemoveOldInsertionPaletteItems.csproj"

SET RedirectVeristandStepsAssemblyProjectAppPath="%~1\LabVIEW Code\Assembly Redirection\builds\RedirectVeriStandsStepsProjectXML\RedirectVeriStandsStepsProjectXML.exe"
SET OldAssemblyProjectPath="%~1\C# Code\VeristandStepsInstaller\OpenWorkspaceDialog\VeristandSteps.csproj"
SET NewAssemblyProjectPath="%~1\C# Code\VeristandStepsInstaller\OpenWorkspaceDialog\VeristandSteps.csproj"

SET RedirectTeststandPaletteFileAppPath="%~1\LabVIEW Code\Assembly Redirection\builds\RedirectTestStandPaletteFile\RedirectTestStandPaletteFileApp.exe"
SET OldPaletteFilePath="%~1\TestStand Custom Steps ini Files\NI_VeristandTypes.ini"
SET NewPaletteFilePath="C:\Jenkins\workspace\Intermediate\NI_VeristandTypes.ini"

SET UpdateSetupProjectFileAppPath="%~1\LabVIEW Code\Assembly Redirection\builds\RedirectVersionsSetupProjectFile\RedirectVersionsSetupProjectFileApp.exe"
SET OldSetupProjectFilePath="%~1\C# Code\VeristandStepsInstaller\VeristandStepsInstaller\VeristandStepsInstaller.vdproj"
SET NewSetupProjectFilePath="%~1\C# Code\VeristandStepsInstaller\VeristandStepsInstaller\VeristandStepsInstaller.vdproj"

SET RedirectLabviewConfigFileAppPath="%~1\LabVIEW Code\Assembly Redirection\builds\RedirectLabviewConfigFile\RedirectLabviewConfigFileApp.exe"

:: Set up VeriStand 2013 variables.
IF %2==2013.0 (
	SET VeriStandVersion=2013
	SET VeriStandAssemblyVersion=2013.0.0.0
	SET VeriStandGACAssemblyVersion=4.0.2013.0.0.0
	SET StepsVersion=13.0.5.0
	SET LabviewEXEConfigPath="C:\Program Files (x86)\National Instruments\LabVIEW 2013\LabVIEW.exe.config"
	SET InstallPath="C:\Program Files (x86)\National Instruments\VeriStand 2013"
	)
	
:: Set up VeriStand 2013 SP1 variables.
IF %2==2013.1 (
	SET VeriStandVersion=2013
	SET VeriStandAssemblyVersion=2013.1.0.0
	SET VeriStandGACAssemblyVersion=4.0.2013.1.0.0
	SET StepsVersion=13.1.5.0
	SET LabviewEXEConfigPath="C:\Program Files (x86)\National Instruments\LabVIEW 2013\LabVIEW.exe.config"
	SET InstallPath="C:\Program Files (x86)\National Instruments\VeriStand 2013"
	)
	
:: Set up VeriStand 2014 variables.
IF %2==2014.0 (
	SET VeriStandVersion=2014
	SET VeriStandAssemblyVersion=2014.0.0.0
	SET VeriStandGACAssemblyVersion=4.0.2014.0.0.0
	SET StepsVersion=14.0.5.0
	SET LabviewEXEConfigPath="C:\Program Files (x86)\National Instruments\LabVIEW 2014\LabVIEW.exe.config"
	SET InstallPath="C:\Program Files (x86)\National Instruments\VeriStand 2014"
	)
	
:: Set up VeriStand 2015 variables.
IF %2==2015.0 (
	SET VeriStandVersion=2015
	SET VeriStandAssemblyVersion=2015.0.0.0
	SET VeriStandGACAssemblyVersion=4.0.2015.0.0.0
	SET StepsVersion=15.0.5.0
	SET LabviewEXEConfigPath="C:\Program Files (x86)\National Instruments\LabVIEW 2015\LabVIEW.exe.config"
	SET InstallPath="C:\Program Files (x86)\National Instruments\VeriStand 2015"
	)
	
:: Set up VeriStand 2015 SP1 variables.
IF %2==2015.1 (
	SET VeriStandVersion=2015SP1
	SET VeriStandAssemblyVersion=2015.1.0.0
	SET VeriStandGACAssemblyVersion=4.0.2015.1.0.0
	SET StepsVersion=15.1.5.0
	SET LabviewEXEConfigPath="C:\Program Files (x86)\National Instruments\LabVIEW 2015\LabVIEW.exe.config"
	SET InstallPath="C:\Program Files (x86)\National Instruments\VeriStand 2015"
	)

:: Set up VeriStand 2016 variables.
IF %2==2016.0 (
	SET VeriStandVersion=2016
	SET VeriStandAssemblyVersion=2016.0.0.0
	SET VeriStandGACAssemblyVersion=4.0.2016.1.0.0
	SET StepsVersion=16.0.5.0
	SET LabviewEXEConfigPath="C:\Program Files (x86)\National Instruments\LabVIEW 2016\LabVIEW.exe.config"
	SET InstallPath="C:\Program Files (x86)\National Instruments\VeriStand 2016"
	)
	
:: Set up TestStand 2013 variables.
IF %3==2013.0 (
	SET TestStandVersion=2013
	SET TestStandInteropAssemblyVersion=5.1.0.226
	SET TestStandUtilityAssemblyVersion=5.1.0.226
	SET TestStandRegistryVersion=5.1
	SET TestStandInstallPathString=2013
	)
:: Set up TestStand 2014 variables.
IF %3==2014.0 (
	SET TestStandVersion=2014
	SET TestStandInteropAssemblyVersion=14.0.1.103
	SET TestStandUtilityAssemblyVersion=14.0.1.103
	SET TestStandRegistryVersion=14.0
	SET TestStandInstallPathString="2014 (32-bit)"
	)
:: Set up TestStand 2016 variables.
IF %3==2016.0 (
	SET TestStandVersion=2014
	SET TestStandInteropAssemblyVersion=16.0.0.185
	SET TestStandUtilityAssemblyVersion=16.0.0.185
	SET TestStandRegistryVersion=16.0
	SET TestStandInstallPathString="2016 (32-bit)"
	)
	
echo Redirect assemblies in LabVIEW.exe config file.
:: Arguments
:: 1: Old LV.exe config file path.
:: 2: New LV.exe config file path. 
:: 3: New TS Assembly Version
:: 4: New VS Assembly Version

%RedirectLabviewConfigFileAppPath% %LabviewEXEConfigPath% %LabviewEXEConfigPath% %TestStandInteropAssemblyVersion% %VeristandAssemblyVersion%

echo Redirect assemblies in RemoveOldInsertionPaletteItems Project (.vsproj) File. 
::    Arguments
:: 1: Old Project Path
:: 2: New Project Path
:: 3: New TS Version (2014)
:: 4: New TS Utility Version (2014.0.0.0)
:: 5: New TS Interop Version (2014.0.0.0)

%RedirectRemovePaletteItemsProjectAppPath% %OldRemovePaletteItemsProjectPath% %NewRemovePaletteItemsProjectPath% %3 %TestStandUtilityAssemblyVersion% %TestStandInteropAssemblyVersion%

echo Redirect assemblies in VeristandSteps Assembly Project (.vsproj) file.
::Arguments
:: 1: original path (string)
:: 2: new path (string)
:: 3: TS Version (2014)
:: 4: TS Interop Assembly Version (14.0.0.0)
:: 5: TS Utility Assembly Version (14.0.0.0)
:: 6: VS Assembly Version (GAC format, 4.0.2016.0.0.0)
:: 7: VS Assembly Version (2016.0.0.0)

%RedirectVeristandStepsAssemblyProjectAppPath% %OldAssemblyProjectPath% %NewAssemblyProjectPath% %TestStandVersion% %TestStandInteropAssemblyVersion% %TestStandUtilityAssemblyVersion% %VeristandGACAssemblyVersion% %VeristandAssemblyVersion%

echo Redirect assemblies in TestStand Custom TypePalette (.ini) file.
:: Arguments
:: 1: Old TS ini File Location
:: 2: New TS ini File Location
:: 3: New VS Assembly Version
:: 4: Steps Version
:: 5: VeriStand installation directory

%RedirectTeststandPaletteFileAppPath% %OldPaletteFilePath% %NewPaletteFilePath% %VeristandAssemblyVersion% %StepsVersion% %InstallPath%

echo Updating versions in Setup & Deployment project (.vdproj) file.
:: Arguments
:: .vdproj File Source Path
:: .vdproj File Destination Path
:: New TestStand Version (e.g. 20XX)
:: New TestSTand Registry Version (e.g. X.Y)
:: New VeriStand Version (20XX)

%UpdateSetupProjectFileAppPath% %OldSetupProjectFilePath% %NewSetupProjectFilePath% %TestStandInstallPathString% %TestStandRegistryVersion% %VeriStandVersion%
