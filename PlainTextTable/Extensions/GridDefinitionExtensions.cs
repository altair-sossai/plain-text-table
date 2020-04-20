using System.Collections.Generic;
using System.Linq;
using PlainTextTable.Enums;
using PlainTextTable.Grid;
using PlainTextTable.Styles;

namespace PlainTextTable.Extensions
{
    public static class GridDefinitionExtensions
    {
        public static void ApplyStyle(this GridDefinition grid, IEnumerable<IBorderStyle> styles)
        {
            foreach (var style in styles ?? new List<IBorderStyle>())
                ApplyStyle(grid, style);
        }

        private static void ApplyStyle(this GridDefinition grid, IBorderStyle borderStyle)
        {
            borderStyle?.Apply(grid);
        }

        public static GridDefinition AddCell(this GridDefinition grid, string value, int? row = null, int? column = null, HorizontalAlign horizontalAlign = HorizontalAlign.Left, VerticalAlign verticalAlign = VerticalAlign.Top)
        {
            var cells = grid.CellDefinitions;
            var columns = grid.ColumnDefinitions;

            if (row == null || column == null)
            {
                var lastCell = cells
                    .OrderByDescending(o => o.Row)
                    .ThenByDescending(tb => tb.Column)
                    .FirstOrDefault();

                if (lastCell != null)
                {
                    row ??= lastCell.Column == columns.Count - 1 ? lastCell.Row + 1 : lastCell.Row;
                    column ??= lastCell.Column == columns.Count - 1 ? 0 : lastCell.Column + 1;
                }
            }

            cells.Add(new CellDefinition
            {
                Row = row ?? 0,
                Column = column ?? 0,
                HorizontalAlign = horizontalAlign,
                VerticalAlign = verticalAlign,
                Value = value
            });

            return grid;
        }
    }
}