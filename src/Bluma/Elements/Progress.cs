namespace Bluma;
[HtmlTag("progress")]
[CssClass("progress")]
public class Progress:BlumaComponentBase
{
    [Parameter][HtmlAttribute]public double? Value { get; set; }
    [Parameter][CssClass("is-")]public Size? Size { get; set; }
    [Parameter][CssClass("is-")]public Color? Color { get; set; }

    protected override void BuildAttributes(IDictionary<string, object> attributes)
    {
        attributes["max"] = 100;
    }
}
