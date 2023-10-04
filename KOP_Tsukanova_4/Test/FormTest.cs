using CustomComponents;
using CustomComponents_Lab1;

namespace Test
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            customTextBox.template = @"\d{2}.\d{2}.\d{4}";
            customTextBox.SetTip("dd.mm.yyyy");

            try
            {
                customListBox.SetLayoutString("Сотрудник {Name}, табельный номер {Number}", '{', '}');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            customListBox.AddElement(new Worker { 
                Name = "Иван Иванов", Number = 1243 });
            customListBox.AddElement(new Worker { 
                Name = "Петр Петров", Number = 2344 });

            customComboBox.SpecEvent += CustomEventHandler;
            customTextBox.SpecEvent += CustomEventHandler;
        }

        private void CustomEventHandler(object sender, EventArgs e)
        {
            //MessageBox.Show("Поймали");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            customComboBox.AddItem(textBox.Text);
            textBox.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            customComboBox.ClearList();
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            try
            {
                label.Text = customTextBox.TextBoxValue.ToString();
                customTextBox.ResetText();
            }
            catch (TemplateException ex)
            {
                MessageBox.Show(ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                Worker w = customListBox.GetSelectedItem<Worker>();
                labelSelected.Text = ($" {w.Name} {w.Number}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonDoc_Click(object sender, EventArgs e)
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

            List<string> data = new List<string> { "Не визуальный компонент для создания документа с большим текстом.",
            "У компонента должен быть публичный метод, которыйдолжен принимать на вход имя файла (включая путь до файла)",
            "название документа (заголовок в документе) и массив строк(каждая строка – абзац текста в выходном документе или текст в ячейке для табличного документа)"};
            try
            {
                excelDocument.CreateExcel(fileName, "TITLE", data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void buttonTable_Click(object sender, EventArgs e)
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

            try
            {
                excelTable.CreateExcel(fileName, "TITLE", new List<MergeCells>()
                {
                    new MergeCells{ Header = "Личные данные", Start = 2, Stop = 3},
                    new MergeCells{ Header = "Работа", Start = 5, Stop = 6}

                },
                new List<InfoHeaders> {
                    new InfoHeaders{ Name = "Id", Reference = "Id", Width = 5 },
                    new InfoHeaders{Name = "имя", Reference = "Name", Width = 10},
                    new InfoHeaders{Name = "фам", Reference = "Surname", Width = 10},
                    new InfoHeaders{Name = "плей", Reference = "Playstation", Width = 10},
                    new InfoHeaders{Name = "пост", Reference = "Post", Width = 10},
                    new InfoHeaders{Name = "експа", Reference = "Experience", Width = 10}
                },
                new List<TableData>
                {
                    new TableData{ Id = 1, Name ="qwe", Surname = "asdsad", Playstation = "qweqweqwe", Post = "posdasdas", Experience = 23},
                    new TableData{ Id = 2, Name ="qasdwe", Surname = "afdsdsad", Playstation = "qweqweqfdsdfwe", Post = "pdfsfsdosdasdas", Experience = 12},
                    new TableData{ Id = 3, Name ="qwefffddf", Surname = "afdssdsad", Playstation = "ddfqweqweqwe", Post = "posdasdffdsdfsdas", Experience = 4},
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

        private void buttonDiagram_Click(object sender, EventArgs e)
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

            try
            {
                excelDiagram.CreateExcel(fileName, "XLSX WITH DIAGRAM", "MEGA DATA", LegendPosition.Right, new()
                {
                new Data { Name = "Section 1", Values = new List<int> { 1, 3, 6, 9, 12 } },
                new Data { Name = "Section 2", Values = new List<int> { 14, 12, 10, 8 } },
                new Data { Name = "Section 3", Values = new List<int> { 0, 10, 2, 15, 3} },
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
    }
}