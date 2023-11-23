using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_cupcakes
{
    public class Cupcake : ICake
    {
        private const string _name = "A cupcake";
        private const double _price = 1.0;

        public string Name => _name;

        public double Price => _price;

        public bool IsBase => true;
    }
}
