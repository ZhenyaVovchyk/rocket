Dismount-VHD -Path "c:\RocketDrive\RocketDrive.vhdx"
Remove-Item -Path C:\RocketDrive -Recurse

Remove-Item -Path 'c:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\RocketDrive.vhdx' -Recurse

reg delete HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons\R  /f