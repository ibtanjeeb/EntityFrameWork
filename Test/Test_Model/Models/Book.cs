using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
  public  class Book
    {
        [Key]
        public int Book_Id { get; set; }

        [Required]
        [MinLength(10)] [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(30)] 


        public string ISBN  { get; set; }
        [Required]
        public double Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }

        public Category Category { get; set; }
        [ForeignKey("BookDetails")]
        public int BookDetail_id { get; set; }
       public BookDetails BookDetails { get; set; }
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookinAuthor> BookinAuthors { get; set; }
    }
}
