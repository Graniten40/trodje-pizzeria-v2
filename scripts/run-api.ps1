$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $PSScriptRoot
$apiPath = Join-Path $root "src\PizzeriaOrder.Api"

Set-Location $apiPath

Write-Host "Starting PizzeriaOrder.Api..."

dotnet run