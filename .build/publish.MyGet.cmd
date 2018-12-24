@echo off
SET vsPath=
FOR /F "tokens=* USEBACKQ" %%g IN (
   `"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere" -products * -property installationPath`) DO (
   SET vsPath=%%g
)

@call "%vsPath%\Common7\Tools\VsDevCmd.bat"

MSBuild.exe /nologo /v:minimal /p:Configuration=Release build.xml /t:PublishToMyGet

pause