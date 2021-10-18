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

        public StringSet(IList<string> items)
        {
            _items = items;
        }

        public IList<string> Items
        {
            get => (List<string>)_items;
            private set => _items = value;
        }

        public void Add(string item)
        {
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
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
           var itemsUnion = Items.Union(setB.Items).ToList();
           StringSet setUnion = new StringSet(itemsUnion);
           return setUnion;
        }

        public StringSet Intersect(StringSet setB)
        {
            var itemsIntersection = Items.Intersect(setB.Items).ToList();
            StringSet setIntersection = new StringSet(itemsIntersection);
            return setIntersection;
        }

        public void Clear()
        {
            _items.Clear();
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
