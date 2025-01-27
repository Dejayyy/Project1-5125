using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectIterator : IIterator<HeavyObject>
    {
        protected HeavyObjectAggregate<HeavyObject> agg;
        protected int index;

        public HeavyObjectIterator(HeavyObjectAggregate<HeavyObject> aggregate)
        {
            this.agg = aggregate;
            index = 0;
        }
           

        public bool IsDone()
        {
            return index >= agg.Length();
        }

        public void Next()
        {
            ++index;
        }

        HeavyObject IIterator<HeavyObject>.CurrentItem()
        {
            return agg.At(index);
        }

        HeavyObject IIterator<HeavyObject>.First()
        {
            return agg.At(0);
        }
    }
}
