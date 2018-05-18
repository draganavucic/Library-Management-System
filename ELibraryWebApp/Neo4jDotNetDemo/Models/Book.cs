using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELibraryWebApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public int Available { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }

    }
}