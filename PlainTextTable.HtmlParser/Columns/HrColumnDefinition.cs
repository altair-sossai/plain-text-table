using HtmlAgilityPack;
using PlainTextTable.Enums;
using PlainTextTable.HtmlParser.Columns.Basic;

namespace PlainTextTable.HtmlParser.Columns
{
    public class HrColumnDefinition : BasicColumnDefinition
    {
        public HrColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            WidthType = WidthType.Star;
            Width = 1;
        }
    }
}