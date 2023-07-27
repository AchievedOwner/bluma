using Microsoft.AspNetCore.Components.Routing;

namespace Bluma;
[ChildComponent(typeof(MenuList))]
[HtmlTag("a")]
public class MenuListItem : BlumaChildContentComponentBase, IHasNavLinkComponent
{
    public NavLinkMatch Match { get; set; } = NavLinkMatch.All;
    public bool IsActive { get; set; }
    public string? ActiveCssClass => "is-active";

    [Parameter][HtmlAttribute("href")] public string? Link { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.Element("li").Content(base.BuildRenderTree).Close();
    }
}
