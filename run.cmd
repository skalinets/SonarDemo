..\sonar-scanner\SonarScanner.MSBuild.exe begin /k:"org.sonarqube:sonarqube-scanner-msbuild" /n:"Demo C# Project" /v:"1.5" /d:"sonar.host.url=http://192.168.99.100:9000" /d:sonar.cs.xunit.reportsPaths="%CD%\XUnitResults.xml" /d:sonar.cs.opencover.reportsPaths="%CD%\results.xml"

msbuild /t:rebuild

.\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:".\packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe" -targetargs:".\Our.Tests\bin\Debug\Our.Tests.dll -xml XUnitResults.xml" -register:user -filter:"+[*]*" -oldstyle

..\sonar-scanner\SonarScanner.MSBuild.exe end