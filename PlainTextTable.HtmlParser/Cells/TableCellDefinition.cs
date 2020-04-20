using HtmlAgilityPack;
using PlainTextTable.HtmlParser.Cells.Basic;

namespace PlainTextTable.HtmlParser.Cells
{
    public class TableCellDefinition : BasicCellDefinition
    {
        public TableCellDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}