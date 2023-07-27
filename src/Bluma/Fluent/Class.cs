namespace Bluma;
public static class Class
{
    public static IFluentBreakPoint BreakPoint => new FluentBreakPointClassProvider();
    public static IFluentTextColor TextColor => new FluentTextColorProvider();
}


public static class Col
{
    public static IFluentColumnSizeWithBreakPoint Size => new FluentColumnSizeProvider();
}