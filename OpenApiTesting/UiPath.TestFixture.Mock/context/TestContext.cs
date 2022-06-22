using UiPath.TestFixture.Mock.interfaces;

namespace UiPath.TestFixture.Mock.context;

public abstract class TestContext
{
    public Guid EventId { get; set; } = Guid.NewGuid();

    public abstract void Publish<TReturnResult>(TReturnResult mockReturn);
}
