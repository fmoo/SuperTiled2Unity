# Powershell script that zips ST2U into a package to be installed by Unity Package Manager

try
{
    Push-Location $PSScriptRoot

    # Get the current version of Super Tiled2Unity
    $package_dir = '../SuperTiled2Unity/Packages/com.seanba.super-tiled2unity'
    $package_json = "$package_dir/package.json"
    $version = (Get-Content $package_json | ConvertFrom-Json).version
    $output = "super-tiled2unity.v$version.zip"

    Write-Host Packaging Super Tiled2Unity version $version
    Write-Host $output

    # Note: Zip files made with Compress-Archive are not compatible with Linux
    # Use 7-Zip instead
    & "C:\Program Files\7-Zip\7z.exe" a -tzip -o".\" "$output" "$package_dir\*" -aoa
    Write-Host "Done zipping '$output'"
}
finally
{
    Pop-Location
}