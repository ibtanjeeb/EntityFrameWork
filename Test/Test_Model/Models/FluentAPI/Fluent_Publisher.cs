using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Model.Models.FluentAPI;

namespace Test_Model.Models.FluentAPI
{
    public class Fluent_Publisher
    {
        
        public int Publisher_Id { get; set; }
        
        public string Name { get; set; }
        
        public string Location { get; set; }

        public List<Fluent_Book> Fluent_Books{ get; set; }
    }
}
