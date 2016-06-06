using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Review : ResourceBase
    {
        public string Content { get; set; }
        public int Note { get; set; }
        public Movie Movie { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
