using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.ComponentModel;

namespace CustomComponents_Lab1
{
    public partial class ExcelDiagram : Component
    {
        public ExcelDiagram()
        {
            InitializeComponent();
        }

        public ExcelDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateExcel(string path, string header, string title, LegendPosition position, List<Data> values)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Файл не задан");

            if (string.IsNullOrEmpty(header))
                throw new ArgumentException("Название документа не задано");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Название диаграммы не задано");

            if (values == null || values.Count == 0)
                throw new ArgumentException("Значения серий не заданы");

            CheckData(values);

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using var package = new ExcelPackage();
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("sheeet");
            worksheet.Cells[1, 1].Value = header;

            //создание диаграммы
            var lineChart = worksheet.Drawings.AddLineChart(title, eLineChartType.Line);
            int maxCol = GetMax(values); 

            lineChart.SetPosition(1, 0, 0, 0);
            lineChart.SetSize(100 * maxCol, 500);
            lineChart.Title.Text = title;
            lineChart.Legend.Add();
            switch (position)
            {
                case LegendPosition.Left:
                    lineChart.Legend.Position = eLegendPosition.Left;
                    break;

                case LegendPosition.Right:
                    lineChart.Legend.Position = eLegendPosition.Right;
                    break;

                case LegendPosition.Bottom:
                    lineChart.Legend.Position = eLegendPosition.Bottom;
                    break;

                case LegendPosition.Top:
                    lineChart.Legend.Position = eLegendPosition.Top;
                    break;

                case LegendPosition.TopRight:
                    lineChart.Legend.Position = eLegendPosition.TopRight;
                    break;
            }

            //добаление данных, на основе которых будет строиться диаграмма
            int leftTopI = 2, leftTopJ = 1;
            for (int i = 0; i < values.Count; i++)
            {
                Data data = values[i];
                for (int j = 0; j < data.Values.Count; j++)
                    worksheet.Cells[leftTopI + i, leftTopJ + j].Value = data.Values[j];

                var serie = lineChart.Series.Add(worksheet.Cells[leftTopI + i, leftTopJ, leftTopI + i, leftTopJ + maxCol - 1]);
                serie.Header = data.Name;
            }

            package.SaveAs(new FileInfo(path));
        }

        //проверка на наличие данных для секции
        private void CheckData(List<Data> values)
        {
            foreach (Data data in values)
            {
                if (data.Values is null || data.Values.Count == 0 )
                    throw new ArgumentException($"Данные серии ({data.Name}) не заполнены");
            }
        }

        //получение значения макс кол ва данных в секциях
        private int GetMax(List<Data> values)
        {
            int max = 0;
            foreach (Data data in values) 
            { 
                if(data.Values.Count > max)
                    max = data.Values.Count;
            }
            return max;
        }
    }
}
