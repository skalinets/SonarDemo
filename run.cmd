..\sonar-scanner\SonarScanner.MSBuild.exe begin /k:"org.sonarqube:sonarqube-scanner-msbuild" /n:"Demo C# Project" /v:"1.17" /d:"sonar.host.url=http://192.168.99.100:9000" /d:sonar.cs.xunit.reportsPaths="%CD%\XUnitResults.xml" /d:sonar.cs.dotcover.reportsPaths="%CD%\dotCover.html" /d:sonar.resharper.cs.reportPath="%CD%\resharper.xml" /d:sonar.resharper.solutionFile="%CD%\SonarDemo.sln"

"C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\\MSBuild\15.0\bin\MSBuild.exe" /t:rebuild

".\packages\JetBrains.dotCover.CommandLineTools.2017.3.5\tools\dotCover.exe" analyse /ReportType=HTML /Output="%CD%\dotCover.html" /TargetExecutable=".\packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe" -TargetArguments:".\Our.Tests\bin\Debug\Our.Tests.dll -xmlv1 XUnitResults.xml" -Filter="-:module=xunit*"

".\packages\JetBrains.ReSharper.CommandLineTools.2017.3.5\tools\inspectcode.exe" /output="%CD%\resharper.xml" "%CD%\SonarDemo.sln"

..\sonar-scanner\SonarScanner.MSBuild.exe end