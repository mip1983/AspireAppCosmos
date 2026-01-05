using Azure.Provisioning.KeyVault;

var builder = DistributedApplication.CreateBuilder(args);

var secrets = builder.AddAzureKeyVault("secrets");
var cosmosDbAccount = builder.AddAzureCosmosDB("cosmos").WithAccessKeyAuthentication(secrets);
var cosmosDbDatabase = cosmosDbAccount.AddCosmosDatabase("cosmosDatabase", "cosmosDb");

var api = builder.AddProject<Projects.Api>("api")
    .WithReference(secrets)
        .WithRoleAssignments(secrets,
            KeyVaultBuiltInRole.KeyVaultReader,
            KeyVaultBuiltInRole.KeyVaultSecretsUser,
            KeyVaultBuiltInRole.KeyVaultCertificateUser,
            KeyVaultBuiltInRole.KeyVaultCryptoServiceEncryptionUser)
        .WaitFor(secrets)
    .WithReference(cosmosDbDatabase);

builder.AddProject<Projects.BlazorApp1>("blazorapp1")
    .WithReference(api);

builder.Build().Run();
