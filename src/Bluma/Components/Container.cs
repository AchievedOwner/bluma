namespace Bluma;

[CssClass("container")]
public class Container:BlumaChildContentComponentBase
{
    [Parameter][CssClass("is-")]public ContainerBreakPoint? BreakPoint { get; set; }
}

public enum ContainerBreakPoint
{
    Fluid,
    WideScreen,
    FullHD,
    [CssClass("max-desketop")]MaxDesketop,
    [CssClass("max-widescreen")]MaxWideScreen
}