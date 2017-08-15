echo OFF
REM Set up Visual Studio Command Line environment variables.
call "c:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\vsvars32.bat"

REM First passed parameter %1 is the %WORKSPACE% path environment variable from Jenkins.
REM Set up path variables.
SET NIVeriStandCustomTestStandStepsSolutionPath="%~1\Source\C# Code\VeristandStepsInstaller\NI VeriStand Custom TestStand Steps.sln"

REM Build the Installer and RemoveOldInsertionPaletteItems executable.
devenv %NIVeriStandCustomTestStandStepsSolutionPath% /build Release








