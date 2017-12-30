@echo off
set /p name="Enter solution name: "
dotnet new sln -n %name% -o ..