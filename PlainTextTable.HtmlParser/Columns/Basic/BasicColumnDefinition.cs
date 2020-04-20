using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Extensions;

namespace PlainTextTable.HtmlParser.Columns.Basic
{
    public class BasicColumnDefinition : ColumnDefinition
    {
        public BasicColumnDefinition(HtmlNode htmlNode)
            : this(null, htmlNode)
        {
        }

        public BasicColumnDefinition(ColumnDefinition father, HtmlNode htmlNode)
        {
            WidthType = htmlNode.WidthType(father?.WidthType ?? WidthType);
            Width = htmlNode.Width(father?.Width ?? Width);
        }
    }
}