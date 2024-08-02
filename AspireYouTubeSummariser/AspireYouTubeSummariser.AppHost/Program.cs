var builder = DistributedApplication.CreateBuilder(args);

var config = builder.Configuration;

var backend = builder.AddProject<Projects.backend>("backend")
                    .WithEnvironment("OpenAI__Endpoint", config["OpenAI:Endpoint"])
                    .WithEnvironment("OpenAI__ApiKey", config["OpenAI:ApiKey"])
                    .WithEnvironment("OpenAI__DeploymentName", config["OpenAI:DeploymentName"]);


builder.AddProject<Projects.frontend>("frontend")
       .WithReference(backend);

builder.Build().Run();
