$TestRecordingFile = Join-Path 'C:\B\azure-powershell\src\Resources\test' 'New-AzADServicePrincipalPasswordCredential.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'New-AzADServicePrincipalPasswordCredential' {
    It '__AllParameterSets' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
