using System.Collections.Generic;
using JustMockDemo.Core.MockByExample.Classes;
using NUnit.Framework;
using Telerik.JustMock;

namespace JustMockDemo.Core.MockByExample
{
    [TestFixture]
    public class MockByExampleTests
    {
        [Test]
        public void NotMockedByExample()
        {
            var blockingCondition1 = Mock.Create<IDetectionInfoBase>();
            Mock.Arrange(() => blockingCondition1.Name).Returns("foo");

            var installer1 = Mock.Create<IInstallerInfo>();
            Mock.Arrange(() => installer1.BlockingCondition).Returns(blockingCondition1);
            Mock.Arrange(() => installer1.Name).Returns("blocked1");

            var package1 = Mock.Create<IInstallPackage>();
            Mock.Arrange(() => package1.Installer).Returns(installer1);

            var blockingCondition2 = Mock.Create<IDetectionInfoBase>();
            Mock.Arrange(() => blockingCondition2.Name).Returns("bar");

            var installer2 = Mock.Create<IInstallerInfo>();
            Mock.Arrange(() => installer2.BlockingCondition).Returns(blockingCondition2);
            Mock.Arrange(() => installer2.Name).Returns("blocked2");

            var package2 = Mock.Create<IInstallPackage>();
            Mock.Arrange(() => package2.Installer).Returns(installer2);

            var installInfo = Mock.Create<IInstallInfo>();
            Mock.Arrange(() => installInfo.InstallPackages).Returns(new List<IInstallPackage> { package1, package2 });
        }

        [Test]
        public void MockedByExample()
        {
            var installInfo = Mock.CreateLike<IInstallInfo>(me =>
            me.InstallPackages == new List<IInstallPackage>
            {
                Mock.CreateLike<IInstallPackage>(pkg => pkg.Installer.Name == "blocked1" &&
                                                        pkg.Installer.BlockingCondition.Name == "foo"),
                Mock.CreateLike<IInstallPackage>(pkg => pkg.Installer.Name == "blocked2" &&
                                                        pkg.Installer.BlockingCondition.Name == "bar"),
            });
        }
    }
}