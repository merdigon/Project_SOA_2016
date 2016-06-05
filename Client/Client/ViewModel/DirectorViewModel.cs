using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class DirectorViewModel : ResourceBase
    {
        public DirectorViewModel(Director source)
        {
            this.Source = source;
        }

        public string Name { get { return Source.Name; } set { } }
        public string RealName { get { return Source.RealName; } set { } }
        public string DateOfBirth { get { return Source.DateOfBirth; } set { } }
        public bool Alive { get { return Source.Alive; } set { } }

        [Browsable(false)]
        public Director Source { get; set; }
    }
}
