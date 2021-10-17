using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_1
{
    public class StringSet : IEnumerable<string>
    {

        private IList<string> _items;

        public StringSet()
        {
            _items = new List<string>();
        }

        public void Add(string item)
        {
            _items.Add(item);
        }

        public bool Contains(string item)
        {
            return _items.Contains(item);
        }

        public void Remove(string item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public int CountItems()
        {
            return _items.Count;
        }

        public StringSet Union(StringSet setB)
        {
            StringSet combined = new StringSet();
            foreach (string item in _items)
            {
                combined.Add(item);
            }
            foreach (string item in setB)
            {
                combined.Add(item);
            }
            return combined;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_items).GetEnumerator();
        }
    }
}
