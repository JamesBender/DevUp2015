using System.Collections.Generic;

namespace JustMockDemo.Core.Automocking.Classes
{
    public interface IFirstDependency
    {
        IList<object> GetList();
    }
}