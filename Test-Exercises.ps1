param(
    [ValidateRange(2, 7)][int]$Chapter,
    [string]$Exercise
)
$ErrorActionPreference = 'Stop'
$entries = Get-Content -LiteralPath (Join-Path $PSScriptRoot 'exercises.json') -Raw | ConvertFrom-Json
if ($Chapter) { $entries = @($entries | Where-Object { [int]$_.chapter -eq $Chapter }) }
if ($Exercise) { $entries = @($entries | Where-Object { $_.name -eq $Exercise }) }
if ($entries.Count -eq 0) { throw 'Geen overeenkomstige oefening gevonden.' }
$passed = 0
$failed = 0
$skipped = 0
foreach ($entry in $entries) {
    $folder = Join-Path $PSScriptRoot "Chapter$($entry.chapter)/$($entry.name)"
    $project = Join-Path $folder "$($entry.name)/$($entry.name).csproj"
    if (-not (Test-Path -LiteralPath $project)) {
        Write-Host "NOG NIET GEMAAKT: $($entry.name)"
        $skipped++
        if ($Exercise) { $failed++ }
        continue
    }
    Write-Host "TESTEN: $($entry.name)"
    & dotnet test (Join-Path $folder "$($entry.name).sln") --verbosity minimal
    if ($LASTEXITCODE -eq 0) { $passed++ } else { $failed++ }
}
Write-Host "Oefeningen geslaagd: $passed; mislukt: $failed; nog niet gemaakt: $skipped."
if ($failed -gt 0 -or $passed -eq 0) { exit 1 }
exit 0

