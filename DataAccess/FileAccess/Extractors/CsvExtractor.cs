using CsvHelper;
using CsvHelper.Configuration;

namespace DataAccess.FileAccess.Extractors;

public class CsvExtractor<T>(ExtractorConfiguration configuration, string filePath) : IExtractor<T>
{
    protected List<T> Extract()
    {
        using var reader = new StreamReader(filePath, configuration.Encoding);
        using var csv = new CsvReader(reader, new CsvConfiguration(configuration.CultureInfo)
        {
            Delimiter = configuration.Delimiter,
            Encoding = configuration.Encoding,
            TrimOptions = TrimOptions.Trim,
            HasHeaderRecord = configuration.HasHeaderRecord,
            ShouldSkipRecord = args => configuration.ShouldSkip(args)
        });
        
        var records = csv.GetRecords<T>().ToList();
        return records;
    }

    public virtual List<T> Extract<T2>(Func<T2, List<T>>? getRecords = null)
    {
        return Extract();
    }
}