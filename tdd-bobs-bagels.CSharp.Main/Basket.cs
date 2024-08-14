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
        int capacity = 2;
        public bool add(string name, int price)
        {
            if (_items.ContainsKey(name)) return false;
            _items.Add(name, price);
            return true;
        }

        public bool isFull()
        {
            return _items.Count >= capacity;
        }

        public bool remove(string name)
        {
            if (!_items.ContainsKey(name)) return false;
            _items.Remove(name);
            return true;
        }
    }
}
