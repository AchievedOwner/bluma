namespace Bluma.Test;
public class ColumnTest:TestBase<Columns>
{
    [Fact(DisplayName ="Column - Test 1 column in columns")]
    public void Test_Columns_Render()
    {
        var columns = GetComponent(m => m.AddChildContent(b => b.CreateComponent<Column>(0, "column")));

        columns.Should().HaveClass("columns");
        columns.Find(".columns>div").Should().HaveClass("column").And.HaveChildMarkup("column");
    }

    [Fact]
    public void Test_Fluent_Column_Size()
    {
        var columns = GetComponent(m => m.AddChildContent(b => b.CreateComponent<Column>(0, "column", new
        {
            Size = Col.Size.Is3.Is3of4.OnMobile
        })));
        columns.MarkupMatches(@"
<div class=""columns"">
    <div class=""column is-3 is-three-quarters-mobile"">column</div>
</div>
");

        columns.Find(".columns>div").Should().HaveClass("column")
            .And.HaveClass("is-3")
            .And.HaveClass("is-three-quarters-mobile");
    }
}
