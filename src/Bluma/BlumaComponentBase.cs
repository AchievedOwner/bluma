using Microsoft.Extensions.Options;

namespace Bluma;

/// <summary>
/// An abstract class for bluma component.
/// </summary>
public abstract class BlumaComponentBase:BlazorComponentBase, IHasAdditionalClass, IHasAdditionalStyle
{
    [Inject]IOptions<BlumaOptions> Options { get; set; }

    /// <inheritdoc/>
    [Parameter] public string? AdditionalStyle { get; set; }
    /// <inheritdoc/>
    [Parameter] public string? AdditionalClass { get; set; }

}

/// <summary>
/// An abstract class for bluma component with ChildContent parameter.
/// </summary>
public abstract class BlumaChildContentComponentBase : BlumaComponentBase, IHasChildContent
{
    /// <inheritdoc/>
    [Parameter]public RenderFragment? ChildContent { get; set; }
}
