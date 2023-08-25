using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projectEf.Models
{
    public class Categories
    {
       
        public Guid categoryID { get; set; }

        public string name { get; set;}

        public string description { get; set;}
        public virtual ICollection<Taskes> tasks { get; set; }
    }
}