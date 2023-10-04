using System.ComponentModel;
using OfficeOpenXml;


namespace CustomComponents_Lab1
{
    public partial class ExcelDocument : Component
    {
        public ExcelDocument()
        {
            InitializeComponent();
        }

        public ExcelDocument(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateExcel(string path, string title, List<string> text)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Не указан путь к файлу");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Не указан заголовок документа");

            if (text == null || text.Count == 0)
                throw new ArgumentException("Массив с текстом пуст либо null");

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using var package = new ExcelPackage();
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("sheeet");
            worksheet.Cells[1, 1].Value = title;

            for (int i = 0; i < text.Count; i++)
                worksheet.Cells[i + 3, 1].Value = text[i];

            package.SaveAs(new FileInfo(path));
        }
    }
}
