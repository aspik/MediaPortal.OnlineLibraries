
REM copy BuildReport resources
xcopy /I /Y .\BuildReport\_BuildReport_Files .\_BuildReport_Files

set xml=MediaPortal.OnlineLibraries.xml
set html=MediaPortal.OnlineLibraries.html
set logger=/l:XmlFileLogger,"BuildReport\MSBuild.ExtensionPack.Loggers.dll";logfile=%xml%

"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBUILD.exe" %logger% /target:Rebuild /property:Configuration=Release;Platform=x86 "..\MediaPortal.OnlineLibraries.sln"
BuildReport\msxsl %xml% _BuildReport_Files\BuildReport.xslt -o %html%
