using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_1
{
    public class StringSet
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
    }
}
