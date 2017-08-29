echo ON
REM Set up Visual Studio Command Line environment variables.
call "c:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\vsvars32.bat"

REM First passed parameter %1 is the %WORKSPACE% path environment variable from Jenkins.
REM Set up path variables.
SET VeristandStepsProjectPath="%~1\Source\C# Code\VeristandStepsInstaller\OpenWorkspaceDialog\VeristandSteps.csproj"

REM Build the Installer and RemoveOldInsertionPaletteItems executable.
devenv %VeristandStepsProjectPath% /build Release

move "%~1\Source\C# Code\VeristandStepsInstaller\OpenWorkspaceDialog\bin\Release\NationalInstruments.Veristand.VeristandSteps.dll" "%~1\build_temp\NationalInstruments.Veristand.VeristandSteps.dll"








