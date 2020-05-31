 

reg delete "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\EMDMgmt" /f 

Set-ExecutionPolicy RemoteSigned -Force

Start-Service Sysmain

regsvr32.exe /s c:\RocketDrive\emdmgmt.dll 

New-Item -ItemType Directory -Force -Path c:\RocketDrive

$vhdpath = "c:\RocketDrive\RocketDrive.vhdx"
$vhdsize = 4GB
New-VHD -Path $vhdpath -SizeBytes $vhdsize | Mount-VHD -Passthru  |Initialize-Disk -Passthru |New-Partition –DriveLetter R -UseMaximumSize |Format-Volume  -FileSystem NTFS -NewFileSystemLabel 'RocketDrive' -Confirm:$false -Force 

Get-ChildItem "HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\EMDMgmt" -Recurse | Where {Get-ItemProperty -Path $_.PSPath -Name DeviceStatus -EA SilentlyContinue} | Foreach {Set-ItemProperty -Name DeviceStatus -Path $_.PSPath -Value 1}
Get-ChildItem "HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\EMDMgmt" -Recurse | Where {Get-ItemProperty -Path $_.PSPath -Name DeviceStatus -EA SilentlyContinue} | Foreach {Set-ItemProperty -Name CacheSizeInMB -Path $_.PSPath -Value 2048}

reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons\R\DefaultIcon" /ve  /t REG_SZ /d c:\Users\q1\source\repos\RocketDrive\RocketDrive\res\RocketDrive.ico

Copy-Item -Filter *.vhdx -Path $vhdpath -Recurse -Destination 'c:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp'

