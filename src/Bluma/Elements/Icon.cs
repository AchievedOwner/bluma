namespace Bluma;

/// <summary>
/// Use FontAwesome 5 for icon font.
/// </summary>
[ChildComponent(typeof(IconText),Optional =true)]
public class Icon : BlumaChildContentComponentBase
{
    [CascadingParameter]public IconText? CascadingIconText { get; set; }

    /// <summary>
    /// The style of icon.
    /// </summary>
    [Parameter] public IconStyle Style { get; set; } = IconStyle.Solid;

    /// <summary>
    /// The icon name of FontAwesome. See https://fontawesome.com/icons to find icon name.
    /// </summary>
    [Parameter]public string? Name { get; set; }
    [Parameter][CssClass("is-")]public Size? Size { get; set; }
    /// <summary>
    /// The color of icon.
    /// </summary>
    [Parameter][CssClass("has-text-")]public Color? Color { get; set; }

    protected override void AddContent(RenderTreeBuilder builder, int sequence)
    {
        if ( CascadingIconText is null )
        {
            if(ChildContent is not null )
            {
                builder.Component<IconText>()
                    .Attribute(m=>m.Color,Color).Content(inner =>
                {

                    BuildFontIcon(inner);
                    BuildText(inner);
                })
                .Close();
            }
            else
            {
                BuildFontIcon(builder);
            }
        }
        else
        {            
            BuildFontIcon(builder);
            BuildText(builder);
        }
    }
    private void BuildText(RenderTreeBuilder builder)
        => builder.Span(condition:ChildContent is not null).Content(ChildContent).Close();
    private void BuildFontIcon(RenderTreeBuilder builder)
    {
        builder.Span("icon").Content(icon =>
        {
            icon.Element("i").Class(Style.GetCssClass("fa")).Class($"fa-{Name}").Close();
        }).Close();
    }
}

/// <summary>
/// Combine with <see cref="Icon"/> components with text.
/// </summary>
[CssClass("icon-text")]
[HtmlTag("span")]
[ParentComponent]
public class IconText : BlumaChildContentComponentBase
{
    /// <summary>
    /// The color of icon.
    /// </summary>
    [Parameter][CssClass("has-text-")] public Color? Color { get; set; }
}

/// <summary>
/// The style of icon for FontAwesome.
/// </summary>
public enum IconStyle
{
    [CssClass("s")]Solid,
    [CssClass("r")]Regular,
    [CssClass("l")]Light,
    [CssClass("d")]Duatone
}
