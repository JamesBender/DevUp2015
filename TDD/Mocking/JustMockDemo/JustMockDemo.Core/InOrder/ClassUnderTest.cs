namespace JustMockDemo.Core.InOrder
{
    public class ClassUnderTest
    {
        readonly IInOrderDependency _sequentialDependency;

        public ClassUnderTest(IInOrderDependency sequentialDependency)
        {
            _sequentialDependency = sequentialDependency;
        }

        public bool TestMe()
        {
            _sequentialDependency.First();
            _sequentialDependency.Third();
            _sequentialDependency.Second();

            return true;
        }
    }
}