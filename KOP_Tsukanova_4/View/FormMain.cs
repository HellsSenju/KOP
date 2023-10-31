using ComponentsLibraryNet60.Models;
using Contracts.Book;
using Contracts.Ganre;
using DatabaseImplement;
using Unity;
using WinFormsLibrary1;
//using WinFormsLibrary1;

namespace View
{
    public partial class FormMain : Form
    {
        private readonly IBookLogic _bookLogic;
        private readonly IGanreLogic _ganreLogic;
        public FormMain(IBookLogic boolLogic, IGanreLogic ganreLogic)
        {
            InitializeComponent();
            _bookLogic = boolLogic;
            _ganreLogic = ganreLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            customTree.SetConfig(new List<string>() { "Ganre", "PriceToString", "Id", "Title" });

            try
            {
                customTree.Clear();
                var list = _bookLogic.Read(null);
                if (list != null)
                    foreach (var item in list)
                        customTree.CreateTree(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormBook>();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormBook>();
            form.Id = Convert.ToInt32(customTree.GetSelectedNode<Book>().Id);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(customTree.GetSelectedNode<Book>().Id);
                try
                {
                    _bookLogic.Delete(new BookBindingModel { Id = id });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.A:
                    добавитьToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.U:
                    изменитьToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.D:
                    удалитьToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.S:
                    CreateExcel(sender, e);
                    break;
                case Keys.T:
                    CreateWord(sender, e);
                    break;
                case Keys.C:
                    CreatePdf(sender, e);
                    break;
            }
        }

        private void CreateExcel(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }

            List<string> data = new();
            var books = _bookLogic.Read(null);
            if (books != null)
                foreach (var book in books)
                    if (book.Price == null)
                        data.Add(string.Concat("Название:", book.Title, ",    Описание:", book.Description));

            try
            {
                excelDocument.CreateExcel(fileName, "документ в Excel по бесплатным книгам (в каждой строке текст с информацией: название книги и ее описание).", data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void CreateWord(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

            var booksDB = _bookLogic.Read(null);
            try
            {
                componentDocumentWithTableMultiHeaderWord.CreateDoc(new ComponentDocumentWithTableHeaderDataConfig<BookViewModel>
                {
                    FilePath = fileName,
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreatePdf(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

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

            try
            {
                var chartPdf = new DiagramToPDF();
                chartPdf.GenPdf(
                    new ChartPdfInfo
                    {
                        FileName = fileName,
                        Title = "DiagramToPDF",
                        ChartTitle = "Diagram",
                        LegendPosition = LegendPosition.Bottom,
                        Data = data
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormGanre>();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }
}
