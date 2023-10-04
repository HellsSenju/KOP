using Contracts.Book;
using DatabaseImplement;
using Unity;

namespace View
{
    public partial class FormMain : Form
    {
        private readonly IBookLogic _boolLogic;
        public FormMain(IBookLogic boolLogic)
        {
            InitializeComponent();
            _boolLogic = boolLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<string> conf = new()
            {
                "Ganre", "Price", "Id", "Title"
            };
            customTree.SetConfig(conf);

            try
            {
                var list = _boolLogic.Read(null);
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
                    _boolLogic.Delete(new BookBindingModel { Id = id });
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
                    /*                case Keys.S:
                                        CreateWordReadersTable();
                                        break;
                                    case Keys.T:
                                        CreatePdfBooks();
                                        break;
                                    case Keys.C:
                                        CreateExcelShapes();
                                        break;*/
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
