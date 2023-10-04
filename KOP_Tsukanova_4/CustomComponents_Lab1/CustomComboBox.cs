
namespace CustomComponents_Lab1
{
    public partial class CustomComboBox : UserControl
    {
        public event EventHandler eventHandler;
        public CustomComboBox()
        {
            InitializeComponent();
        }

        public void AddItem(string item)
        {
            comboBox.Items.Add(item);
        }

        public void ClearList()
        {
            comboBox.Items.Clear();
            comboBox.Text = "";
        }

        public string SelectElement
        {
            get
            {
                if (comboBox.SelectedItem == null)
                {
                    return string.Empty;
                }
                return comboBox.SelectedItem.ToString();
            }
            set
            {
                if(comboBox.Items.Contains(value))
                    comboBox.SelectedItem = value;
            }
        }

        public event EventHandler SpecEvent
        {
            add { eventHandler += value; }
            remove { eventHandler += value; }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}
