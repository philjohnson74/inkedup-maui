# inkedup-maui

New app:
> dotnet new maui -n "inkedup-maui"

To run it, CD into the app folder then…

For OSX
> dotnet build -t:Run -f net6.0-maccatalyst

For iOS... Open XCode and go to Windows --> Device and Simulators --> Simulators --> iPhone 13 Pro Max and replace the udid in the command
> dotnet build -t:Run -f net6.0-ios -p:_DeviceName=:v2:udid=95B96C98-EB5B-4806-8224-3482D3076AA6

For Android… first start a device emulator
> dotnet build -t:Run -f net6.0-android