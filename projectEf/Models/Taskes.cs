using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace projectEf.Models
{
    public class Taskes
    {
        
        public Guid taskID { get; set; }
       
        //[ForeignKey("categoryID")]
        public Guid categoryID { get; set; }
        public string title { get; set;}
        public string description { get; set;}
        public Prioridad prioridadTask{ get; set; }
        public DateTime creationDate { get; set; }
        public virtual Categories category { get; set; }
        
        //[NotMapped]
        public string summary {get; set;}
    }
    public enum Prioridad{

    }
}