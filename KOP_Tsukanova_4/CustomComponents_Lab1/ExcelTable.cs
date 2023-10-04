using CustomComponents;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.ComponentModel;

namespace CustomComponents_Lab1
{
    public partial class ExcelTable : Component
    {
        public ExcelTable()
        {
            InitializeComponent();
        }

        public ExcelTable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateExcel(string path, string title, List<MergeCells> mergeCells,
            List<InfoHeaders> headers, List<TableData> values)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Не указан путь к файлу");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Не указан заголовок документа");

            if (mergeCells is null)
                throw new ArgumentException("Нет указаний для объединения ячеек");

            if (headers is null)
                throw new ArgumentException("Нет информации по заголовка");

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using var package = new ExcelPackage();
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("sheeet");

            //первый параметр цифры, второй буквы
            worksheet.Cells[1, 1].Value = title;

            int j = 0;
            int k = 0;
            for (int i = 0; i < headers.Count; i++)
            {
                var mergeCell = mergeCells[j];
                if (mergeCell.Start == i + 1)
                {
                    var range = worksheet.Cells[2, mergeCell.Start, 2, mergeCell.Stop];
                    for(int l = mergeCell.Start; l <= mergeCell.Stop; l++)
                    {
                        var r = worksheet.Cells[3, l];
                        r.Value = headers[k].Name;
                        worksheet.Column(l).Width = headers[k].Width;
                        k++;
                    }
                    j++;
                    i += mergeCell.Stop - mergeCell.Start;
                    range.Value = mergeCell.Header;
                    range.Merge = true;
                }
                else
                {
                    var range = worksheet.Cells[2, i + 1, 3, i + 1];
                    range.Value = headers[k].Name;
                    range.Merge = true;
                    worksheet.Column(i + 1).Width = headers[k].Width;
                    k++;
                }
            }

            j = 0;
            for(int i = 0; i < values.Count; i++)
            {
                var value = values[i];
                for (int l = 0; l < headers.Count; l++)
                {
                    if (headers[l].Reference.Equals("Id"))
                    {
                        var range = worksheet.Cells[i + 4, l + 1, i + 4, l + 1];
                        range.Value = value.Id;
                        continue;
                    }
                }
            }

            worksheet.Cells[2, 1, 3 + values.Count, headers.Count].Style.Border.BorderAround(ExcelBorderStyle.Medium);

            package.SaveAs(new FileInfo(path));
        }
    }
}
