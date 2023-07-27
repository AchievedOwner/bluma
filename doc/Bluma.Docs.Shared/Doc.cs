using Markdig;
using Markdown.ColorCode;

namespace Bluma.Docs.Shared;
public class Doc
{
    internal Doc(MarkdownPipeline pipeline)
    {
        Pipeline = pipeline;
    }

    static Doc _instance;
    static object _lock = new object();
    public static Doc Instance
    {
        get
        {
            if ( _instance is null )
            {
                lock ( _lock )
                {
                    if ( _instance == null )
                    {
                        var pipeline = new MarkdownPipelineBuilder()
                            .UseAdvancedExtensions()
                            .UseColorCode()
                            .UseSoftlineBreakAsHardlineBreak()
                            .Build();

                        return new Doc(pipeline);
                    }
                }
            }
            return _instance;
        }
    }

    public MarkdownPipeline Pipeline { get; }

    public string From(string path)
    {
        using var stream= File.OpenText(path);
        var markdown = stream.ReadToEnd();
        return Content(markdown);
    }

    public string Content(string markdown)
    {
        return ToHtml(markdown);
    }

    string ToHtml(string markdown)
    {
        return Markdig.Markdown.ToHtml(markdown, Pipeline);
    }
}
