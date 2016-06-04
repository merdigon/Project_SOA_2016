using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1.Models
{
    public class Actor
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }
        public string RealName { get; set; }
        public string MaritalStatus { get; set; }
        public int Height { get; set; }
        public string PlaceOfBirth { get; set; }
        public string DateOfBirth { get; set; }
        public bool Alive { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
    }
}
