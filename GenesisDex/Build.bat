@Echo off
cd C:\Windows\Microsoft.NET\Framework\v4*
msbuild "%~dp0PokeGenesis.sln" /t:Rebuild /p:Configuration=Debug /p:Platform="Any CPU"