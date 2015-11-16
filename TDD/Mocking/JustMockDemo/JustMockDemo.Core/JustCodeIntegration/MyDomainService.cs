namespace JustMockDemo.Core.JustCodeIntegration
{
    public class MyDomainService
    {
        private readonly IMyInterface _myInterface;

        public MyDomainService(IMyInterface myInterface)
        {
            _myInterface = myInterface;
        }
    }
}