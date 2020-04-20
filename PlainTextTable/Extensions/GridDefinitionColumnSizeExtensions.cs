using System;
using System.Collections.Generic;
using System.Linq;
using PlainTextTable.Enums;
using PlainTextTable.Grid;

namespace PlainTextTable.Extensions
{
    public static class GridDefinitionColumnSizeExtensions
    {
        public static int[] ColumnsSize(this GridDefinition gridDefinition, int width)
        {
            var columnsSize = new int[gridDefinition.ColumnDefinitions.Count];

            gridDefinition.BorderSize(columnsSize);
            gridDefinition.ResizeFixedColumns(columnsSize);
            gridDefinition.ResizeAutoColumns(columnsSize);
            gridDefinition.ResizeStarColumns(columnsSize, width);
            FillColumns(columnsSize, width);

            return columnsSize;
        }

        private static void BorderSize(this GridDefinition gridDefinition, IList<int> columnsSize)
        {
            for (var column = 0; column < columnsSize.Count; column++)
            {
                var cellDefinitions = gridDefinition.CellDefinitions.Where(w => w.Column == column).ToList();

                if (cellDefinitions.Any(cellDefinition => cellDefinition.Border.Left.HasValue))
                    columnsSize[column]++;

                if (column == columnsSize.Count - 1 && cellDefinitions.Any(cellDefinition => cellDefinition.Border.Right.HasValue))
                    columnsSize[column]++;
            }
        }

        private static void ResizeFixedColumns(this GridDefinition gridDefinition, IList<int> columnsSize)
        {
            for (var column = 0; column < gridDefinition.ColumnDefinitions.Count; column++)
            {
                var columnDefinition = gridDefinition.ColumnDefinitions[column];
                if (columnDefinition.WidthType != WidthType.Fixed)
                    continue;

                columnsSize[column] += columnDefinition.Width;
            }
        }

        private static void ResizeAutoColumns(this GridDefinition gridDefinition, IList<int> columnsSize)
        {
            for (var column = 0; column < gridDefinition.ColumnDefinitions.Count; column++)
            {
                var columnDefinition = gridDefinition.ColumnDefinitions[column];
                if (columnDefinition.WidthType != WidthType.Auto)
                    continue;

                columnsSize[column] += gridDefinition.MaxValueLength(column);
            }
        }

        private static void ResizeStarColumns(this GridDefinition gridDefinition, IList<int> columnsSize, int width)
        {
            var remaining = width - columnsSize.Sum();
            if (remaining <= 0)
                return;

            var numberOfStars = gridDefinition.NumberOfStars();
            if (numberOfStars == 0)
                return;

            for (var column = 0; column < gridDefinition.ColumnDefinitions.Count; column++)
            {
                var columnDefinition = gridDefinition.ColumnDefinitions[column];
                if (columnDefinition.WidthType != WidthType.Star)
                    continue;

                columnsSize[column] += (int) (columnDefinition.Width / (decimal) numberOfStars * remaining);
            }
        }

        private static void FillColumns(IList<int> columnsSize, int width)
        {
            if (columnsSize.Count == 0)
                return;

            var currentSize = columnsSize.Sum();

            for (var column = 0; currentSize > width; column = column == columnsSize.Count - 1 ? 0 : column + 1)
            {
                if (columnsSize[column] == 1)
                    continue;

                columnsSize[column]--;
                currentSize--;
            }

            for (var column = 0; currentSize < width; column = column == columnsSize.Count - 1 ? 0 : column + 1)
            {
                columnsSize[column]++;
                currentSize++;
            }
        }

        private static int MaxValueLength(this GridDefinition gridDefinition, int column)
        {
            var length = 0;

            foreach (var cellDefinition in gridDefinition.CellDefinitions)
            {
                if (string.IsNullOrEmpty(cellDefinition.Value) || cellDefinition.Column != column)
                    continue;

                length = Math.Max(length, cellDefinition.Value.Length);
            }

            return length;
        }

        private static int NumberOfStars(this GridDefinition gridDefinition)
        {
            var numberOfStars = 0;

            foreach (var columnDefinition in gridDefinition.ColumnDefinitions)
            {
                if (columnDefinition.WidthType != WidthType.Star)
                    continue;

                numberOfStars += columnDefinition.Width;
            }

            return numberOfStars;
        }
    }
}