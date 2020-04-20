using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class InsideVerticalBorderStyle : IBorderStyle
    {
        public InsideVerticalBorderStyle()
        {
            VerticalSeparator = BorderDefinition.DefaultVerticalSeparator;
        }

        public char VerticalSeparator { get; set; }

        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = VerticalSeparator;
                border.Top = null;
                border.Right = VerticalSeparator;
                border.Bottom = null;

                border.TopLeft = VerticalSeparator;
                border.TopRight = VerticalSeparator;
                border.BottomLeft = VerticalSeparator;
                border.BottomRight = VerticalSeparator;

                if (cellDefinition.Column == 0)
                {
                    border.Left = null;
                    border.TopLeft = null;
                    border.BottomLeft = null;
                }

                if (cellDefinition.Column == grid.ColumnDefinitions.Count - 1)
                {
                    border.Right = null;
                    border.TopRight = null;
                    border.BottomRight = null;
                }
            }
        }
    }
}