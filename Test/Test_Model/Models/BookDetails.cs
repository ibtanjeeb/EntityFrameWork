using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
  public  class BookDetails
    {
        [Key]
        public int BookDetail_id { get; set; }

        public string NumberOfChapters { get; set; }
        public string NumberofPages { get; set; }
        public double Weight { get; set; }
        public Book Book { get; set; }


    }
}
