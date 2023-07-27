namespace Bluma;

/// <summary>
/// Small tag labels to insert anywhere.
/// </summary>
[CssClass("tag")]
[ChildComponent(typeof(Tags),Optional =true)]
public class Tag:BlumaChildContentComponentBase
{
    /// <summary>
    /// The color of tag.
    /// </summary>
    [Parameter][CssClass("is-")]public Color? Color { get; set; }
    /// <summary>
    /// The size of tag.
    /// </summary>
    [Parameter][CssClass("is-")]public Size? Size { get; set; }

    /// <summary>
    /// Be &lt;a> element with closed icon.
    /// </summary>
    [Parameter][CssClass("is-delete")]public bool Delete { get; set; }

    public override string GetTagName() => Delete ? "a" : "span";
}

/// <summary>
/// A group of tags.
/// </summary>
[CssClass("tags")]
[ParentComponent]
public class Tags:BlumaChildContentComponentBase
{
    /// <summary>
    /// All size of tags.
    /// </summary>
    [Parameter][CssClass("are-")] public Size? Size { get; set; }

    /// <summary>
    /// Attach all tags together.
    /// </summary>
    [Parameter][CssClass("has-addons")]public bool Attached { get; set; }
}