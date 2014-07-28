.\build.ps1
if ($LASTEXITCODE -eq 0)
{
    .\tests.ps1
}
else
{
    Write-Warning "Compile failed";
}
