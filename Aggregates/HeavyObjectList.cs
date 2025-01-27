using System.Collections.Generic;

namespace Assi1.Aggregates
{
    //Heavy Obj
    public class HeavyObjectList : IAggregate<HeavyObject>
    {
        //List to hold HeavyObjects
        private List<HeavyObject> _list = new List<HeavyObject>();

        //Creates the Iterator
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

        //Gets HeavyObject AT given index
        public HeavyObject At(int position)
        {
            return _list[position];
        }

        //Returns the count of the list
        public int Length()
        {
            return _list.Count;
        }
    }
}