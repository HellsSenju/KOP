﻿ using System.ComponentModel.DataAnnotations;

namespace DatabaseImplement
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Ganre { get; set; } = string.Empty; 
        public int? Price { get; set; }

        public string PriceString
        {
            set { }
            get
            {
                if (Price == 0 || Price == null) return "Бесплатная";
                else return Price.ToString();
            }
        }
    }
}
