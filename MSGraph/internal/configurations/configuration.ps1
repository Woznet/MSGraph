﻿<#
This is an example configuration file

By default, it is enough to have a single one of them,
however if you have enough configuration settings to justify having multiple copies of it,
feel totally free to split them into multiple files.
#>

<#
# Example Configuration
Set-PSFConfig -Module 'MSGraph' -Name 'Example.Setting' -Value 10 -Initialize -Validation 'integer' -Handler { } -Description "Example configuration setting. Your module can then use the setting using 'Get-PSFConfigValue'"
#>

Set-PSFConfig -Module 'MSGraph' -Name 'Import.DoDotSource' -Value $false -Initialize -Validation 'bool' -Description "Whether the module files should be dotsourced on import. By default, the files of this module are read as string value and invoked, which is faster but worse on debugging."
Set-PSFConfig -Module 'MSGraph' -Name 'Import.IndividualFiles' -Value $false -Initialize -Validation 'bool' -Description "Whether the module files should be imported individually. During the module build, all module code is compiled into few files, which are imported instead by default. Loading the compiled versions is faster, using the individual files is easier for debugging and testing out adjustments."
Set-PSFConfig -Module 'MSGraph' -Name 'Tenant.Application.ClientID' -Value "1930085c-c139-42f5-8d1a-0b9c88ca43e3" -Initialize -Validation 'string' -Description "Well known ClientID from registered Application in Azure tenant"
Set-PSFConfig -Module 'MSGraph' -Name 'Tenant.Application.RedirectUrl' -Value "https://localhost" -Initialize -Validation 'string' -Description "Redirection URL specified in MS Azure Application portal for the registered application"
Set-PSFConfig -Module 'MSGraph' -Name 'Query.ResultSize' -Value 100 -Initialize -Validation integer -Description "Limit of amount of records returned by a function. Use 0 for unlimited."