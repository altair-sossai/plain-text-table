using HtmlAgilityPack;
using PlainTextTable.Enums;
using PlainTextTable.HtmlParser.Columns.Basic;

namespace PlainTextTable.HtmlParser.Columns
{
    public class BrColumnDefinition : BasicColumnDefinition
    {
        public BrColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            WidthType = WidthType.Star;
            Width = 1;
        }
    }
}