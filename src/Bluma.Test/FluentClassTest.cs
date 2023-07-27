namespace Bluma.Test;
public class FluentClassTest
{
    [Fact]
    public void Test_BreakPoint_FluentClass()
    {
        Class.BreakPoint.OnTablet.Create().Should().Equal("is-tablet");
        Class.BreakPoint.OnWideScreen.OnMobile.Should().Equals("is-widescreen is-mobile");
        Class.BreakPoint.OnFullHD.OnDesktop.OnMobile.OnFullHD.Should().Equals("is-fullhd is-desktop is-mobile");
    }
}
