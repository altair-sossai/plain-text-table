using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Columns.Basic;

namespace PlainTextTable.HtmlParser.Columns
{
    public class TdColumnDefinition : BasicColumnDefinition
    {
        public TdColumnDefinition(ColumnDefinition father, HtmlNode htmlNode)
            : base(father, htmlNode)
        {
        }
    }
}