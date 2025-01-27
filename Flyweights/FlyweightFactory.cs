using System;
using System.Collections.Generic;
using Assi1.Strategies;

namespace Assi1.Flyweights
{
    public class FlyweightFactory
    {
        protected Dictionary<string, IStackingStrategy> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<string, IStackingStrategy>();
        }

        public IStackingStrategy GetFlyweight(string strategyName)
        {

            IStackingStrategy strategy = null;
            if (_flyweights.ContainsKey(strategyName))
            {
                strategy = _flyweights[strategyName];
            }
            else
            {
                switch (strategyName.ToLower())
                {
                    case "topple":
                        strategy = new ToppleStrategy();
                        break;
                        
                    case "pyramid":
                        strategy = new PyramidStrategy();
                        break;
                case "bottomweight":
                        strategy = new BottomWeightStrategy();
                    break;
                    default:
                        throw new ArgumentException($"Strategy '{strategyName}' is not recognized.");
                }

                _flyweights[strategyName] = strategy;

            }
            return _flyweights[strategyName];
        }
    }
}
