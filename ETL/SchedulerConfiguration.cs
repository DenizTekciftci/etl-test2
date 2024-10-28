using Microsoft.Extensions.DependencyInjection;
using PP_Capital.Jobs;
using PP_Capital.Jobs.PythonJobs;
using Quartz;

namespace PP_Capital;

public static class SchedulerConfiguration
{
    public static void ConfigureServices(IServiceCollection services, ConfigSettings configuration)
    {
        services.Configure<QuartzOptions>(options =>
        {
            options.Scheduling.IgnoreDuplicates = true; // default: false
            options.Scheduling.OverWriteExistingData = true; // default: true
        });

        services.AddQuartz(q =>
        {
            // these are the defaults
            q.UseSimpleTypeLoader();
            q.UseInMemoryStore();
            q.UseDefaultThreadPool(tp => { tp.MaxConcurrency = 4; });

            // var etlJobKey = new JobKey("ETL Key");
            // q.AddJob<ETLJob>(opts => opts.WithIdentity(etlJobKey));
            // q.AddTrigger(opts => opts
            //     .ForJob(etlJobKey)
            //     .WithIdentity("ETL Trigger")
            //     .WithCronSchedule(configuration.CronExpressions.ETL)
            // );

            // var fileMoverJobKey = new JobKey("File Mover Key");
            // q.AddJob<FileMoverJob>(opts => opts.WithIdentity(fileMoverJobKey));
            // q.AddTrigger(opts => opts
            //     .ForJob(fileMoverJobKey)
            //     .WithIdentity("File Mover Trigger")
            //     .WithCronSchedule(configuration.CronExpressions.FileMover)
            // );

            // var holdingsValidationJobKey = new JobKey("Holding Validation Key");
            // q.AddJob<HoldingsValidationJob>(opts => opts.WithIdentity(holdingsValidationJobKey));
            // q.AddTrigger(opts => opts
            //     .ForJob(holdingsValidationJobKey)
            //     .WithIdentity("Holding Validation Trigger")
            //     .WithCronSchedule(configuration.CronExpressions.HoldingsValidation)
            // );

            // var insertReturnDateJobKey = new JobKey("Insert Return Date Key");
            // q.AddJob<InsertReturnDateJob>(opts => opts.WithIdentity(insertReturnDateJobKey));
            // q.AddTrigger(opts => opts
            //     .ForJob(insertReturnDateJobKey)
            //     .WithIdentity("Insert Return Date Trigger")
            //     .WithCronSchedule(configuration.CronExpressions.InsertReturnDate)
            // );

            // var insertPricesJobKey = new JobKey("Insert Prices Key");
            // q.AddJob<InsertPricesJob>(opts => opts.WithIdentity(insertPricesJobKey));
            // q.AddTrigger(opts => opts
            //     .ForJob(insertPricesJobKey)
            //     .WithIdentity("Insert Prices Trigger")
            //     .WithCronSchedule(configuration.CronExpressions.InsertPrices)
            // );
        });

        // Quartz.Extensions.Hosting allows you to fire background service that handles scheduler lifecycle
        services.AddQuartzHostedService(options =>
        {
            // when shutting down we want jobs to complete gracefully
            options.WaitForJobsToComplete = true;
        });
    }
}