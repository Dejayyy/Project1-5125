using System;
using Assi1.Aggregates;

namespace Assi1.Strategies
{
    public class PyramidStrategy : IStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            int pyramidScore = 0;

            for (int i = 1; i < list.Length(); i++)
            {
                HeavyObject current = list.At(i);
                HeavyObject below = list.At(i - 1);

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