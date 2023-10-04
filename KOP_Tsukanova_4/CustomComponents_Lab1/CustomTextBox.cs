using System.Text.RegularExpressions;

namespace CustomComponents_Lab1
{
    public partial class CustomTextBox : UserControl
    {
        private string _template = string.Empty;
        public string _tip = string.Empty;
        public string error { get; private set; }

        public CustomTextBox()
        {
            InitializeComponent();
        }

        public string template
        {
            get { return _template; }
            set { _template = value; }
        }

        private bool Check(string number)
        {
            return Regex.IsMatch(number, template);
        }

        public string TextBoxValue
        {
            get
            {
                if (template == string.Empty)
                {
                    error = "Шаблон не задан";
                    return null;
                }

                if (Check(textBox.Text))
                    return textBox.Text;
                else {
                    error = "Введенное значение не соотвествует шаблону";
                    return null;
                }
            }
            set
            {
                if (Check(textBox.Text))
                    textBox.Text = value;
            }
        }

        public void SetTip(string str)
        {
            toolTip.SetToolTip(textBox, str);
        }

        private EventHandler eventHandler;
        public event EventHandler SpecEvent
        {
            add { eventHandler += value; }
            remove { eventHandler += value; }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}
