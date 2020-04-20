using HtmlAgilityPack;
using PlainTextTable.HtmlParser.Cells.Basic;
using PlainTextTable.HtmlParser.Extensions;

namespace PlainTextTable.HtmlParser.Cells
{
    public class ParagraphCellDefinition : BasicCellDefinition
    {
        public ParagraphCellDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            Border.Left = htmlNode.BorderLeft(htmlNode.Edge(htmlNode.Border(null)));
            Border.Top = htmlNode.BorderTop(htmlNode.Edge(htmlNode.Border(null)));
            Border.Right = htmlNode.BorderRight(htmlNode.Edge(htmlNode.Border(null)));
            Border.Bottom = htmlNode.BorderBottom(htmlNode.Edge(htmlNode.Border(null)));

            Border.TopLeft = htmlNode.BorderTopLeft(htmlNode.Corner(htmlNode.Border(null)));
            Border.TopRight = htmlNode.BorderTopRight(htmlNode.Corner(htmlNode.Border(null)));
            Border.BottomRight = htmlNode.BorderBottomRight(htmlNode.Corner(htmlNode.Border(null)));
            Border.BottomLeft = htmlNode.BorderBottomLeft(htmlNode.Corner(htmlNode.Border(null)));
        }
    }
}