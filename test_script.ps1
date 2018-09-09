param([string]$testProject)

dotnet test $testProject

if($LastExitCode -ne 0) {
	$host.SetShouldExit($LastExitCode )
}