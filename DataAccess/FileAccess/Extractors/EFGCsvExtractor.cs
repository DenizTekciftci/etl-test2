using DataAccess.FileAccess.BankFileTypes.EFG;

namespace DataAccess.FileAccess.Extractors;

public class EFGCsvExtractor<T>(ExtractorConfiguration configuration, string filePath) : CsvExtractor<T>(configuration, filePath) where T : IEFGType
{
    public override List<T> Extract<T2>(Func<T2, List<T>>? getRecords = null)
    {
        using var reader = new StreamReader(filePath, configuration.Encoding);
        var metaData = PreprocessMetadata(reader);
        var extracted = Extract();
        return extracted.Select(e =>
            {
                e.metaData = metaData;
                return e;
            }
        ).ToList();
    }
    
    private static MetaData PreprocessMetadata(StreamReader reader)
    {
        var metadata = new MetaData();

        while (reader.ReadLine() is { } line)
        {
            if (line.StartsWith("START-OF-DATA"))
            {
                break;
            }

            if (line.Contains('='))
            {
                var parts = line.Split('=');
                var key = parts[0].Trim();
                var value = parts[1].Trim();

                switch (key)
                {
                    case "ExtractionTime":
                        metadata.ExtractionTime = value;
                        break;
                    case "FromDate":
                        metadata.FromDate = DateTime.Parse(value);
                        break;
                    case "ToDate":
                        metadata.ToDate = DateTime.Parse(value);
                        break;
                    case "RowCount":
                        metadata.RowCount = int.Parse(value);
                        break;
                }
            }
        }

        return metadata;
    }
}