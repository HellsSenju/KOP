﻿using System.ComponentModel.DataAnnotations;

namespace CustomComponents_Lab1
{
    public class TableData
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Ganre { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}
