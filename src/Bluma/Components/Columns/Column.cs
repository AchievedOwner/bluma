namespace Bluma;

/// <summary>
/// Represents a single column in <see cref="Columns"/> component.
/// </summary>
[ChildComponent(typeof(Columns))]
[CssClass("column")]
public class Column : BlumaChildContentComponentBase
{
    /// <summary>
    /// The size of column.
    /// </summary>
    [Parameter] public IFluentColumnSizeWithBreakPoint? Size { get; set; }
}
