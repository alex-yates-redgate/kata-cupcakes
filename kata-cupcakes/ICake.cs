using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_cupcakes
{
    public interface ICake
    {
        string Name { get; }
        double Price { get; }
        bool IsBase { get; }
    }
}
