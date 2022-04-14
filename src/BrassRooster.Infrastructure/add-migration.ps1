$outputFolder = 'Persistence/Migrations'

$migrationName = Read-Host -Prompt 'Input your migration name'

dotnet ef migrations add $migrationName `
	--startup-project ../BrassRooster.WebApi/BrassRooster.WebApi.csproj `
	--project ./BrassRooster.Infrastructure.csproj `
	--context BrassRoosterDbContext `
	--output-dir $outputFolder