namespace Bluma.Parameters;

/// <summary>
/// Define color parameter.
/// </summary>
public interface IHasColor
{
    /// <summary>
    /// Sets the color.
    /// </summary>
    [CssClass("is-")]public Color? Color { get; set; }
}
