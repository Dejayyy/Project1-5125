using Assi1.Aggregates;

namespace Assi1.Strategies
{
    public class ToppleStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            int stabilityScore = 0;

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
                    stabilityScore--;
                }
                else if (currentMass < belowMass && currentBaseArea > belowBaseArea)
                {
                    stabilityScore++;
                }
            }

            if (stabilityScore > 0)
                return 2;
            else if (stabilityScore < 0)
                return -2;
            else
                return 0;
        }
    }
}