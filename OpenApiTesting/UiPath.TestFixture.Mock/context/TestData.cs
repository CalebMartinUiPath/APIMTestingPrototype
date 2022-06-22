namespace UiPath.TestFixture.Mock.context;

[Serializable]
public class TestData
{
    public Guid id { get; set; } = Guid.NewGuid();

    public object? data;
}
