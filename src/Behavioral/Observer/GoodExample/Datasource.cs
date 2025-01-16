using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Observer.GoodExample
{
    public class Datasource : Subject
    {
        private List<int> _values = new List<int>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;
            NotifyObservers();
        }

    }
}