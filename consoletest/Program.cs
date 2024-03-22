using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.CommandLine;


IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddEnvironmentVariables()
    .AddJsonFile("./Config/config.json")
    .AddCommandLine(args)
    .Build();


//var name = "test";
// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello from first, { configuration["name"] }");
Console.ReadLine();

