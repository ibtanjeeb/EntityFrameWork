using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models.FluentAPI
{
    public class Fluent_BookinAuthor
    {
        
        public int Book_Id { get; set; }

        public Fluent_Book Fluent_Book { get; set; }

        public int AuthorId { get; set; }

        public Fluenr_Author Fluenr_Author { get; set; }


    }
}
