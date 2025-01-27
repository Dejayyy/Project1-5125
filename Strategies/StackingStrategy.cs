using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public interface StackingStrategy
    {
        float EvaluateStack(Aggregates.HeavyObjectList list);
    }
}
