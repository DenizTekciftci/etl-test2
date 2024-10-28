using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Deleters;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.FileProcessors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PP_Capital;
using Serilog;

ConfigSettings configSettings = new();

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false)
    .AddJsonFile($"appsettings.{Environment.MachineName}.json", true)
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>(true)
    .Build();

configuration.Bind(configSettings);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

Host.CreateDefaultBuilder(args)
    .UseWindowsService()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddDbContextFactory<PpcapitalContext>(options => options.UseMySQL(configSettings.PPCapitalDBConnectionString));
        services.AddDbContext<PpcapitalContext>(options => options.UseMySQL(configSettings.PPCapitalDBConnectionString));
        services.AddSingleton(configSettings);
        services.AddSingleton(Log.Logger);
        services.AddSingleton<IFileProcessorFactory, FileProcessorFactory>();
        services.AddSingleton<IBankFactory, BankFactory>();
        services.AddSingleton<ITransformerFactory, TransformerFactory>();
        services.AddSingleton<IInstrumentHelper, InstrumentHelper>();
        services.AddSingleton<IAccountHelper, AccountHelper>();
        services.AddSingleton<ILoader, Loader>();
        services.AddSingleton<IDeleter, Deleter>();
        SchedulerConfiguration.ConfigureServices(services, configSettings);
    })
    .Build().Run();