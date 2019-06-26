using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Derivation
{
    public abstract class Processor : IProcessor
    {
        public abstract void Execute(IModel model);

        protected virtual List<T> Load<T>()
        {
            //load all objects with Marker interface T
            return new List<T> {};
        }
        protected virtual List<T> Sort<T>(List<T> derivations, JObject dependency)
        {
            //sort the derivations with dependency json
            return new List<T> {};
        }
    }
}