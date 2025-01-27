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

        //Adds the heavy objects to the list
        public void Add(HeavyObject heavyObject)
        {
            _list.Add(heavyObject);
        }

        //Prints the heavy object list
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

        //Prints the count of the list
        public int Length()
        {
            return _list.Count;
        }
    }
}