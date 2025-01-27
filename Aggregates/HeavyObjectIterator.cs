using System;

namespace Assi1.Aggregates
{
    public class HeavyObjectIterator : IIterator<HeavyObject>
    {
        //Private members
        private protected HeavyObjectList _aggregate;
        private int _current;

        //Constructor
        public HeavyObjectIterator(HeavyObjectList aggregate)
        {
            _aggregate = aggregate;
            _current = 0;
        }

        //Gets first item in the list
        public HeavyObject First()
        {
            _current = 0;
            return _aggregate.At(_current);
        }

        //Goes to the next item
        public void Next()
        {
            if (!IsDone()) _current++;
        }

        //Returns true if done
        public bool IsDone()
        {
            return _current >= _aggregate.Length();
        }

        //Gets the current item
        public HeavyObject CurrentItem()
        {
            return _aggregate.At(_current);
        }
    }
}
