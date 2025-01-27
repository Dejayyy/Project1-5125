using System.Collections.Generic;

namespace Assi1.Aggregates
{
    public class HeavyObjectList : IAggregate<HeavyObject>
    {
        private List<HeavyObject> _list = new List<HeavyObject>();

        public IIterator<HeavyObject> CreateIterator()
        {
            return new HeavyObjectIterator(this);
        }

        public void Add(HeavyObject heavyObject)
        {
            _list.Add(heavyObject);
        }

        public void Print()
        {
            foreach (HeavyObject heavyObject in _list)
            {
                heavyObject.Print();
            }
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