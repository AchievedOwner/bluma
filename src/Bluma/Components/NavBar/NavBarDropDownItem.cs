namespace Bluma;

[CssClass("has-dropdown",Concat =true)]
public class NavBarDropDownItem:NavBarItem
{
    [Parameter]public RenderFragment? ToogleContent { get; set; }
    [Parameter]public RenderFragment? DropDownContent { get; set; }

    protected override void AddContent(RenderTreeBuilder builder, int sequence)
    {
        builder.Anchor(@class: "narbar-link").Content(ToogleContent).Close();

        builder.Div("narbar-dropdown").Content(DropDownContent).Close();
    }
}
