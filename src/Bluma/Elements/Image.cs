namespace Bluma;

/// <summary>
/// A container for responsive images.
/// </summary>
[CssClass("image")]
[HtmlTag("figure")]
public class Image:BlumaChildContentComponentBase
{

    /// <summary>
    /// The fixed square size.
    /// </summary>
    [Parameter]public ImageSize? Size { get; set; }
    /// <summary>
    /// The ratio for responsive.
    /// </summary>
    [Parameter]public ImageRatio? Ratio { get; set; }

    /// <summary>
    /// Round the image.
    /// </summary>
    [Parameter][CssClass("is-rounded")]public bool Rounded { get; set; }
}

/// <summary>
/// The size of image.
/// </summary>
[CssClass("is-")]
public enum ImageSize
{
    /// <summary>
    /// 16*16
    /// </summary>
    [CssClass("16x16")]Is16x16,
    /// <summary>
    /// 32*32
    /// </summary>
    [CssClass("32x32")]Is32x32,
    /// <summary>
    /// 48*48
    /// </summary>
    [CssClass("48x48")]Is48x48,
    /// <summary>
    /// 64*64
    /// </summary>
    [CssClass("64x64")]Is64x64,
    /// <summary>
    /// 96*96
    /// </summary>
    [CssClass("96x96")]Is96x96,
    /// <summary>
    /// 128*128
    /// </summary>
    [CssClass("128x128")] Is128x128
}

/// <summary>
/// The ratio of image.
/// </summary>
[CssClass("is-")]
public enum ImageRatio
{
    /// <summary>
    /// 1:1
    /// </summary>
    [CssClass("1by1")]Is1by1,
    /// <summary>
    /// 5:4
    /// </summary>
    [CssClass("5by4")]Is5by4,
    /// <summary>
    /// 4:3
    /// </summary>
    [CssClass("4by3")]Is4by3,
    /// <summary>
    /// 3:2
    /// </summary>
    [CssClass("3by2")]Is3by2,
    /// <summary>
    /// 5:3
    /// </summary>
    [CssClass("5by3")]Is5by3,
    /// <summary>
    /// 16:9
    /// </summary>
    [CssClass("16by9")]Is16by9,
    /// <summary>
    /// 2:1
    /// </summary>
    [CssClass("2by1")]Is2by1,
    /// <summary>
    /// 3:1
    /// </summary>
    [CssClass("3by1")]Is3by1,
    /// <summary>
    /// 4:5
    /// </summary>
    [CssClass("4by5")]Is4by5,
    /// <summary>
    /// 3:4
    /// </summary>
    [CssClass("3by4")]Is3by4,
    /// <summary>
    /// 2:3
    /// </summary>
    [CssClass("2by3")]Is2by3,
    /// <summary>
    /// 3:5
    /// </summary>
    [CssClass("3by5")]Is3by5,
    /// <summary>
    /// 9:16
    /// </summary>
    [CssClass("9by16")]Is9by16,
    /// <summary>
    /// 1:2
    /// </summary>
    [CssClass("1by2")]Is1by2,
    /// <summary>
    /// 1:3
    /// </summary>
    [CssClass("1by3")] Is1by3
}