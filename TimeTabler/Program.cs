using System;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        ExcelPackage.License.SetNonCommercialPersonal("Jeong JIHO");
        string filePath = "종합강의시간표내역.xlsx";

        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            var worksheet = package.Workbook.Worksheets[0];

            for (int row = 1; row <= worksheet.Dimension.Rows; row++)
            {
                string col1 = worksheet.Cells[row, 1].Text;
                string col2 = worksheet.Cells[row, 2].Text;
                Console.WriteLine($"{col1}, {col2}");
            }
        }
    }
}