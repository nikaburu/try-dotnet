@echo off

rem Find solution file name
set folder=%cd%
where /R %folder%\.. *.sln > tmpFile
set /p solution= < tmpFile 
del tmpFile 

for %%a in (%solution%) do (
    set file=%%~fa
    set filepath=%%~dpa
    set filename=%%~nxa
)    
set solution=%filename:.sln=%
echo Solution found: %solution%.sln

rem Calculate project name
set /p input="Enter project name: "
echo %input% | findstr /C:"%solution%">nul && (
    echo Project name contains solution name.
    set project=%input%    
) || ( 
    echo Project name does not contain solution name.
    set project=%solution%.%input%
)
echo Full project name is %project%

rem Create project in solution
dotnet new classlib -n %project% -o ..\src\%project%\
dotnet sln ..\%solution%.sln add ..\src\%project%\%project%.csproj