..\sonar-scanner\SonarScanner.MSBuild.exe begin /k:"org.sonarqube:sonarqube-scanner-msbuild" /n:"Demo C# Project" /v:"1.7" /d:"sonar.host.url=http://192.168.99.100:9000" /d:sonar.cs.xunit.reportsPaths="%CD%\XUnitResults.xml" /d:sonar.cs.dotcover.reportsPaths="%CD%\dotCover.html"

msbuild /t:rebuild


"%LOCALAPPDATA%\JetBrains\Installations\dotCover11\dotCover.exe" analyse /ReportType=HTML /Output="%CD%\dotCover.html" /TargetExecutable=".\packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe" -TargetArguments:".\Our.Tests\bin\Debug\Our.Tests.dll -xmlv1 XUnitResults.xml" -Filter="-:module=xunit*"

..\sonar-scanner\SonarScanner.MSBuild.exe end