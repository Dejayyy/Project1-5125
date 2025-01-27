using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public interface IStackingStrategy
    {
        float EvaluateStack(Aggregates.HeavyObjectList list);
    }
}
