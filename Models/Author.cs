using System;
using System.ComponentModel.DataAnnotations;

namespace BookstoreClient.Models
{
    public class Author
    { 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        List<Book> books { get; set; }

    }
}
