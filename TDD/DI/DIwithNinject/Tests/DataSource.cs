using System.Threading;

namespace Tests
{
    public interface IDataSource
    {
        string GetData(int id);
    }

    public class DataSource : IDataSource
    {
        public string GetData(int id)
        {
            Thread.Sleep(10000);
            return "data from the component";
        }
    }
}   