"C:\Program Files (x86)\NUnit 2.6.1\bin\nunit-console.exe" /labels /out=TestResult.txt /xml=TestResult.xml /framework=net-4.0 PlaySpecflowReport\PlaySpecflowReport\bin\Debug\PlaySpecflowReport.dll 
 
"C:\TeamCity\buildAgent\work\d3fcc9e981ebd8dc\packages\SpecFlow.2.1.0\tools\specflow.exe" nunitexecutionreport PlaySpecflowReport\PlaySpecflowReport\PlaySpecflowReport.csproj

IF NOT EXIST TestResult.html GOTO FAIL
EXIT 
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1