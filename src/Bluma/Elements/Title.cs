namespace Bluma;

/// <summary>
/// Simple headings to add depth to your page
/// </summary>
public class Title:BlumaChildContentComponentBase
{
    public Title()
    {
        Size = TitleSize.Is3;
    }

    /// <summary>
    /// The size of title.
    /// </summary>
    [Parameter][CssClass("is-")] public TitleSize Size { get; set; }

    public override string GetTagName()
    {
        return $"h{Size.GetCssClass()}";
    }

    protected override void BuildCssClass(ICssClassBuilder builder)
    {
        builder.Append("title");
    }
}

/// <summary>
/// Simple headings to add depth to your page
/// </summary>
public class SubTitle : Title
{
    public SubTitle()
    {
        Size = TitleSize.Is5;
    }

    protected override void BuildCssClass(ICssClassBuilder builder)
    {
        builder.Append("subtitle");
    }
}

public enum TitleSize
{
    [CssClass("1")] Is1,
    [CssClass("2")] Is2,
    [CssClass("3")] Is3,
    [CssClass("4")] Is4,
    [CssClass("5")] Is5,
    [CssClass("6")] Is6,
    [CssClass("7")] Is7,
}