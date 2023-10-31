using PluginsConvention.Plugins;
using WinFormsLibrary1;
using Contracts.Book;
using Contracts.Ganre;
using BusinessLogic;
using CustomComponents_Lab1;
using ComponentsLibraryNet60.DocumentWithTable;
using ComponentsLibraryNet60.Models;
using System.ComponentModel.Composition;

namespace PluginsConvention
{
    [Export(typeof(IPluginsConvention))]
    public class PluginConvention : IPluginsConvention
    {
        private readonly MyTree _tree;
        private readonly IBookLogic _bookLogic;
        private readonly IGanreLogic _ganreLogic;

        public PluginConvention()
        {
            _bookLogic = new BookLogic();
            _ganreLogic = new GanreLogic();
            _tree = new MyTree();

            var menu = new ContextMenuStrip();
            var ganreMenuItem = new ToolStripMenuItem("Жанры");
            menu.Items.Add(ganreMenuItem);
            ganreMenuItem.Click += (sender, e) =>
            {
                var formGanre = new FormGanre(_ganreLogic);
                formGanre.ShowDialog();
            };

            _tree.ContextMenuStrip = menu;
            ReloadData();
        }

        string IPluginsConvention.PluginName => PluginName();
        public string PluginName()
        {
            return "TsukanovaPlugin";
        }

        public UserControl GetControl => _tree;

        PluginsConventionElement IPluginsConvention.GetElement => GetElement();

        public PluginsConventionElement GetElement()
        {
            var book = _tree.GetSelectedNode<ConventionElement>();
            ConventionElement element = null;
            if (_tree != null)
            {
                element = new ConventionElement
                {
                    Id = book.Id,
                    Title = book.Title,
                    Ganre = book.Ganre,
                    Description = book.Description,
                    Price = book.Price,
                    PriceToString = book.PriceToString
                };
            }
            return new PluginsConventionElement { Id = element.Id };
        }

        public Form GetForm(PluginsConventionElement element)
        {
            var formBook = new FormBook(_bookLogic, _ganreLogic);
            if (element != null)
                formBook.Id = element.Id;

            return formBook;
        }

        public bool DeleteElement(PluginsConventionElement element)
        {
            try
            {
                _bookLogic.Delete(new BookBindingModel { Id = element.Id });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ReloadData()
        {
            _tree.Clear();
            List<string> conf = new()
            {
                "Ganre", "PriceToString", "Id", "Title"
            };

            _tree.SetConfig(conf);
            var list = _bookLogic.Read(null);

            if (list != null)
                foreach (var book in list)
                    _tree.CreateTree(book);
        }

        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {
            try
            {
                ExcelDocument excelDocument = new();
                List<string> data = new();
                var books = _bookLogic.Read(null);
                if (books != null)
                    foreach (var book in books)
                        if (book.Price == null)
                            data.Add(string.Concat("Название:", book.Title, ",    Описание:", book.Description));

                excelDocument.CreateExcel(saveDocument.FileName, "документ в Excel по бесплатным книгам (в каждой строке текст с информацией: название книги и ее описание).", data);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            try
            {
                ComponentDocumentWithTableMultiHeaderWord table = new();

                var booksDB = _bookLogic.Read(null);

                table.CreateDoc(new ComponentDocumentWithTableHeaderDataConfig<BookViewModel>
                {
                    FilePath = saveDocument.FileName,
                    Header = "Книги",
                    ColumnsRowsWidth = new List<(int, int)> { (5, 5), (10, 5), (10, 0), (5, 0), (7, 0) },
                    Headers = new List<(int ColumnIndex, int RowIndex, string Header, string PropertyName)>
                    {
                        (0, 0, "Идентификатор", "Id"),
                        (1, 0, "Название", "Title"),
                        (2, 0, "Описание", "Description"),
                        (3, 0, "Жанр", "Ganre"),
                        (4, 0, "Стоимость", "PriceToString")
                    },
                    Data = booksDB
                });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool CreateChartDocument(PluginsConventionSaveDocument saveDocument)
        {
            try
            {
                var data = new List<ChartData>();
                var books = _bookLogic.Read(null);
                var genries = _ganreLogic.Read(null);
                foreach (var genre in genries)
                {
                    int count = 0;
                    foreach (var book in books)
                    {
                        if (book.Price == null && book.Ganre.Equals(genre.Name))
                            count++;

                    }
                    data.Add(new ChartData { SeriesName = genre.Name, Value = count });
                }

                var chartPdf = new DiagramToPDF();
                chartPdf.GenPdf(
                    new ChartPdfInfo
                    {
                        FileName = saveDocument.FileName,
                        Title = "DiagramToPDF",
                        ChartTitle = "Diagram",
                        LegendPosition = WinFormsLibrary1.LegendPosition.Bottom,
                        Data = data
                    });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
