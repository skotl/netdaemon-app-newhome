@echo off

docker build -t ha-addon . --build-arg BUILD_FROM=homeassistant/amd64-base:latest %1 %2 %3 %4 %5
if errorlevel 1 goto fail

docker run -dit ha-addon

goto done


:fail
echo Aborted

:done

