$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $PSScriptRoot

Set-Location $root

Write-Host "Building Trödje Pizzeria..."

dotnet build .\TrodjePizzeriaV2.sln

Write-Host "Build completed."