using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.hét.Entities
{
    public class IToyFactory : Abstractions.IToyFactory
    {
    public Abstractions.Toy CreateNew()
    {
        return new Ball();
    }
}
}
