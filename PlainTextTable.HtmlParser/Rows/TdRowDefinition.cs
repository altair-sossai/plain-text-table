using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Rows.Basic;

namespace PlainTextTable.HtmlParser.Rows
{
    public class TdRowDefinition : BasicRowDefinition
    {
        public TdRowDefinition(RowDefinition father, HtmlNode htmlNode)
            : base(father, htmlNode)
        {
        }
    }
}