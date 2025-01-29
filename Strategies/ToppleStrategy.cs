using System;
using Assi1.Aggregates;

namespace Assi1.Strategies
{
    public class ToppleStrategy : IStackingStrategy
    {
        // EvaluateStack takes in a HeavyObjectList (concrete aggregate) and outputs the score as a floating point value
        public float EvaluateStack(HeavyObjectList list)
        {
            float score = 0;

            // create the iterator
            IIterator<HeavyObject> iterator = list.CreateIterator();
            iterator.First();
            HeavyObject below = iterator.CurrentItem();

            // loop using iterator
            for ( iterator.Next(); !iterator.IsDone(); iterator.Next() )
            {
                HeavyObject current = iterator.CurrentItem();

                float currentMass = current.Mass;
                float belowMass = below.Mass;

                float currentBaseArea = current.Width * current.Length;
                float belowBaseArea = below.Width * below.Length;

                if (currentMass > belowMass && currentBaseArea < belowBaseArea)
                    score--;
                else if (currentMass < belowMass && currentBaseArea > belowBaseArea)
                    score++;

                // move up
                below = current;
            }

            return score;

        }
    }
}