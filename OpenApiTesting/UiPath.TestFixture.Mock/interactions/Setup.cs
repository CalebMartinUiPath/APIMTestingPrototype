using System.Linq.Expressions;
using System.Runtime.Versioning;
using UiPath.TestFixture.Mock.interfaces;

namespace UiPath.TestFixture.Mock.interactions;

public class Setup : ISetup
{
    private readonly DependencyMode _mode;
    private readonly ITestFixture _fixture;
    private IReturn _return;

    public Setup(DependencyMode mode, ITestFixture fixture)
    {
        _mode = mode;
        _fixture = fixture;
    }

    public IReturn Returns<TReturnResult>(TReturnResult result)
    {
        _fixture.TestContext.Publish(result);
        _return = new Returnal();
        return _return;
    }

    public IThrowable Throws<TThrowable>(TThrowable exception) where TThrowable : Exception
    {
        throw new NotImplementedException();
    }
}
