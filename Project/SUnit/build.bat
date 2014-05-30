..\.nuget\NuGet.exe restore ..\SUnit.sln
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library  /out:SUnit.Library.dll /o /recurse:..\src\SUnit.Library\*.cs
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /out:LVUnit.Console.exe /o /recurse:..\src\LVUnit.Console\*.cs  /r:LVUnit.Library.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Samples.dll /o /recurse:..\samples\SUnit.Samples\*.cs /r:LVUnit.Library.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Test.dll /o /recurse:..\test\LVUnit.Test\*.cs  /r:..\packages\MSTestExtensions.3.0.0\MSTestExtensions.dll,LVUnit.Library.dll,..\packages\Microsoft.VisualStudio.QualityTools.UnitTestFramework.11.0.50727.1\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll