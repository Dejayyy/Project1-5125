using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public interface IAggregate<out HeavyObject>
    {
        IIterator<HeavyObject> CreateIterator();
    }
}
