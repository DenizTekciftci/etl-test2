namespace DataAccess.FileAccess;

public class BankFileReader
{
    public static List<string> GetAllFilesInDirectory(List<string> directoryPaths)
    {
        // Foreach directoryPath get files
        var allFiles = new List<string>();
        foreach (var directoryPath in directoryPaths)
        {
            allFiles.AddRange(Directory.GetFiles(directoryPath));
        }
        
        return allFiles;
    }
} 