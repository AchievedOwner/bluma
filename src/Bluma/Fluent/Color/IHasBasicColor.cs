namespace Bluma;

public interface IHasBasicColor<TResult> where TResult : class
{
    TResult Primary { get; }
    TResult Info { get; }
    TResult Success { get; }
    TResult Warning { get; }
    TResult Link { get; }
    TResult White { get; }
    TResult Black { get; }
}

public interface IHasDarkLightColor<TResult> where TResult : class
{
    TResult WithLight { get; }
    TResult WithDark { get; }
}
