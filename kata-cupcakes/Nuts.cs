using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_cupcakes
{
    public class Nuts : ICake
    {
        private const string _itemName = "nuts";
        private const double _itemPrice = 0.2;
        private readonly ICake _decoratedCake;
        private readonly string _joinWord;
        public string Name => $"{_decoratedCake.Name} {_joinWord} {_itemName}";

        public double Price => _decoratedCake.Price + _itemPrice;
        public bool IsBase => false;

        public Nuts(ICake cake) {
            _decoratedCake = cake;
            _joinWord = _decoratedCake.IsBase ? "with" : "and";
        }
    }
}
