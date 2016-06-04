using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Movie : ResourceBase
    {
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DisplayName("Rok produkcji")]
        public int ProductionYear { get; set; }
    }
}
