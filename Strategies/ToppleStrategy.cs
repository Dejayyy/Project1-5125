using System;
using Assi1.Aggregates;

namespace Assi1.Strategies
{
    public class ToppleStrategy : IStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            int stabilityScore = 0;

            for (int i = 1; i < list.Length(); i++)
            {
                HeavyObject current = list.At(i);
                HeavyObject below = list.At(i - 1);

                float currentMass = current.Mass;
                float belowMass = below.Mass;

                float currentBaseArea = current.Width * current.Length;
                float belowBaseArea = below.Width * below.Length;

                if (currentMass > belowMass && currentBaseArea < belowBaseArea)
                    stabilityScore--;
                else if (currentMass < belowMass && currentBaseArea > belowBaseArea)
                    stabilityScore++;
            }

            return stabilityScore;

        }
    }
}