using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.CommandLine;

// See https://aka.ms/new-console-template for more information
IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddEnvironmentVariables()
    .AddJsonFile("./Config/config.json")
    .AddCommandLine(args)
    .Build();



Console.WriteLine($"Hello, World! from second {configuration["name"]}");
Console.ReadLine();
