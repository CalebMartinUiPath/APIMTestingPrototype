using System.Linq.Expressions;

namespace UiPath.TestFixture.Mock.interfaces;

public interface ISetup<T>
{
}

public interface ISetup<T, TResult> where T : class
{
}

public interface ISetup
{
    public IReturn Returns<TResult>(TResult obj);

    public IThrowable Throws<TThrowable>(TThrowable exception) where TThrowable : Exception;
}
