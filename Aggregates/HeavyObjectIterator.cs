using System;

namespace Assi1.Aggregates
{
    public class HeavyObjectIterator : IIterator<HeavyObject>
    {
        private protected HeavyObjectList _aggregate;
        private int _current;

        //
        public HeavyObjectIterator(HeavyObjectList aggregate)
        {
            _aggregate = aggregate;
            _current = 0;
        }

        //
        public HeavyObject First()
        {
            _current = 0;
            return _aggregate.At(_current);
        }

        //If not done takes the current
        public void Next()
        {
            if (!IsDone()) _current++;
        }

        //Takes the current and returns true when done
        public bool IsDone()
        {
            return _current >= _aggregate.Length();
        }

        //
        public HeavyObject CurrentItem()
        {
            return _aggregate.At(_current);
        }
    }
}
