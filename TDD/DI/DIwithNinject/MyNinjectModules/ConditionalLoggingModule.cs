using System;
using Common;
using Ninject.Activation;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class ConditionalLoggingModule : NinjectModule
    {
        private readonly bool _isConnected;

        public ConditionalLoggingModule(bool isConnected)
        {
            _isConnected = isConnected;
        }

        public override void Load()
        {
            Bind<ILoggingSink>().To<NormalLoggingSync>();
            
            if (_isConnected)
            {
                Bind<IDomComponent>().To<Logger>();
            }
            else
            {
                Bind<IDomComponent>().ToProvider<OfflineLoggingCompoentProvider>();
            }
            
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }

    public class OfflineLoggingCompoentProvider : Provider<OffLineLoggingComponent>
    {
        protected override OffLineLoggingComponent CreateInstance(Ninject.Activation.IContext context)
        {
            return new OffLineLoggingComponent();
        }
    }
}