namespace Bluma;

/// <summary>
/// A versatile delete cross.
/// </summary>
[HtmlTag("button")]
[CssClass("delete")]
public class Delete:BlumaChildContentComponentBase
{
    /// <summary>
    /// The size of delete button.
    /// </summary>
    [Parameter][CssClass("is-")]public Size? Size { get; set; }
}
