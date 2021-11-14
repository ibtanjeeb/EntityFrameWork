using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models.FluentAPI
{
    public class Fluent_Book
    {
        
        public int Book_Id { get; set; }

        
        public string Title { get; set; }

        


        public string ISBN  { get; set; }
        
        public double Price { get; set; }
        
        public string PriceRange { get; set; }

        
        public int BookDetail_id { get; set; }
        public Fluent_BookDetails Fluent_BookDetail { get; set; }

        public int Publisher_Id { get; set; }
        public Fluent_Publisher Fluent_Publisher { get; set; }

        public ICollection<Fluent_BookinAuthor> Fluent_BookinAuthors { get; set; }
    }

}

