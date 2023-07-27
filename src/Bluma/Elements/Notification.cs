namespace Bluma;

[CssClass("notification")]
public class Notification : BlumaChildContentComponentBase
{
    [Parameter][CssClass("is-")]public Color? Color { get; set; }
    [Parameter][CssClass("is-light")]public bool Light { get; set; }
    [Parameter]public EventCallback OnClosing { get; set; }

    protected override void AddContent(RenderTreeBuilder builder, int sequence)
    {
        builder.Component<Delete>().Close();
        base.AddContent(builder, sequence);
    }
}
