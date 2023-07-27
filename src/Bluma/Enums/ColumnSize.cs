namespace Bluma;

public enum ColumnSize
{
    None,
    [CssClass("1")] Is1,
    [CssClass("2")] Is2,
    [CssClass("3")] Is3,
    [CssClass("4")] Is4,
    [CssClass("5")] Is5,
    [CssClass("6")] Is6,
    [CssClass("7")] Is7,
    [CssClass("8")] Is8,
    [CssClass("9")] Is9,
    [CssClass("10")] Is10,
    [CssClass("11")] Is11,
    [CssClass("12")] Is12,
    /// <summary>
    /// 四分之三。
    /// </summary>
    [CssClass("three-quarters")] Is3of4,
    /// <summary>
    /// 三分之二。
    /// </summary>
    [CssClass("two-thirds")] Is2of3,
    /// <summary>
    /// 三分之一。
    /// </summary>
    [CssClass("one-thirds")] Is1of3,
    /// <summary>
    /// 四分之一。
    /// </summary>
    [CssClass("one-quarter")] Is1of4,
    /// <summary>
    /// 五分之四。
    /// </summary>
    [CssClass("four-fifths")] Is4of5,
    /// <summary>
    /// 五分之三。
    /// </summary>
    [CssClass("three-fifths")] Is3of5,
    /// <summary>
    /// 五分之二。
    /// </summary>
    [CssClass("two-fifths")] Is2of5,
    /// <summary>
    /// 五分之一。
    /// </summary>
    [CssClass("one-fifth")] Is1of5,
    /// <summary>
    /// 百分之百。
    /// </summary>
    [CssClass("full")] IsFull,
    /// <summary>
    /// 二分之一。
    /// </summary>
    [CssClass("half")] IsHarf
}
