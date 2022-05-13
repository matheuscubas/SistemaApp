namespace SistemaApp.Core.Services.CsvReader
{
    public interface ICsvReader<T>
        where T : class
    {
        public IEnumerable<T> ReadCsv(string filePath);
    }
}
