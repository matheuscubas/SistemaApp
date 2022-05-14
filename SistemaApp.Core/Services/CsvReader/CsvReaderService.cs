using CsvHelper.Configuration;
using System.Globalization;

namespace SistemaApp.Core.Services.CsvReader
{
    using CsvReader = CsvHelper.CsvReader;
    public class CsvReaderService<T> : ICsvReader<T>
        where T : class
    {
        public IEnumerable<T> ReadCsv(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, config);
            var record = csv.GetRecords<T>();
            return record;
        }
    }
}
