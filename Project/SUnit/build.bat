%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Framework.dll /o /recurse:src\Framework\*.cs
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe /out:SUnit.Runner.exe /o /recurse:src\Run\*.cs  /r:SUnit.Framework.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Samples.dll /o /recurse:Samples\*.cs /r:SUnit.Framework.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Test.dll /o /recurse:Test\*.cs  /r:..\packages\MSTestExtensions.3.0.0\MSTestExtensions.dll,SUnit.Library.dll,..\packages\Microsoft.VisualStudio.QualityTools.UnitTestFramework.11.0.50727.1\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll

pause