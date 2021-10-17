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
    }
}
