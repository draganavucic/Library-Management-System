using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public int Available { get; set; } //broj slobodnih
        public string Genre { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
