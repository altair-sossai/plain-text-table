using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class InsideBordersStyle : IBorderStyle
    {
        public InsideBordersStyle()
        {
            VerticalSeparator = BorderDefinition.DefaultVerticalSeparator;
            HorizontalSeparator = BorderDefinition.DefaultHorizontalSeparator;
            CrossSeparator = BorderDefinition.DefaultCrossSeparator;
        }

        public char VerticalSeparator { get; set; }
        public char HorizontalSeparator { get; set; }
        public char CrossSeparator { get; set; }

        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = VerticalSeparator;
                border.Top = HorizontalSeparator;
                border.Right = VerticalSeparator;
                border.Bottom = HorizontalSeparator;

                border.TopLeft = CrossSeparator;
                border.TopRight = CrossSeparator;
                border.BottomLeft = CrossSeparator;
                border.BottomRight = CrossSeparator;

                var firstRow = cellDefinition.Row == 0;
                var lastRow = cellDefinition.Row == grid.RowDefinitions.Count - 1;
                var firstColumn = cellDefinition.Column == 0;
                var lastColumn = cellDefinition.Column == grid.ColumnDefinitions.Count - 1;

                if (firstRow)
                    border.Top = null;

                if (lastRow)
                    border.Bottom = null;

                if (firstColumn)
                    border.Left = null;

                if (lastColumn)
                    border.Right = null;

                if (firstRow && firstColumn)
                    border.TopLeft = null;

                if (firstRow && lastColumn)
                    border.TopRight = null;

                if (lastRow && firstColumn)
                    border.BottomLeft = null;

                if (lastRow && lastColumn)
                    border.BottomRight = null;

                if (firstRow && !firstColumn)
                    border.TopLeft = VerticalSeparator;

                if (lastRow && !firstColumn)
                    border.BottomLeft = VerticalSeparator;

                if (firstColumn && !firstRow)
                    border.TopLeft = HorizontalSeparator;

                if (lastColumn && !firstRow)
                    border.TopRight = HorizontalSeparator;
            }
        }
    }
}