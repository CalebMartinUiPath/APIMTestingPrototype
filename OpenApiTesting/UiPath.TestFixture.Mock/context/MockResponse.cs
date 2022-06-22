namespace UiPath.TestFixture.Mock.context;

public class MockResponse
{
    public Guid id { get; set; } = Guid.NewGuid();
    public object? Content { get; set; }
}
