namespace Bluma.Fluent;
/// <summary>
/// A fluent API support <see cref="IFluentBreakPoint"/> return type.
/// </summary>
public interface IFluentBreakPoint : IFluentBreakPoint<IFluentBreakPoint>
{

}

/// <summary>
/// A fluent API support specified return type for reponsive.
/// </summary>
/// <typeparam name="TResult">The type of result.</typeparam>
public interface IFluentBreakPoint<TResult> :IFluentClassProvider
    where TResult : class
{
    TResult OnMobile { get; }
    TResult OnTablet { get; }
    TResult OnDesktop { get; }
    TResult OnWideScreen { get; }
    TResult OnFullHD { get; }
}

/// <summary>
/// Default provider for fluent CSS class to create break point class.
/// </summary>
internal class FluentBreakPointClassProvider :  IFluentBreakPoint
{
    List<BreakPoint> _classList;
    /// <summary>
    /// Initializes a new instance of the <see cref="FluentBreakPointClassProvider"/> class.
    /// </summary>
    internal FluentBreakPointClassProvider() => _classList = new List<BreakPoint>();

    public IFluentBreakPoint OnMobile =>Set(BreakPoint.Mobile);
    public IFluentBreakPoint OnTablet => Set(BreakPoint.Tablet);
    public IFluentBreakPoint OnDesktop => Set(BreakPoint.Desktop);
    public IFluentBreakPoint OnWideScreen => Set(BreakPoint.WideScreen);
    public IFluentBreakPoint OnFullHD => Set(BreakPoint.FullHD);

    /// <summary>
    /// Sets the break point value..
    /// </summary>
    /// <param name="breakPoint">The break point.</param>
    /// <returns>An IFluentBreakPoint.</returns>
    IFluentBreakPoint Set(BreakPoint breakPoint)
    {
        if (! _classList.Contains(breakPoint) )
        {
            _classList.Add(breakPoint);
        }
        return this;
    }

    /// <inheritdoc/>
    public IEnumerable<string> Create()
    {
        return _classList.Select(m => $"is-{m.GetCssClass()}");
    }
}
