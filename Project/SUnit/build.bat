C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc /t:library /out:SUnit.Library.dll /o /recurse:\src\Library\SUnit.assert\*.cs
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe /out:SUnit.Runner.exe /o /recurse:..\Run *.cs  /r:SUnit.Library.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Samples.dll /o /recurse:..\Samples\*.cs /r:SUnit.Library.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Test.dll /o /recurse:..\Test\*.cs  /r:..\packages\MSTestExtensions.3.0.0\MSTestExtensions.dll,SUnit.Library.dll,..\packages\Microsoft.VisualStudio.QualityTools.UnitTestFramework.11.0.50727.1\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll

pause