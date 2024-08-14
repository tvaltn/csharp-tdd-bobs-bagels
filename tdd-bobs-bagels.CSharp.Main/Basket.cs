using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();
        public bool add(string name, int price)
        {
            if (_items.ContainsKey(name)) return false;
            _items.Add(name, price);
            return true;
        }

        public bool remove(string name)
        {
            throw new NotImplementedException();
        }
    }
}
