using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class SoaResourceModel
    {
        public string ShowableName { get; set; }

        public Type DataBindedType { get; set; }

        public override string ToString()
        {
            return ShowableName;
        }
    }
}
