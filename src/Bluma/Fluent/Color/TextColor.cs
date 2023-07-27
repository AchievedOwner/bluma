namespace Bluma.Fluent;
public interface IHasTextColor : IHasBasicColor<IHasTextColorDarkLight>
{

}

public interface IHasTextColorDarkLight : IHasDarkLightColor<IHasTextColor>
{

}

public interface IFluentTextColor: IHasTextColor, IHasTextColorDarkLight
{

}

internal class FluentTextColorProvider :FluentClassProvider<Color,string>, IFluentTextColor
{
    public IHasTextColor WithLight => WithDarkOrLight(false);
    public IHasTextColor WithDark => WithDarkOrLight(true);
    public IHasTextColorDarkLight Primary => WithColor(Color.Primary);
    public IHasTextColorDarkLight Info => WithColor(Color.Info);
    public IHasTextColorDarkLight Success => WithColor(Color.Success);
    public IHasTextColorDarkLight Warning => WithColor(Color.Warning);
    public IHasTextColorDarkLight Link => WithColor( Color.Link);
    public IHasTextColorDarkLight White => WithColor(Color.White);
    public IHasTextColorDarkLight Black => WithColor( Color.Black);

    protected override string? Format(Color key, string rule) => $"has-text-{key.GetCssClass()}-{rule}";

    protected override string? Format(Color key) => $"has-text-{key.GetCssClass()}";

    IHasTextColorDarkLight WithColor(Color color)
    {
        ChangeKey(color);
        return this;
    }

    IHasTextColor WithDarkOrLight(bool? darkOrLight)
    {
        if ( darkOrLight.HasValue )
        {
            AddRule(darkOrLight.Value ? "dark" : "light");
        }

        return this;
    }
}
