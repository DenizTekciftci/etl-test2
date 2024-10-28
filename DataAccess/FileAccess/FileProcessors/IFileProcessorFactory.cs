using Shared.Enums;

namespace DataAccess.FileAccess.FileProcessors;

public interface IFileProcessorFactory
{
    public IFileProcessor CreateFileProcessor(string filePath, Bank bankEnum);
}