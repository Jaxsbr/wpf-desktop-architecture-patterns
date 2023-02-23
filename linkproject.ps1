$slnItem = (Get-ChildItem $PWD | Where-Object { $_.Name.EndsWith(".sln") })[0]
$slnName = $slnItem.Name.Replace(".sln", "")
$projectDirectories = Get-ChildItem $PWD | Where-Object { $_.Name.StartsWith("Example.")}

Write-Host $slnName

foreach ($item in $projectDirectories) {
    Write-Host $item
    $dotnetCommand = "dotnet sln $slnName add $item/$item.csproj"
    Write-Host $dotnetCommand

    Invoke-Expression $dotnetCommand
}