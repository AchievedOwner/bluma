namespace Bluma.Test;
public class NavBarTest:TestBase<NavBar>
{
    [Fact]
    public void Test_NarBar()
    {
        var component = base.GetComponent(m => m.Add(p => p.BrandContent, b => b.Component<NavBarItem>().Content("component").Close()));

        component.Find(".navbar");
        var brand= component.Find(".navbar>div.navbar-brand");
        brand.Should().NotBeNull();
        component.Find(".navbar>div.navbar-menu");

        var item = brand.QuerySelector(".navbar-item");
        Assert.NotNull(item);
        var a = brand.QuerySelector(".navbar-burger");
        Assert.NotNull(a);
        a.Should().HaveTag("a").And.HaveAttribute("role", "button");
        a.QuerySelectorAll("span[aria-hidden]").Length.Should().Be(3);
    }
}
