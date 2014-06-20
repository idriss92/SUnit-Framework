pause

if not exist "build" mkdir "build"
echo "file create"

pause

%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:build\SUnit.Framework.dll /o /recurse:src\Framework\*.cs
pause
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe /out:build\SUnit.Runner.exe /o /recurse:src\Run\*.cs  /r:build\SUnit.Framework.dll
pause
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:build\SUnit.Samples.dll /o /recurse:Samples\*.cs /r:build\SUnit.Framework.dll

pause
echo "nom"
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe  SUnit.sln /t:Rebuild 

# Test\Assertions\BooleanTest  /t:library /out:build\SUnit.Test.dll /o /recurse:Test\*.cs  
start build\SUnit.Runner.exe build\SUnit.Samples.dll

pause
 if not exist "build\TestNunit" mkdir "build\TestNunit"


packages\NUnit.Runners.2.6.3\tools\nunit-console.exe SUnit.Test.dll "SUnit\Test\Assertions\BooleanTest\bin\Debug\BooleanTest.dll" /xml:"build\TestUnit\Test.xml" 
 pause
C:\Users\SI\Documents\GitHub\SUnit-Framework\Project\SUnit\
packages\NUnit.Runners.2.6.3\tools\nunit-console.exe SUnit.Test.dll /Framework:net-4.5  /xml:"build\TestUnit\Test.xml" 
 
 
 pause
  %__UnitLib.1% /framework:net-4.5



pause