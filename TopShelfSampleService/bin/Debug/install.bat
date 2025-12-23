@echo off
SETLOCAL

echo ===============================
echo Topshelf Service Installation
echo ===============================

REM Ask user for service name
set /p SERVICE_NAME=Enter Service Name: 

IF "%SERVICE_NAME%"=="" (
    echo ❌ Service name cannot be empty
    pause
    exit /b 1
)

REM Move to current directory
cd /d "%~dp0"

echo Installing service "%SERVICE_NAME%" ...

TopShelfSampleService.exe install ^
  -servicename "%SERVICE_NAME%" ^
  -displayname "%SERVICE_NAME%" ^
  -description "Topshelf service hosted with dynamic name"

IF %ERRORLEVEL% NEQ 0 (
    echo ❌ Service installation failed
    pause
    exit /b 1
)

echo Starting service "%SERVICE_NAME%" ...

TopShelfSampleService.exe start -servicename "%SERVICE_NAME%"

IF %ERRORLEVEL% NEQ 0 (
    echo ❌ Service start failed
    pause
    exit /b 1
)

echo ✅ Service "%SERVICE_NAME%" installed and started successfully
pause
ENDLOCAL
