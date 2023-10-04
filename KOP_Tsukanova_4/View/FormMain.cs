using Contracts.Book;
using OfficeOpenXml.LoadFunctions.Params;

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
            try
            {
                var list = _boolLogic.Read(null);
                if (list != null)
                {
                    foreach (var item in list)
                    {
                        customTree.CreateTree(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
