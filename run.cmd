
..\sonar-scanner\SonarScanner.MSBuild.exe begin /k:"org.sonarqube:sonarqube-scanner-msbuild" /n:"Demo C# Project" /v:"1.1" /d:"sonar.host.url=http://192.168.99.100:9000" /d:sonar.cs.xunit.reportsPaths="%CD%\XUnitResults.xml"
msbuild /t:rebuild
.\packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe .\ConsoleApp\bin\Debug\ConsoleApp.exe -xml "%CD%\XUnitResults.xml"


..\sonar-scanner\SonarScanner.MSBuild.exe end