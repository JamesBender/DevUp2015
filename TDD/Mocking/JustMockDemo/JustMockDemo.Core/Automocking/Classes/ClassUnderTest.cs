using System.Collections.Generic;

namespace JustMockDemo.Core.Automocking.Classes
{
    public class ClassUnderTest
    {
        private IFirstDependency _firstDep;
        private ISecondDependency _secondDep;

        public ClassUnderTest(IFirstDependency firstDep, ISecondDependency secondDep)
        {
            _firstDep = firstDep;
            _secondDep = secondDep;
        }

        public IList<object> CollectionMethod()
        {
            var firstCollection = _firstDep.GetList();

            return firstCollection;
        }

        public string StringMethod()
        {
            var secondString = _secondDep.GetString();

            return secondString;
        }
    }
}