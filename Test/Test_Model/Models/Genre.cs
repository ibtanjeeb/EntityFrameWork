using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
    [Table("tbl_Genre")]
   public class Genre
    {
        public int GenreId { get; set; }

        [Column("Name")]
        public string GenreName { get; set; }
        [Column(Order =1)]
        public int DisplayOrder { get; set; }


    }
}
