using System;
using System.Collections.Generic;
using Assi1.Strategies;

namespace Assi1.Flyweights
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, iStackingStrategy> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<string, iStackingStrategy>();
        }

        public iStackingStrategy GetFlyweight(string strategyName)
        {
            if (!_flyweights.ContainsKey(strategyName))
            {
                switch (strategyName.ToLower())
                {
                    case "topple":
                        _flyweights[strategyName] = new ToppleStrategy();
                        break;
                        
                    case "pyramid":
                        _flyweights[strategyName] = new PyramidStrategy();
                        break;
                    /*
                case "bottomweight":
                    _flyweights[strategyName] = new BottomWeightStrategy();
                    break;
                    */
                    default:
                        throw new ArgumentException($"Strategy '{strategyName}' is not recognized.");
                }
            }
            return _flyweights[strategyName];
        }
    }
}
