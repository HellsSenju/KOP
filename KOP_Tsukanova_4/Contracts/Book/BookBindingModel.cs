﻿namespace Contracts.Book
{
    public class BookBindingModel
    {
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Ganre { get; set; } = string.Empty;
        public int? Price { get; set; }
    }
}