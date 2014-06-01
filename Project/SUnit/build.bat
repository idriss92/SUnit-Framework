..\.nuget\NuGet.exe restore ..\SUnit.sln
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library  /out:SUnit.Assert.dll /o /recurse:..\src\SUnit.assert\*.cs
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /out:SUnit.Console.exe /o /recurse:..\src\SUnit.console\*.cs  /r:SUnit.Library.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Samples.dll /o /recurse:..\Samples\SUnit.Samples\*.cs /r:SUnit.Library.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Core.dll /o /recurse:..\src\SUnit.core\*.cs /r:SUnit.Library.dll
%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:library /out:SUnit.Test.dll /o /recurse:..\Test\SUnit.Test\*.cs  /r:..\packages\MSTestExtensions.3.0.0\MSTestExtensions.dll,SUnit.Library.dll,..\packages\Microsoft.VisualStudio.QualityTools.UnitTestFramework.11.0.50727.1\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll