using System.Xml.Serialization;

namespace DataAccess.FileAccess.Extractors;

public class XmlExtractor<T>(string filePath) : IExtractor<T>
{
    private T2 ExtractRoot<T2>()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T2));
        using StreamReader reader = new StreamReader(filePath);
        var test = (T2?) serializer.Deserialize(reader);
        return test;
    }

    public List<T> Extract<T2>(Func<T2, List<T>>? getRecords = null)
    {
        var extracted = ExtractRoot<T2>();
        if (getRecords == null)
        {
            throw new ArgumentNullException(nameof(getRecords));
        }
        return getRecords(extracted);
    }
}