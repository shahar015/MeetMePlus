# MeetMePlus
1. Add msbuild to your PATH:
  run "reg.exe query "HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v MSBuildToolsPath" on cmd
  add file path to PATH

2. Download .NET Framework: 
  https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48

3. Run SqlServer:
  run this commands on powershell:
     MsiExec.exe /i SqlLocalDB.msi IACCEPTSQLLOCALDBLICENSETERMS=YES /qn | Out-Null
     sqllocaldb stop MSSQLLocalDB
     sqllocaldb delete MSSQLLocalDB
     sqllocaldb start MSSQLLocalDB
     
4. build both projects with msbuild command


