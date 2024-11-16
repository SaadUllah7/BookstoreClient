using System;
using System.ComponentModel.DataAnnotations;

namespace BookstoreClient.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }

}
