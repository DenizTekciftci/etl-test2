using Quartz;
using Serilog;

namespace PP_Capital.Jobs.PythonJobs;

[DisallowConcurrentExecution]
public class InsertPricesJob(ConfigSettings configSettings, ILogger logger) : BasePythonJob(configSettings, logger),IJob
{
    private readonly ConfigSettings _configSettings = configSettings;

    public Task Execute(IJobExecutionContext context1)
    {
        RunScript(_configSettings.PythonPaths.Step6);
        return Task.CompletedTask;
    }
}