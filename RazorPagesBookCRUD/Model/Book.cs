using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//this class is used to store all the data of the database.
namespace RazorPagesBookCRUD.Model
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

    }
}



