using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Extensions;
using PlainTextTable.Render;

namespace PlainTextTable.HtmlParser.Renders.Basic
{
    public abstract class BasicGridRender : GridRender
    {
        protected BasicGridRender(HtmlNode htmlNode, GridDefinition grid)
            : base(grid)
        {
            Styles.AddRange(htmlNode.BorderStyles());
        }

        protected static HtmlNode LoadHtml(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            return htmlDocument.DocumentNode.FirstChild;
        }
    }
}