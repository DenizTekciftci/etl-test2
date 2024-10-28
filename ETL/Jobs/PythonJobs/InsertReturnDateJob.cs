using Quartz;
using Serilog;

namespace PP_Capital.Jobs.PythonJobs;

[DisallowConcurrentExecution]
public class InsertReturnDateJob(ConfigSettings configSettings, ILogger logger) : BasePythonJob(configSettings, logger),IJob
{
    private readonly ConfigSettings _configSettings = configSettings;

    public Task Execute(IJobExecutionContext context1)
    {
        RunScript(_configSettings.PythonPaths.Step0);
        RunScript(_configSettings.PythonPaths.Step3);
        return Task.CompletedTask;
    }
}