using HtmlAgilityPack;
using PlainTextTable.HtmlParser.Columns.Basic;

namespace PlainTextTable.HtmlParser.Columns
{
    public class TableColumnDefinition : BasicColumnDefinition
    {
        public TableColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}