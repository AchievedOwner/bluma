using Microsoft.AspNetCore.Components.Routing;

namespace Bluma;
/// <summary>
/// A link as the sibling of a dropdown, with an arrow.
/// </summary>
[CssClass("navbar-link")]
[ChildComponent(typeof(NavBar))]
public class NavBarLink : BlumaChildContentComponentBase, IHasNavLinkComponent
{
    [Parameter] public NavLinkMatch Match { get; set; } = NavLinkMatch.All;
    public bool IsActive { get; set; }
}
