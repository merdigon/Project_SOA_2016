using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Content { get; set; }
        public int Note { get; set; }
        public int MovieID { get; set; }
        //public virtual User User { get; set; }
    }
}
