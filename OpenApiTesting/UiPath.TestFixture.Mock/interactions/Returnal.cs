using UiPath.TestFixture.Mock.interfaces;

namespace UiPath.TestFixture.Mock.interactions;

public class Returnal : IReturn
{

    public void Verify()
    {
        Console.WriteLine("Congrats");
    }
}
