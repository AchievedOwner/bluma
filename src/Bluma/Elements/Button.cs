using Microsoft.AspNetCore.Components.Web;

namespace Bluma;

/// <summary>
/// Represents &lt;button> element.
/// </summary>
[HtmlTag("button")]
[CssClass("button")]
[ChildComponent(typeof(Buttons),Optional =true)]
public class Button : BlumaChildContentComponentBase
{
    /// <summary>
    /// The color of button.
    /// </summary>
    [Parameter][CssClass("is-")]public BtnColor? Color { get; set; }

    /// <summary>
    /// The html type of button.
    /// </summary>
    [Parameter][HtmlAttribute] public HtmlType Type { get; set; } = HtmlType.Button;

    /// <summary>
    /// Use light fill color.
    /// </summary>
    [Parameter][CssClass("is-light")]public bool Light { get; set; }

    /// <summary>
    /// The size of button.
    /// </summary>
    [Parameter][CssClass("is-")]public Size? Size { get; set; }

    /// <summary>
    /// Full width of parent container.
    /// </summary>
    [Parameter][CssClass("is-fullwidth")]public bool FullWidth { get; set; }
    /// <summary>
    /// Outline style.
    /// </summary>
    [Parameter][CssClass("is-outlined")]public bool Outlined { get; set; }
    /// <summary>
    /// Invert fill color.
    /// </summary>
    [Parameter][CssClass("is-inverted")] public bool Inverted { get; set; }
    /// <summary>
    /// Becomes a round border.
    /// </summary>
    [Parameter][CssClass("is-rounded")] public bool Rounded { get; set; }
    /// <summary>
    /// Loading state.
    /// </summary>
    [Parameter][CssClass("is-loading")] public bool Loading { get; set; }
    /// <summary>
    /// non-interactive button.
    /// </summary>
    [Parameter][CssClass("is-static")] public bool Static { get; set; }
    /// <summary>
    /// Responsive automatically for size with different break point.
    /// </summary>
    [Parameter][CssClass("is-responsive")] public bool Responsive { get; set; }
    /// <summary>
    /// Disable button.
    /// </summary>
    [Parameter][HtmlAttribute]public bool Disabled { get; set; }

    /// <summary>
    /// A callback function perform user click button.
    /// </summary>
    [Parameter][HtmlAttribute("onclick")]public EventCallback<MouseEventArgs> OnClick { get; set; }

}

/// <summary>
/// A container to group buttons.
/// </summary>
[CssClass("buttons")]
[ParentComponent]
public class Buttons : BlumaChildContentComponentBase
{
    /// <summary>
    /// All buttons make same size.
    /// </summary>
    [Parameter][CssClass("are-")] public Size? Size { get; set; }
    /// <summary>
    /// Attach all buttons together.
    /// </summary>
    [Parameter][CssClass("has-addons")]public bool Attached { get; set; }
}

public enum HtmlType
{
    Button,
    Submit,
    Reset
}
public enum BtnColor
{
    Primary,
    Info,
    Success,
    Warning,
    Danger,
    Dark,
    Black,
    White,
    Link,
    Text,
    Ghost
}