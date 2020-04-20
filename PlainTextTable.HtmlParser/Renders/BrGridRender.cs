using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Cells;
using PlainTextTable.HtmlParser.Columns;
using PlainTextTable.HtmlParser.Renders.Basic;
using PlainTextTable.HtmlParser.Rows;

namespace PlainTextTable.HtmlParser.Renders
{
    public class BrGridRender : BasicGridRender
    {
        public BrGridRender(string html)
            : this(LoadHtml(html))
        {
        }

        public BrGridRender(HtmlNode htmlNode)
            : base(htmlNode, ParseHtmlNode(htmlNode))
        {
        }

        private static GridDefinition ParseHtmlNode(HtmlNode htmlNode)
        {
            var grid = new GridDefinition();

            var rowDefinition = new BrRowDefinition(htmlNode);
            grid.RowDefinitions.Add(rowDefinition);

            var columnDefinition = new BrColumnDefinition(htmlNode);
            grid.ColumnDefinitions.Add(columnDefinition);

            var cellDefinition = new BrCellDefinition(htmlNode);
            grid.CellDefinitions.Add(cellDefinition);

            return grid;
        }
    }
}