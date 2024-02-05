using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEYZAGENÇAY
{

        class DatabaseResult
        {
            public List<string> columns { get; set; }
            public List<List<object>> data { get; set; }

            public DatabaseResult(List<string> columns, List<List<object>> data)
            {
                this.columns = columns;
                this.data = data;
            }
        }

        class TableResult : DatabaseResult
        {
            public Dictionary<string, Type> ColumnTypes { get; private set; }

            public TableResult(List<string> columns, List<List<object>> data) : base(columns, data)
            {
                ColumnTypes = DetectColumnTypes();
            }

            private Dictionary<string, Type> DetectColumnTypes()
            {
                var columnTypes = new Dictionary<string, Type>();
                for (int colIndex = 0; colIndex < columns.Count; colIndex++)
                {
                    var types = new HashSet<Type>();
                    foreach (var row in data)
                    {
                        if (colIndex < row.Count)
                            types.Add(row[colIndex]?.GetType());
                    }

                    if (types.Count == 1)
                        columnTypes[columns[colIndex]] = types.Single();
                    else
                        columnTypes[columns[colIndex]] = null;
                }
                return columnTypes;
            }
        }

        class Table
        {
            public string Name { get; private set; }
            public List<List<object>> Data { get; set; }

            public Table(string name, List<List<object>> data)
            {
                Name = name;
                Data = data;
            }

            public object this[int row, int col]
            {
                get { return Data[row][col]; }
                set { Data[row][col] = value; }
            }
        }

        class Program
        {
            static void Main()
            {

                var tableData = new List<List<object>>
        {
                new List<object> {1, "FEYZA HANİM ", DateTime.Parse("2022-01-01"), 25.5},
                new List<object> {2, "GÖKÇE ALTUN ", DateTime.Parse("2022-07-15"), 30},
                new List<object> {3, "MUHAMET ŞAHİN OZCU ", DateTime.Parse("2022-12-20"), "Active"},
                new List<object> {4, "DT. EMRE", DateTime.Parse("2022-01-09"), 25.5},
                new List<object> {5, "İREN ALINCI", DateTime.Parse("2022-02-14"), 30},
                new List<object> {6, " OĞUZ ATAY", DateTime.Parse("2022-03-01"), "Active"},
                new List<object> {7, " SERPİL ÇETİNKAYA", DateTime.Parse("2022-05-01"), 25.5},
                new List<object> {8, "RAHMAN İSMET", DateTime.Parse("2022-02-10"), 30},
                new List<object> {9, "ERDOĞAN DOĞAN ", DateTime.Parse("2022-04-20"), "Active"},
                new List<object> {10, " SUNALI İRFAN", DateTime.Parse("2022-01-01"), 25.5},
                new List<object> {11, " FATİH MEHMET DİKİCİ", DateTime.Parse("2022-02-17"), 30},
                new List<object> {12, "ASLI CETİN ", DateTime.Parse("2022-02-25"), "Active"},

        };

                // Sütun isimleri
                var tableColumns = new List<string> { "ID", "Name", "Birthdate", "Status" };

                // TableResult nesnesi oluşturma
                var result = new TableResult(tableColumns, tableData);

                // sorgulama
                var selectQuery1 = result.data.GetRange(0, Math.Min(12, result.data.Count)); // Select Sutun1, Sutun2, Sutun3 from Table
                var selectQuery2 = result.data; // Select * From Table

                // Sonuçları  yazdırma
                Console.WriteLine("Select Sutun1, Sutun2, Sutun3 from Table:");
                foreach (var row in selectQuery1)
                {
                    Console.WriteLine(string.Join(", ", row));
                }

                Console.WriteLine("\nSelect * From Table:");
                foreach (var row in selectQuery2)
                {
                    Console.WriteLine(string.Join(", ", row));
                }

                // Sütun tiplerini ekrana yazdırma
                Console.WriteLine("\nSütun Tipleri:");
                foreach (var kvp in result.ColumnTypes)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }

                // Tarih yazdırma
                var birthdateIndex = tableColumns.IndexOf("Birthdate");
                Console.WriteLine("\nDoğum Tarihi (Tarih Formatında):");
                foreach (var row in result.data)
                {
                    Console.WriteLine(((DateTime)row[birthdateIndex]).ToString("yyyy-MM-dd"));
                }

                Console.ReadLine();
            }
        }

}

