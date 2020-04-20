using HtmlAgilityPack;
using PlainTextTable.HtmlParser.Rows.Basic;

namespace PlainTextTable.HtmlParser.Rows
{
    public class TableRowDefinition : BasicRowDefinition
    {
        public TableRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}