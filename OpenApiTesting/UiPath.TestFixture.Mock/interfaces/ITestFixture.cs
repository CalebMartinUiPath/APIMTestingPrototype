using System.Linq.Expressions;
using UiPath.TestFixture.Mock.context;
using UiPath.TestFixture.Mock.interactions;

namespace UiPath.TestFixture.Mock.interfaces;

public interface ITestFixture
{
    /// <summary>
    /// looking for some thing like
    /// DependencyMock<LocationService>.Setup(x => x.get()).ReturnsAsync();
    ///
    /// </summary>
    /// <param name="expression"></param>
    /// <typeparam name="TResult"></typeparam>
    /// <returns></returns>
    public ISetup Setup();

    /// <summary>
    /// Return test object
    /// </summary>
    /// <returns></returns>
    public TestContext TestContext { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <param name="testData"></param>
    public void Execute();
}
