namespace Bluma;
public interface IFluentColumnSize
{
    IFluentColumnSize Offset { get; }
    IFluentColumnBreakPoint Narrow { get; }
    IFluentColumnSizeWithBreakPoint Is1 { get; }
    IFluentColumnSizeWithBreakPoint Is2 { get; }
    IFluentColumnSizeWithBreakPoint Is3 { get; }
    IFluentColumnSizeWithBreakPoint Is4 { get; }
    IFluentColumnSizeWithBreakPoint Is5 { get; }
    IFluentColumnSizeWithBreakPoint Is6 { get; }
    IFluentColumnSizeWithBreakPoint Is7 { get; }
    IFluentColumnSizeWithBreakPoint Is8 { get; }
    IFluentColumnSizeWithBreakPoint Is9 { get; }
    IFluentColumnSizeWithBreakPoint Is10 { get; }
    IFluentColumnSizeWithBreakPoint Is11 { get; }
    IFluentColumnSizeWithBreakPoint Is12 { get; }
    IFluentColumnSizeWithBreakPoint Is3of4 { get; }
    IFluentColumnSizeWithBreakPoint Is2of3 { get; }
    IFluentColumnSizeWithBreakPoint Is1of3 { get; }
    IFluentColumnSizeWithBreakPoint Is1of4 { get; }
    IFluentColumnSizeWithBreakPoint Is4of5 { get; }
    IFluentColumnSizeWithBreakPoint Is3of5 { get; }
    IFluentColumnSizeWithBreakPoint Is2of5 { get; }
    IFluentColumnSizeWithBreakPoint Is1of5 { get; }
    IFluentColumnSizeWithBreakPoint IsHarf { get; }
    IFluentColumnSizeWithBreakPoint IsFull { get; }
}
public interface IFluentColumnSizeWithBreakPoint : IFluentClassProvider, IFluentColumnSize, IFluentColumnBreakPoint
{

}

public interface IFluentColumnBreakPoint : IFluentBreakPoint<IFluentColumnSize> { }

internal class FluentColumnSizeProvider:FluentClassProvider<ColumnSize, FluentColumnSizeProvider.Definition>, IFluentColumnSizeWithBreakPoint, IFluentColumnBreakPoint
{
    public IFluentColumnSize Offset => SetOffset();
    public IFluentColumnBreakPoint Narrow => SetNarrow();
    public IFluentColumnSizeWithBreakPoint Is1 => SetSize(ColumnSize.Is1);
    public IFluentColumnSizeWithBreakPoint Is2 => SetSize(ColumnSize.Is2);
    public IFluentColumnSizeWithBreakPoint Is3 => SetSize(ColumnSize.Is3);
    public IFluentColumnSizeWithBreakPoint Is4 => SetSize(ColumnSize.Is4);
    public IFluentColumnSizeWithBreakPoint Is5 => SetSize(ColumnSize.Is5);
    public IFluentColumnSizeWithBreakPoint Is6 => SetSize(ColumnSize.Is6);
    public IFluentColumnSizeWithBreakPoint Is7 => SetSize(ColumnSize.Is7);
    public IFluentColumnSizeWithBreakPoint Is8 => SetSize(ColumnSize.Is8);
    public IFluentColumnSizeWithBreakPoint Is9 => SetSize(ColumnSize.Is9);
    public IFluentColumnSizeWithBreakPoint Is10 => SetSize(ColumnSize.Is10);
    public IFluentColumnSizeWithBreakPoint Is11 => SetSize(ColumnSize.Is11);
    public IFluentColumnSizeWithBreakPoint Is12 => SetSize(ColumnSize.Is12);
    public IFluentColumnSizeWithBreakPoint Is3of4 => SetSize(ColumnSize.Is3of4);
    public IFluentColumnSizeWithBreakPoint Is2of3 => SetSize(ColumnSize.Is2of3);
    public IFluentColumnSizeWithBreakPoint Is1of3 => SetSize(ColumnSize.Is1of3);
    public IFluentColumnSizeWithBreakPoint Is1of4 => SetSize(ColumnSize.Is1of4);
    public IFluentColumnSizeWithBreakPoint Is4of5 => SetSize(ColumnSize.Is4of5);
    public IFluentColumnSizeWithBreakPoint Is3of5 => SetSize(ColumnSize.Is3of5);
    public IFluentColumnSizeWithBreakPoint Is2of5 => SetSize(ColumnSize.Is2of5);
    public IFluentColumnSizeWithBreakPoint Is1of5 => SetSize(ColumnSize.Is1of5);
    public IFluentColumnSizeWithBreakPoint IsHarf => SetSize(ColumnSize.IsHarf);
    public IFluentColumnSizeWithBreakPoint IsFull => SetSize(ColumnSize.IsFull);
    public IFluentColumnSize OnMobile => SetBreakPoint(BreakPoint.Mobile);
    public IFluentColumnSize OnDesktop => SetBreakPoint(BreakPoint.Desktop);
    public IFluentColumnSize OnTablet => SetBreakPoint(BreakPoint.Tablet);
    public IFluentColumnSize OnWideScreen => SetBreakPoint(BreakPoint.WideScreen);
    public IFluentColumnSize OnFullHD => SetBreakPoint(BreakPoint.FullHD);

    IFluentColumnSizeWithBreakPoint SetSize(ColumnSize size)
    {
        var definition = new Definition { BreakPoint = BreakPoint.None };
        ChangeKey(size);
        //SetValue(definition);
        return this;
    }
    IFluentColumnBreakPoint SetNarrow()
    {
        AddRule(new Definition { Narrow = true });
        return this;
    }
    IFluentColumnSize SetBreakPoint(BreakPoint breakPoint)
    {
        AddRule(new Definition { BreakPoint = breakPoint });
        return this;
    }

    IFluentColumnSize SetOffset()
    {
        AddRule(new Definition { Offset = true });
        return this;
    }
    protected override string? Format(ColumnSize key, Definition value)
    {
        var css = new List<string>() { "is" };
        if ( value.Offset )
        {
            css.Add("offset");
        }
        if ( key != ColumnSize.None )
        {
            css.Add(key.GetCssClass());
        }
        if ( value.Narrow )
        {
            css.Add("narrow");
        }
        if ( value.BreakPoint != BreakPoint.None )
        {
            css.Add(value.BreakPoint.GetCssClass());
        }
        return string.Join("-", css);
    }

    protected override string? Format(ColumnSize key)
    {
        return $"is-{key.GetCssClass()}";
    }

    public struct Definition
    {
        public bool Offset;
        public BreakPoint BreakPoint;
        public bool Narrow;
    }
}
