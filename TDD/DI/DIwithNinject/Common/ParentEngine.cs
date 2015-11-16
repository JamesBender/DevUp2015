using Common;
using MyNinjectModules;

namespace Common
{
    public abstract class ParentEngine : GrandParent, IBusinessEngine
    {
        public abstract string RunProcess();
    }
}