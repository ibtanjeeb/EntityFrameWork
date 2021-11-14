using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
    [Table("tbl_category")]
   public class Category
    {
        [Key]
        
        public int Categoru_Id { get; set; }
        [Required]
        [Column("Category_Name")]
        public string Name { get; set; }

    }
}
