using Contracts.Ganre;

namespace View
{
    public partial class FormGanre : Form
    {
        private readonly IGanreLogic ganreLogic;
        List<GanreBindingModel> _ganre;
        public FormGanre(IGanreLogic ganreLogic)
        {
            InitializeComponent();
            this.ganreLogic = ganreLogic;
            _ganre = new List<GanreBindingModel>();
        }

        private void FormGanre_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var ganres = ganreLogic.Read(null);
                _ganre.Clear();
                foreach (var item in ganres)
                {
                    _ganre.Add(new GanreBindingModel
                    {
                        Id = item.Id,
                        Name = item.Name,
                    });
                }
                if (_ganre != null)
                {
                    dataGridView.DataSource = _ganre;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                if (dataGridView.Rows.Count == 0)
                {
                    _ganre.Add(new GanreBindingModel());
                    dataGridView.DataSource = new List<GanreBindingModel>(_ganre);
                    dataGridView.CurrentCell = dataGridView.Rows[0].Cells[1];
                    return;
                }
                if (dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[1].Value != null)
                {
                    _ganre.Add(new GanreBindingModel());
                    dataGridView.DataSource = new List<GanreBindingModel>(_ganre);
                    dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[1];
                    return;
                }
            }
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Удалить выбранный элемент", "Удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ganreLogic.Delete(new GanreBindingModel() { Id = (int)dataGridView.CurrentRow.Cells[0].Value });
                    LoadData();
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var typeName = (string)dataGridView.CurrentRow.Cells[1].Value;
            if (!string.IsNullOrEmpty(typeName))
            {
                if (dataGridView.CurrentRow.Cells[0].Value != null)
                {
                    ganreLogic.CreateOrUpdate(new GanreBindingModel()
                    {
                        Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value),
                        Name = (string)dataGridView.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                else
                {
                    ganreLogic.CreateOrUpdate(new GanreBindingModel()
                    {
                        Name = (string)dataGridView.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
            }
            else
            {
                MessageBox.Show("Введена пустая строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
    }
}
