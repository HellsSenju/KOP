using Contracts.Book;
using Contracts.Ganre;

namespace View
{
    public partial class FormBook : Form
    {
        public int Id { set { id = value; } }

        private readonly IBookLogic _boolLogic;
        private readonly IGanreLogic _ganreLogic;

        private int? id;
        public FormBook(IBookLogic boolLogic, IGanreLogic ganreLogic)
        {
            InitializeComponent();
            _boolLogic = boolLogic;
            _ganreLogic = ganreLogic;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            List<GanreViewModel> list = _ganreLogic.Read(null);
            if (list != null)
            {
                foreach (GanreViewModel item in list)
                {
                    customComboBoxGanre.AddItem(item.Name);
                }
            }

            if (id.HasValue)
            {
                try
                {
                    BookViewModel view = _boolLogic.Read(new BookBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        textBoxTitle.Text = view.Title;
                        textBoxDescr.Text = view.Description;
                        customComboBoxGanre.SelectElement = view.Ganre;
                        controlInputNullableInt.Value = view.Price;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                MessageBox.Show("Заполните Название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDescr.Text))
            {
                MessageBox.Show("Заполните описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(customComboBoxGanre.SelectElement))
            {
                MessageBox.Show("Выберите жанр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                _boolLogic.CreateOrUpdate(new BookBindingModel
                {
                    Id = id,
                    Title = textBoxTitle.Text,
                    Description = textBoxDescr.Text,
                    Ganre = customComboBoxGanre.SelectElement,
                    Price = controlInputNullableInt.Value
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
