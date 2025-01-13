using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Iterator
{
    public class ShoppingList
    {
        private List<string> _list = [];

        public void Push(string itemName){
            _list.Add(itemName);
        }
        public string Pop(){
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList(){
            return _list;
        }
    }
}