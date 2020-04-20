using System.Collections.Generic;
using PlainTextTable.Extensions;
using PlainTextTable.Grid;
using PlainTextTable.Styles;
using PlainTextTable.ValueObjects;

namespace PlainTextTable.Render
{
    public class GridRender
    {
        private readonly GridDefinition _grid;

        public GridRender(GridDefinition grid)
        {
            _grid = grid;
            Styles = new List<IBorderStyle>();
        }

        public List<IBorderStyle> Styles { get; }

        public string Render(int columns)
        {
            _grid.ApplyStyle(Styles);

            var tableInfo = new TableInfo(_grid, columns);
            var table = tableInfo.InitTable();

            foreach (var cellDefinition in _grid.CellDefinitions)
                table.DrawCell(cellDefinition, tableInfo.RowsBreaks, tableInfo.ColumnsBreaks);

            return table.Print(tableInfo.Rows, columns);
        }
    }
}