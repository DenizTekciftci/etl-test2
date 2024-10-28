using DataAccess.FileAccess.FileProcessors;
using Quartz;
using Serilog;

namespace PP_Capital.Jobs;

[DisallowConcurrentExecution]
public class ETLJob(IFileProcessorFactory fileProcessorFactory, ConfigSettings configSettings, ILogger logger) : IJob
{
    public Task Execute(IJobExecutionContext context1)
    {
        var directories = configSettings.BankConfigs.GetConfigs();
        
        foreach (var (_, directory, archive, bank) in directories)
        {   
            // Get files
            var files = Directory.GetFiles(directory);
            if (files.Length == 0)
                Console.WriteLine($"No files processed for bank: {bank}");
            foreach(var file in files)
            {
                // Process file
                try
                {
                    var fileProcessor = fileProcessorFactory.CreateFileProcessor(file, bank);
                    fileProcessor.Process();
                }
                catch (Exception e)
                {
                    logger.Error(e, e.Message);
                }
                finally
                {
                    // Move to archive
                    var fileName = Path.GetFileName(file);
                    File.Move(file, $"{archive}/{fileName}", true);
                }
            }
        }

        return Task.CompletedTask;
    }
}