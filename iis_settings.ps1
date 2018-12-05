Import-Module WebAdministration
$SiteName = "MyBookStore"
$SiteFolderPath = "C:\Users\dbat\source\repos\BatiutaDen\MyBookStore\Store"
$RepoFolderPath = "C:\Users\dbat\source\repos\BatiutaDen"
$SiteAppPoolName = "MyBookStoreAppPool" 
$SiteHost = "www.PerfectBooks.com"
$GitHubUrl = "https://github.com/BatiutaDen/MyBookStore" 



if(!(Test-Path("$RepoFolderPath"))) { 
New-Item $RepoFolderPath -type Directory # creating folder with repo
Set-Location -Path $RepoFolderPath # go to location where repo is sited
git clone $GitHubUrl

} 
else # if folder exist
{
Set-Location -Path $RepoFolderPath # go to location where repo is sited
git pull
}

Set-Location -Path "$RepoFolderPath\MyBookStore" # go to inner folder in cloned repo
msbuild # build 


$SiteFolderPath = "$RepoFolderPath\MyBookStore\MyBookStore"

if(!(Test-Path ("IIS:\AppPools\$SiteAppPoolName"))) { # if not AppPool -> create it
New-WebAppPool -Name $SiteAppPoolName
}

If((!(Test-Path "IIS:\Sites\$SiteName"))){ # if not site -> create it
New-Website -Name $SiteName -physicalPath $SiteFolderPath -ApplicationPool $SiteAppPoolName 
}

if(!(Get-WebBinding -Name $SiteName)) {
New-WebBinding -Name $SiteName -Protocol http -Port 80 -IPAddress "*" -SiteHost $SiteHost
}
if(Get-Website | where {$_.State -eq 'Stopped'})
{
Start-WebSite -Name $SiteName
}