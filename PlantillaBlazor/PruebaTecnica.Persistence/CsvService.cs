using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace PruebaTecnica.Persistence
{
    public class CSVService
    {
        public bool listToCsv<T>(IEnumerable<T> usuarios, string ruta_final, string delimiter)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = delimiter,
                Encoding = Encoding.UTF8,
            };

            using (var writer = new StreamWriter(ruta_final))
            using (var csv = new CsvWriter(writer, configuration))
            {
                csv.WriteRecords(usuarios);
            }

            return File.Exists(ruta_final);
        }

        public IEnumerable<T> csvToList<T>(string file_path, string delimiter)
        {
            List<T> registros = new List<T>();


            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = delimiter
            };
            using (var reader = new StreamReader(file_path))
            using (var csv = new CsvReader(reader, configuration))
            {
                var records = csv.GetRecords<T>();
                foreach (var record in records)
                {
                    registros.Add(record);
                }

                return registros;
            }
        }
    }
}
