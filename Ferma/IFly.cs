using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{

    interface IFly : IMove
    {
        void Fly(); // default public and abstract
        ushort Height { get; set; }
    }
}
