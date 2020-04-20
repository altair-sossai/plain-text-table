using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Cells.Basic;

namespace PlainTextTable.HtmlParser.Cells
{
    public class TdCellDefinition : BasicCellDefinition
    {
        public TdCellDefinition(CellDefinition father, HtmlNode htmlNode, int row, int column)
            : base(father, htmlNode)
        {
            Row = row;
            Column = column;
        }
    }
}