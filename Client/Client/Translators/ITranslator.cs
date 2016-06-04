using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Translators
{
    interface ITranslator<T,U> where T : ResourceBase, new() where U : new()
    {
        U Pack(T obj);

        T Unpack(U obj);
    }
}
