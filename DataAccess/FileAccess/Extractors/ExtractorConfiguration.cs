using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using CsvHelper;

namespace DataAccess.FileAccess.Extractors;

public class ExtractorConfiguration
{
    public CultureInfo CultureInfo { get; set; } = CultureInfo.InvariantCulture;
    public string Delimiter { get; set; } = ",";
    public Encoding Encoding { get; set; } = Encoding.UTF8;
    public bool HasHeaderRecord { get; set; } = true;
    public ShouldSkipRecord ShouldSkip = args => false;
}