# MeetMePlus
1. Add msbuild to your PATH: 

run "reg.exe query "HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v MSBuildToolsPath" on cmd

add file path to PATH

2. Download .NET Framework: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48

3. Download LocalDB:

https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16

Media Files

LocalDB

4. Run SqlServer: 

run this commands on powershell:

MsiExec.exe /i SqlLocalDB.msi IACCEPTSQLLOCALDBLICENSETERMS=YES /qn | Out-Null

sqllocaldb stop MSSQLLocalDB

sqllocaldb delete MSSQLLocalDB

sqllocaldb start MSSQLLocalDB

5. build both projects with msbuild command

