using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Cells.Basic;

namespace PlainTextTable.HtmlParser.Cells
{
    public class TrCellDefinition : BasicCellDefinition
    {
        public TrCellDefinition(CellDefinition father, HtmlNode htmlNode)
            : base(father, htmlNode)
        {
        }
    }
}