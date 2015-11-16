using System.Collections.Generic;

namespace JustMockDemo.Core.MockByExample.Classes
{
    public interface IInstallInfo
    {
        IList<IInstallPackage> InstallPackages { get; set; }
    }
}