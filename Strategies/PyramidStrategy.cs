using System;
using Assi1.Aggregates;

namespace Assi1.Strategies
{
    public class PyramidStrategy : iStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            int pyramidScore = 0;

            for (int i = 1; i < list.Count; i++)
            {
                HeavyObject current = list.Get(i);
                HeavyObject below = list.Get(i - 1);

                float currentBaseArea = current.Width * current.Length;
                float belowBaseArea = below.Width * below.Length;

                if (currentBaseArea < belowBaseArea)               
                    pyramidScore++;
                else if (currentBaseArea > belowBaseArea)
                    pyramidScore--;               
            }

            return pyramidScore;
        }
    }
}