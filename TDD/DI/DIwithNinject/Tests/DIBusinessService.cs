// ReSharper disable InconsistentNaming
namespace Tests
{
    public interface IDIBusinessService
    {
        string GetData();
    }

    public class DIBusinessService : IDIBusinessService
    {
        private readonly ILogger _logger;
        private readonly IDataSource _dataSource;

        public DIBusinessService(ILogger logger, IDataSource dataSource)
        {
            _logger = logger;
            _dataSource = dataSource;
        }

        public string GetData()
        {
            _logger.Log();
            return _dataSource.GetData(44);
        }
    }    
}
// ReSharper restore InconsistentNaming