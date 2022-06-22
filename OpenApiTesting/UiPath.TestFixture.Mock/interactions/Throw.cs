using UiPath.TestFixture.Mock.interfaces;

namespace UiPath.TestFixture.Mock.interactions;

public class Throw<T> : IThrowable<T>
{
    public void Throws()
    {
        Console.WriteLine("I throw!");
    }
}
