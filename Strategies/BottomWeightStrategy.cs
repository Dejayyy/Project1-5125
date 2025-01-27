using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Strategies
{
    //BottomWeightStrategy class implements the IStackingStrategy interface
    public class BottomWeightStrategy : IStackingStrategy
    {
        //EvaluateStack method that takes in a HeavyObjectList parameter called
        public float EvaluateStack(HeavyObjectList stack)
        {
            float score = 0; //declare float score with value 0

            for (int i = 0; i < stack.Length(); i++)//for loop to loop through the stack starting from the beginning of the stack
            {
                score += stack.At(i).Mass / (i + 1);//Calculate score by adding Mass of every object divided by its position in the stack starting from bottom to top, start from 1 to avoid division by 0
            }

            return score;
        }
    }
}