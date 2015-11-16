namespace Tests
{
    public interface IBusinessService
    {
        string GetData();
    }

    public class BusinessService : IBusinessService
    {
        private readonly ILogger _logger;
        private readonly IDataSource _dataSource;

        public BusinessService()
        {
            _logger = new Logger();
            _dataSource = new DataSource();
        }

        public string GetData()
        {            
            _logger.Log();
            return _dataSource.GetData(55);
        }
    }
}