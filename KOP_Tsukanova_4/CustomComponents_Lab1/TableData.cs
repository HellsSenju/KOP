namespace CustomComponents_Lab1
{
    public class TableData
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Playstation { get; set; } = string.Empty;
        public string Post { get; set; } = string.Empty;    
        public int Experience { get; set; }

/*        public bool Check(List<string> headers)
        {
            foreach (var header in headers)
            {
                foreach (var p in typeof(TableData).GetProperties())
                {
                    if (p.Name.Equals(header))
                    {
                        if( p.GetValue(this).ToString() )
                    }
                }
            }
            if(string.IsNullOrEmpty(Name))          return false;
            if (string.IsNullOrEmpty(Surname))      return false;
            if (string.IsNullOrEmpty(Playstation))  return false;
            if (string.IsNullOrEmpty(Post))         return false;
            return true;
        }*/
    }
}
