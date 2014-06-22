if not exist "build" mkdir "build"
echo "file create"

pause
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:build\SUnit.Framework.dll /o /recurse:src\Framework\*.cs
echo "framework generated in build file"
pause
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe /out:build\SUnit.Runner.exe /o /recurse:src\Run\*.cs  /r:build\SUnit.Framework.dll
echo "framework generated in build file"
pause
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:build\SUnit.Samples.dll /o /recurse:Samples\*.cs /r:build\SUnit.Framework.dll
pause
echo "nom"
start build\SUnit.Runner.exe build\SUnit.Samples.dll 
pause