namespace Bluma;

/// <summary>
/// Represents columns grid by flex layout.
/// </summary>
[CssClass("columns")]
[ParentComponent]
public class Columns : BlumaComponentBase, IHasChildContent
{
    /// <inheritdoc/>
    [Parameter] public RenderFragment? ChildContent { get; set; }
}