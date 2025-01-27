using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectAggregate<HeavyObject> : IAggregate<HeavyObject>
    {
        protected List<HeavyObject> _list = new List<HeavyObject>();
        public IIterator<HeavyObject> CreateIterator()
        {
            throw new NotImplementedException();
        }

        public void Add(HeavyObject heavyObject)
        {
            _list.Add(heavyObject);
        }

        public HeavyObject At(int position)
        {
            return _list[position];
        }

        public int Length()
        {
            return _list.Count;
        }

    }

}
