namespace Bluma;

public enum Color
{
    Primary,
    Link,
    Info,
    Success,
    Warning,
    Danger,
    Black,
    White
}

public enum ShadeColor
{
    [CssClass("black-bis")]BlackBis,
    [CssClass("black-ter")]BlackTer,
    [CssClass("grey-darker")]GreyDarker,
    [CssClass("grey-dark")]GreyDark,
    [CssClass("grey")]Grey,
    [CssClass("grey-light")]GreyLight,
    [CssClass("grey-lighter")]GreyLighter,
    [CssClass("white-ter")]WhiteTer,
    [CssClass("white-bis")]WhiteBis
}

public enum ThemeMode
{
    None,
    Dark,
    Light,
}