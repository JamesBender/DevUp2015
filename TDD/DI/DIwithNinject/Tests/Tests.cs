using System;
using NBehave.Spec.NUnit;
using Ninject.Core;
using NUnit.Framework;
using Rhino.Mocks;

// ReSharper disable InconsistentNaming

namespace Tests
{
    public class UnitTestWithOutDI : Specification
    {
        private IBusinessService _businessService;
        private string _result;

        protected override void Establish_context()
        {
            base.Establish_context();
            _businessService = new BusinessService();
        }

        protected override void Because_of()
        {
            _result = _businessService.GetData();
        }

        [Test]
        public void then_some_business_stuff_should_happen()
        {
            Console.WriteLine(_result);
            _result.ShouldNotBeEmpty();            
        }
    }

    public class UnitTestsWithDI : Specification
    {
        private ILogger _logger;
        private IDataSource _dataSource;
        private IDIBusinessService _businessService;
        private string _result;

        protected override void Establish_context()
        {
            base.Establish_context();

            _logger = MockRepository.GenerateStub<ILogger>();
            _dataSource = 
                MockRepository.GenerateStub<IDataSource>();
            
            _businessService = 
                new DIBusinessService(_logger, _dataSource);

            _logger.Stub(logger => logger.Log());

            _dataSource
                .Stub(dataSource => dataSource.GetData(44))
                .Return("from mock");
            
            _dataSource
                .Stub(dataSource => dataSource.GetData(1))
                .IgnoreArguments().Return("_not_ from mock");
        }

        protected override void Because_of()
        {
            _result = _businessService.GetData();
        }

        [Test]
        public void then_some_business_stuff_should_happen()
        {
            Console.WriteLine(_result);
            _result.ShouldNotBeEmpty();
            _logger.AssertWasCalled(logger => logger.Log());
        }
    }

    public class IntergrationTestsWithDI : Specification
    {
        private StandardKernel _kernel;
        private IDIBusinessService _businessService;
        private string _result  ;

        protected override void Establish_context()
        {
            base.Establish_context();
            _kernel = new StandardKernel(new TestModule());
            _businessService = _kernel.Get<IDIBusinessService>();
        }

        protected override void Because_of()
        {
            _result = _businessService.GetData();
        }

        [Test]
        public void then_some_business_stuff_should_happen()
        {
            Console.WriteLine(_result);
            _result.ShouldNotBeEmpty();            
        }
    }
}


// ReSharper restore InconsistentNaming