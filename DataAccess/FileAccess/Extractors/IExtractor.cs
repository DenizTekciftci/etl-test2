namespace DataAccess.FileAccess.Extractors;

public interface IExtractor<T>
{
    public List<T> Extract<T2>(Func<T2, List<T>>? getRecords = null);
}