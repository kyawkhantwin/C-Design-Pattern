using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Iterator.GoodSolution
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();

        public void Push(string itemName)
        {
            _list.Add(itemName);
        }
        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }

        public IIterator<string> CreateIterator()
        {
            return new Iterator(this);
        }

        private class Iterator : IIterator<string>
        {
            private ShoppingList _shoppingList;
            private int _index;
            public Iterator(ShoppingList shoppingList)
            {
                _shoppingList = shoppingList;
            }
            public string Current()
            {
                return _shoppingList._list[_index];
            }

            public bool HasNext()
            {
                return _index < _shoppingList._list.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}