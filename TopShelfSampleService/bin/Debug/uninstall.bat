@echo off
SETLOCAL

cd /d "%~dp0"

sc delete TopShelf SampleService
echo ✅ Service stopped and uninstalled
pause
ENDLOCAL
