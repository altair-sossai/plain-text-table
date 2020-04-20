using System;
using System.Collections.Generic;
using System.Linq;
using PlainTextTable.Enums;
using PlainTextTable.Grid;

namespace PlainTextTable.Extensions
{
    public static class GridDefinitionRowSizeExtensions
    {
        public static int[] RowsSize(this GridDefinition gridDefinition, int[] columnsSize)
        {
            var rowsSize = new int[gridDefinition.RowDefinitions.Count];

            gridDefinition.BorderSize(rowsSize);
            gridDefinition.ResizeFixedRows(rowsSize);
            gridDefinition.ResizeAutoRows(rowsSize, columnsSize);

            return rowsSize;
        }

        private static void BorderSize(this GridDefinition gridDefinition, IList<int> rowsSize)
        {
            for (var row = 0; row < rowsSize.Count; row++)
            {
                var cellDefinitions = gridDefinition.CellDefinitions.Where(w => w.Row == row).ToList();

                if (cellDefinitions.Any(cellDefinition => cellDefinition.Border.Top.HasValue))
                    rowsSize[row]++;

                if (row == rowsSize.Count - 1 && cellDefinitions.Any(cellDefinition => cellDefinition.Border.Bottom.HasValue))
                    rowsSize[row]++;
            }
        }

        private static void ResizeFixedRows(this GridDefinition gridDefinition, IList<int> rowsSize)
        {
            for (var row = 0; row < gridDefinition.RowDefinitions.Count; row++)
            {
                var rowDefinition = gridDefinition.RowDefinitions[row];
                if (rowDefinition.HeightType != HeightType.Fixed)
                    continue;

                rowsSize[row] += rowDefinition.Height;
            }
        }

        private static void ResizeAutoRows(this GridDefinition gridDefinition, IList<int> rowsSize, IList<int> columnsSize)
        {
            for (var row = 0; row < gridDefinition.RowDefinitions.Count; row++)
            {
                var rowDefinition = gridDefinition.RowDefinitions[row];
                if (rowDefinition.HeightType != HeightType.Auto)
                    continue;

                rowsSize[row] += gridDefinition.MaxLines(row, columnsSize);
            }
        }

        private static int MaxLines(this GridDefinition gridDefinition, int row, IList<int> columnsSize)
        {
            var maxLines = 1;

            foreach (var cellDefinition in gridDefinition.CellDefinitions)
            {
                if (string.IsNullOrEmpty(cellDefinition.Value) || cellDefinition.Row != row)
                    continue;

                var columnSize = columnsSize[cellDefinition.Column];

                if (cellDefinition.Border.Left.HasValue)
                    columnSize--;

                if (cellDefinition.Column == columnsSize.Count - 1 && cellDefinition.Border.Right.HasValue)
                    columnSize--;

                var keepWordsTogether = cellDefinition.HorizontalAlign != HorizontalAlign.Justified;
                var words = cellDefinition.Value.Wrap(columnSize, keepWordsTogether);
                var lines = words.Count;

                maxLines = Math.Max(maxLines, lines);
            }

            return maxLines;
        }
    }
}