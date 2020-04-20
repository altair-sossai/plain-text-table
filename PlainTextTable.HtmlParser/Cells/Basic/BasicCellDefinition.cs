using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Extensions;

namespace PlainTextTable.HtmlParser.Cells.Basic
{
    public abstract class BasicCellDefinition : CellDefinition
    {
        protected BasicCellDefinition(HtmlNode htmlNode)
            : this(null, htmlNode)
        {
        }

        protected BasicCellDefinition(CellDefinition father, HtmlNode htmlNode)
        {
            Border.Left = htmlNode.BorderLeft(htmlNode.Edge(htmlNode.Border(father?.Border?.Left ?? Border.Left)));
            Border.Top = htmlNode.BorderTop(htmlNode.Edge(htmlNode.Border(father?.Border?.Top ?? Border.Top)));
            Border.Right = htmlNode.BorderRight(htmlNode.Edge(htmlNode.Border(father?.Border?.Right ?? Border.Right)));
            Border.Bottom = htmlNode.BorderBottom(htmlNode.Edge(htmlNode.Border(father?.Border?.Bottom ?? Border.Bottom)));

            Border.TopLeft = htmlNode.BorderTopLeft(htmlNode.Corner(htmlNode.Border(father?.Border?.TopLeft ?? Border.TopLeft)));
            Border.TopRight = htmlNode.BorderTopRight(htmlNode.Corner(htmlNode.Border(father?.Border?.TopRight ?? Border.TopRight)));
            Border.BottomRight = htmlNode.BorderBottomRight(htmlNode.Corner(htmlNode.Border(father?.Border?.BottomRight ?? Border.BottomRight)));
            Border.BottomLeft = htmlNode.BorderBottomLeft(htmlNode.Corner(htmlNode.Border(father?.Border?.BottomLeft ?? Border.BottomLeft)));

            HorizontalAlign = htmlNode.HorizontalAlign(father?.HorizontalAlign ?? HorizontalAlign);
            VerticalAlign = htmlNode.VerticalAlign(father?.VerticalAlign ?? VerticalAlign);

            Value = htmlNode.InnerText;
            PadValue = htmlNode.PadValue(father?.PadValue ?? PadValue);
        }
    }
}