namespace Bluma;
[ParentComponent]
[CssClass("table")]
[HtmlTag("table")]
public class Table:BlumaComponentBase
{
    [Parameter][CssClass("is-striped")]public bool Striped { get; set; }
    [Parameter][CssClass("is-narrow")] public bool Narrow { get; set; }
    [Parameter][CssClass("is-hoverable")] public bool Hoverable { get; set; }
    [Parameter][CssClass("is-fullwidth")] public bool FullWidth { get; set; }
    [Parameter][CssClass("is-bordered")] public bool Bordered { get; set; }
    [Parameter] public bool Container { get; set; }

    [Parameter]public RenderFragment? HeaderContent { get; set; }
    [Parameter] public RenderFragment? BodyContent { get; set; }
    [Parameter] public RenderFragment? FooterContent { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if ( Container )
        {
            builder.Div("table-container").Content(BuildRenderTree).Close();
        }
        else
        {
            base.BuildRenderTree(builder);
        }
    }

    protected override void AddContent(RenderTreeBuilder builder, int sequence)
    {
        builder.Element("thead",condition: HeaderContent is not null).Content(HeaderContent).Close();
        builder.Element("tbody", condition: BodyContent is not null).Content(BodyContent).Close();
        builder.Element("tfoot", condition: FooterContent is not null).Content(FooterContent).Close();
    }
}

[HtmlTag("tr")]
[ParentComponent]
[ChildComponent(typeof(Table))]
public class TableRow : BlumaChildContentComponentBase
{
    [Parameter][CssClass("is-")]public Color? Color { get; set; }
}
[HtmlTag("td")]
[ChildComponent(typeof(TableRow))]
public class TableCell : BlumaChildContentComponentBase
{
    [Parameter][CssClass("is-")] public Color? Color { get; set; }
}
[HtmlTag("th")]
public class TableHeader : TableCell
{
}