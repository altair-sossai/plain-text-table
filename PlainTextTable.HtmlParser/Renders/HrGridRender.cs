using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Cells;
using PlainTextTable.HtmlParser.Columns;
using PlainTextTable.HtmlParser.Renders.Basic;
using PlainTextTable.HtmlParser.Rows;

namespace PlainTextTable.HtmlParser.Renders
{
    public class HrGridRender : BasicGridRender
    {
        public HrGridRender(string html)
            : this(LoadHtml(html))
        {
        }

        public HrGridRender(HtmlNode htmlNode)
            : base(htmlNode, ParseHtmlNode(htmlNode))
        {
        }

        private static GridDefinition ParseHtmlNode(HtmlNode htmlNode)
        {
            var grid = new GridDefinition();

            var rowDefinition = new HrRowDefinition(htmlNode);
            grid.RowDefinitions.Add(rowDefinition);

            var columnDefinition = new HrColumnDefinition(htmlNode);
            grid.ColumnDefinitions.Add(columnDefinition);

            var cellDefinition = new HrCellDefinition(htmlNode);
            grid.CellDefinitions.Add(cellDefinition);

            return grid;
        }
    }
}