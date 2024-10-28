using System.IO.Compression;
using DataAccess.DatabaseAccess.Banks;
using DataAccess.FileAccess.FileProcessors;
using Quartz;
using Serilog;
using Shared.Enums;

namespace PP_Capital.Jobs;

[DisallowConcurrentExecution]
public class FileMoverJob(ConfigSettings configSettings, ILogger logger) : IJob
{
    public Task Execute(IJobExecutionContext context1)
    {
        var directories = configSettings.BankConfigs.GetConfigs();

        foreach (var (source, unprocessed, archive, bank) in directories)
        {
            // Get files
            var files = Directory.GetFiles(source);
            var fileInfos = files.Select(f => new FileInfo(f)).Where(f => f.LastWriteTime > DateTime.Today).ToList();
            foreach (var fileInfo in fileInfos)
            {
                if (bank == Bank.EFG)
                {
                    // for EFG we copy the .zip and .sig to archive, and unzip the contents into unprocessed
                    if (File.Exists($"{archive}/{fileInfo.Name}"))
                    {
                        Console.WriteLine("File already moved");
                    }
                    else
                    {
                        File.Copy(fileInfo.FullName, $"{archive}/{fileInfo.Name}");
                        if (fileInfo.Extension == ".zip")
                        {
                            using ZipArchive zipArchive = ZipFile.OpenRead(fileInfo.FullName);
                            // Loop through each file in the ZIP archive
                            foreach (ZipArchiveEntry entry in zipArchive.Entries)
                            {
                                // Build the new file name with the prefix
                                string destinationFileName = Path.Combine(unprocessed, $"{fileInfo.Name}_{entry.Name}");

                                // Extract the file with the new name
                                entry.ExtractToFile(destinationFileName, overwrite: true); // Set overwrite to true if needed
                            }
                        }
                    }
                }
                else
                {
                    // If the file exist in the archive, it has already been processed
                    // Otherwise, move it to unprocessed
                    if (File.Exists($"{archive}/{fileInfo.Name}"))
                        Console.WriteLine("File already moved");
                    else
                    {
                        Console.WriteLine("File moving file");
                        File.Copy(fileInfo.FullName, $"{unprocessed}/{fileInfo.Name}", true);
                    }
                }
            }

        }
        
        return Task.CompletedTask;
    }
}