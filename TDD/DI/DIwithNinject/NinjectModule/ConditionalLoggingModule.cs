using System;
using Common;
using Ninject.Activation;
using Ninject.Modules;

namespace NinjectModules
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
                Bind<IComponent>().To<Logger>();
            }
            else
            {
                Bind<IComponent>().ToProvider<OfflineLoggingCompoentProvider>();
            }
            
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }

    public class OfflineLoggingCompoentProvider : Provider<OffLineLoggingComponent>
    {
        //protected override OffLineLoggingComponent CreateInstance(IContext context)
        //{
        //    return new OffLineLoggingComponent();
        //}
        protected override OffLineLoggingComponent CreateInstance(Ninject.Activation.IContext context)
        {
            return new OffLineLoggingComponent();
        }
    }
}