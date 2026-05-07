[Setup]
AppName=Pine POS
AppVersion=1.0
DefaultDirName={autopf}\Pine POS
DefaultGroupName=Pine Business
UninstallDisplayIcon={app}\PineBusinessGrowLauncher.exe
Compression=lzma2
SolidCompression=yes
OutputDir=.\Output
OutputBaseFilename=PinePOSSetup
; This assumes your logo is in the root folder
SetupIconFile=pine-logo.ico 

[Files]
; This grabs the compiled AOT exe and puts it in the installation folder
Source: "dist\PineBusinessGrowLauncher.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
; Creates the Start Menu shortcut
Name: "{group}\Pine POS"; Filename: "{app}\PineBusinessGrowLauncher.exe"
; Creates the Desktop shortcut
Name: "{autodesktop}\Pine POS"; Filename: "{app}\PineBusinessGrowLauncher.exe"

[Run]
; Offers to launch the POS immediately after installation finishes
Filename: "{app}\PineBusinessGrowLauncher.exe"; Description: "Launch Pine POS now"; Flags: nowait postinstall skipifsilent