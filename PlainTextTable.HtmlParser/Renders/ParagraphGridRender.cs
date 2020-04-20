using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Cells;
using PlainTextTable.HtmlParser.Columns;
using PlainTextTable.HtmlParser.Renders.Basic;
using PlainTextTable.HtmlParser.Rows;

namespace PlainTextTable.HtmlParser.Renders
{
    public class ParagraphGridRender : BasicGridRender
    {
        public ParagraphGridRender(string html)
            : this(LoadHtml(html))
        {
        }

        public ParagraphGridRender(HtmlNode htmlNode)
            : base(htmlNode, ParseHtmlNode(htmlNode))
        {
        }

        private static GridDefinition ParseHtmlNode(HtmlNode htmlNode)
        {
            var grid = new GridDefinition();

            var rowDefinition = new ParagraphRowDefinition(htmlNode);
            grid.RowDefinitions.Add(rowDefinition);

            var columnDefinition = new ParagraphColumnDefinition(htmlNode);
            grid.ColumnDefinitions.Add(columnDefinition);

            var cellDefinition = new ParagraphCellDefinition(htmlNode);
            grid.CellDefinitions.Add(cellDefinition);

            return grid;
        }
    }
}