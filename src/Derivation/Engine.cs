using System;
using System.Collections.Generic;

namespace Derivation
{
    public class Engine : IEngine
    {
        private readonly List<IProcessor> processors;
        private readonly IModel model;

        public Engine(List<IProcessor> processors, IModel model)
        {
            this.processors = processors;
            this.model = model;
        }

        public void Run()
        {
            foreach(var processor in processors)
            {
                 processor.Execute(model);
            }

        }
    }

    //IDiscoverDervations
    //ISortDerivations
    //IDatabaseDerivation
    //IFieldDerivation
    //IDependentDerviation
}
