namespace CustomComponents_Lab1
{
    public partial class CustomListBox : UserControl
    {
        public CustomListBox()
        {
            InitializeComponent();
        }

        List<string> names = new(); //лист с названиями свойств/полей

        private string layoutString = String.Empty;
        private char openSymbol;
        private char endSymbol;


        //Публичное свойство для установки и получения индекса выбранной строки
        public int index
        {
            get { return listBox.SelectedIndex; }
            set { listBox.SelectedIndex = value; }
        }

        //задается макетная строка и символы начала.конца
        public void SetLayoutString(string layoutString, char openSymbol, char endSymbol)
        {
            if (!layoutString.Contains(openSymbol) || !layoutString.Contains(endSymbol))
                throw new Exception("Макетная строка не содержит нужных символов");

            this.layoutString = layoutString;
            this.openSymbol = openSymbol;
            this.endSymbol = endSymbol;

            SetStringNames();
        }

        //получение названий свойств/полей
        private void SetStringNames()
        {
            char[] layoutStringChars = layoutString.ToCharArray();
            names = new List<string>();

            for (int i = 0; i < layoutStringChars.Length; i++)
            {
                if (layoutStringChars[i] == openSymbol)
                {
                    string name = string.Empty;
                    int j;
                    for (j = i + 1; layoutStringChars[j] != endSymbol; j++)
                    {
                        name += layoutStringChars[j];
                    }
                    i = j;
                    names.Add(name);
                }
            }
        }

        public void AddElement<T>(T obj)
        {
            string str = layoutString;
            foreach (var n in names)
            {
                foreach (var p in typeof(T).GetProperties())
                {
                    if (p.Name.Equals(n))
                    {
                        str = str.Replace(openSymbol + n + endSymbol, p.GetValue(obj).ToString());
                        break;
                    }
                }
            }

            listBox.Items.Add(str);
            listBox.Refresh();
        }

        public void ClearAll()
        {
            listBox.Items.Clear();
        }

        //метод для получения объекта из выбранной строки
        public T GetSelectedItem<T>() where T : class, new()
        {
            string SelectedStr = "";
            if (listBox.SelectedIndex != -1)
            {
                SelectedStr = listBox.SelectedItem.ToString();
            }

            T currentObject = new T();

            foreach (var prop in typeof(T).GetProperties())
            {
                if (!prop.CanWrite)
                {
                    continue;
                }
                int startS = SelectedStr.IndexOf(openSymbol);
                int endS = SelectedStr.IndexOf(endSymbol);
                if (startS == -1 || endS == -1)
                {
                    break;
                }
                string propValue = SelectedStr.Substring(startS + 1, endS - startS - 1);
                SelectedStr = SelectedStr.Substring(endS + 1);
                prop.SetValue(currentObject, Convert.ChangeType(propValue, prop.PropertyType));
            }
            return currentObject;
        }
    }
}
