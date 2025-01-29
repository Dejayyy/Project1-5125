using Assi1.Aggregates;
using System;

namespace Assi1.Strategies
{
    public class BottomWeightStrategy : IStackingStrategy
    {
        //EvaluateStack takes in a HeavyObjectList (concrete aggregate) and outputs the score as a floating point value
        public float EvaluateStack(HeavyObjectList list)
        {
            float score = 0; 

            //create iterator
            IIterator<HeavyObject> iterator = list.CreateIterator();

            int i = 0;

            //loop using iterator
            for ( iterator.First(); !iterator.IsDone(); iterator.Next() )
            {
                HeavyObject obj = iterator.CurrentItem();
                score += obj.Mass / (i + 1);
                i++;
            }

            return score;
        }
    }
}