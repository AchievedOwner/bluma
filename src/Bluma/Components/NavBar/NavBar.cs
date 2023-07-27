namespace Bluma;

/// <summary>
/// The contains of navigation bar.
/// </summary>
[CssClass("navbar")]
[HtmlRole("navigation")]
[HtmlAria("label", Value = "main navigation")]
[HtmlTag("nav")]
//[ParentComponent]
public class NavBar : BlumaComponentBase,IHasColor
{
    /// <summary>
    /// Set the UI content which usually contains the logo and optionally some links or icons 
    /// </summary>
    [Parameter] public RenderFragment? BrandContent { get; set; }
    /// <summary>
    /// Sets left part of the menu, which appears next to the navbar brand on desktop.
    /// </summary>
    [Parameter] public RenderFragment? StartContent { get; set; }
    /// <summary>
    /// Sets right part of the menu, which appears at the end of the navbar.
    /// </summary>
    [Parameter] public RenderFragment? EndContent { get; set; }
    /// <summary>
    /// Sets an icon which toggles the navbar menu on touch devices.
    /// </summary>
    [Parameter] public bool ToogleButton { get; set; } = true;
    [Parameter] public Color? Color { get; set; }
    /// <summary>
    /// Sets Top and Bottom paddings with 1rem,Left and Right paddings with 2rem.
    /// </summary>
    [Parameter][CssClass("has-shadow")] public bool Shading { get; set; }
    /// <summary>
    /// Adds a small amount of box-shadow around the navbar.
    /// </summary>
    [Parameter][CssClass("is-spaced")]public bool Spacing { get; set; }

    protected override void AddContent(RenderTreeBuilder builder, int sequence)
    {
        BuildBrand(builder);
        BuildMenu(builder);
    }

    void BuildBrand(RenderTreeBuilder builder) 
        => builder.Div("navbar-brand", BrandContent is not null)
                    .Content(content =>
                    {
                        content.AddContent(0, BrandContent);

                        content.Anchor("/", "navbar-burger")
                                .Role("button")
                                .Aria("label", "menu")
                                .Aria("expanded", "false")
                                .Content(burger =>
                                {
                                    burger.Span().Aria("hidden", true).Close()
                                    .Span().Aria("hidden", true).Close()
                                    .Span().Aria("hidden", true).Close();
                                })
                               .Close();
                    })
                  .Close();
    void BuildMenu(RenderTreeBuilder builder) 
        => builder.Div("navbar-menu")
                    .Content(content => content.Div("navbar-start", StartContent is not null)
                                                .Content(StartContent)
                                               .Close()
                                               .Div("navbar-end", EndContent is not null)
                                                .Content(EndContent)
                                               .Close())
                  .Close();
}
