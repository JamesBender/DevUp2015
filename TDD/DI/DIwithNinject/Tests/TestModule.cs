using Ninject.Core;

namespace Tests
{
    public class TestModule : StandardModule
    {
        public override void Load()
        {
            Bind<IDIBusinessService>().To<DIBusinessService>();
            Bind<ILogger>().To<Logger>();
            Bind<IDataSource>().To<DataSource>();
        }
    }
}