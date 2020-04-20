using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Cells;
using PlainTextTable.HtmlParser.Columns;
using PlainTextTable.HtmlParser.Extensions;
using PlainTextTable.HtmlParser.Renders.Basic;
using PlainTextTable.HtmlParser.Rows;

namespace PlainTextTable.HtmlParser.Renders
{
    public class TableGridRender : BasicGridRender
    {
        public TableGridRender(string html)
            : this(LoadHtml(html))
        {
        }

        public TableGridRender(HtmlNode htmlNode)
            : base(htmlNode, ParseHtmlNode(htmlNode))
        {
        }

        private static GridDefinition ParseHtmlNode(HtmlNode htmlNode)
        {
            var grid = new GridDefinition();

            AddRowDefinitions(htmlNode, grid);
            AddColumnDefinitions(htmlNode, grid);
            AddCellDefinitions(htmlNode, grid);

            return grid;
        }

        private static void AddRowDefinitions(HtmlNode htmlNode, GridDefinition grid)
        {
            var table = new TableRowDefinition(htmlNode);

            foreach (var node in htmlNode.Nodes("tr"))
            {
                var tr = new TdRowDefinition(table, node);
                grid.RowDefinitions.Add(tr);
            }
        }

        private static void AddColumnDefinitions(HtmlNode htmlNode, GridDefinition grid)
        {
            var table = new TableColumnDefinition(htmlNode);
            var tr = htmlNode.FirstOrDefault("tr");
            if (tr == null)
                return;

            foreach (var node in tr.Nodes("td"))
            {
                var td = new TdColumnDefinition(table, node);
                grid.ColumnDefinitions.Add(td);
            }
        }

        private static void AddCellDefinitions(HtmlNode htmlNode, GridDefinition grid)
        {
            var table = new TableCellDefinition(htmlNode);
            var rows = htmlNode.Nodes("tr");

            for (var row = 0; row < rows.Count; row++)
            {
                var columns = rows[row].Nodes("td");
                var tr = new TrCellDefinition(table, rows[row]);

                for (var column = 0; column < columns.Count; column++) 
                    grid.CellDefinitions.Add(new TdCellDefinition(tr, columns[column], row, column));
            }
        }
    }
}