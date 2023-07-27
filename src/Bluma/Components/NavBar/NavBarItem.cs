namespace Bluma;

/// <summary>
/// Provides each single item of the navbar.
/// </summary>
[CssClass("navbar-item")]
[ChildComponent(typeof(NavBar))]
public class NavBarItem : BlumaChildContentComponentBase
{
    /// <summary>
    /// Sets item has link and render as &lt;a> element, otherwise, render &lt;div> element.
    /// </summary>
    [Parameter][HtmlAttribute("href")]public string? Link { get; set; }

    /// <inheritdoc/>
    public override string GetTagName() => Link.IsNotNullOrEmpty() ? "a" : "div";
}
