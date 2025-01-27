using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Strategies
{
    public class BottomWeightStrategy : IStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList stack)
        {
            float score = 0;

            for (int i = 0; i < stack.Length(); i++)
            {
                score += stack.At(i).Mass / (i + 1);
            }

            return score;
        }
    }
}