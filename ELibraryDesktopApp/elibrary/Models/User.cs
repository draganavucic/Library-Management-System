using System;

namespace ELibrary.Models
{
    public class User
    {
        public string JMBG { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string RentedBook { get; set; }
        public string Email { get; set; }

    }
}