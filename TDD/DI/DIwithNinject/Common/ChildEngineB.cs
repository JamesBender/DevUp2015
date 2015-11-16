using System;

namespace Common   
{
    public class ChildEngineB  : IBusinessEngine
    {
        private readonly IDomComponent _component;

        public ChildEngineB(IDomComponent component)
        {
            _component = component;
        }

        public string RunProcess()
        {
            Console.WriteLine("From Chile B : {0}", _component.Execute());
            return "done";
        }
    }
} 