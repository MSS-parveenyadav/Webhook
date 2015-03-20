@echo off
echo Git Automatic Pull Process Start.....
E:
cd "E:\CodeDemo\Github\Webhook"

 
set GIT_PATH="C:\Program Files (x86)\Git\cmd\git.exe"
set BRANCH = "origin"
 
:P
echo I am here: %cd%
%GIT_PATH% pull %BRANCH%
goto PAUSE