using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_DD_Hybrid_Driven_Framework.TestDataAccess
{
    public class ExcelOperations
    {
        public static DataTable ExcelToDataTable(string FileName)
        {
            //Opeing File
            FileStream stream = File.Open(FileName, FileMode.Open, FileAccess.Read);

            //Encoding Data
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //Configuring Properties ton  read Excel File
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) =>new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            //Get all the tables
            DataTableCollection table = result.Tables;


            //Store it in Datatable
            DataTable resultTable = table["DataSet"];

            return resultTable;
        }

        static List<DataCollection> datacol = new  List<DataCollection>();

        public static void PopulateInCollection(string Filename)
        {
            DataTable table = ExcelToDataTable(Filename);

            for (int row = 1; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    datacol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber,string columName)
        {
            try
            {
                string data = (from colData in datacol
                               where colData.colName == columName
                               && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();
                return data.ToString();

            }
            catch (Exception e)
            {

                return null;
            }
        }
    }
}
