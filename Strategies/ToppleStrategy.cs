using System;
using System.Collections.Generic;
using System.Text;
using Assi1.Aggregates;

namespace Assi1.Strategies
{
    class ToppleStrategy : StackingStrategy
    {
        public override float EvaluateStack(HeavyObjectList list)
        {
            float toppleScore = 0.0f;

            for (int i = 1; i < list.Count; i++)
            {
                HeavyObject current = list.Get(i);
                HeavyObject below = list.Get(i - 1);

                float currentMass = current.Mass;
                float belowMass = below.Mass;

                float currentBaseArea = current.Width * current.Length;
                float belowBaseArea = below.Width * below.Length;

                if (currentMass > belowMass && currentBaseArea < belowBaseArea)
                {
                    float massDifference = currentMass - belowMass;
                    float areaDifference = belowBaseArea - currentBaseArea;
                    toppleScore += massDifference * areaDifference;
                }
            }
            return -toppleScore;
        }
    }
}