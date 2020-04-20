using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class InsideHorizontalBorderStyle : IBorderStyle
    {
        public InsideHorizontalBorderStyle()
        {
            HorizontalSeparator = BorderDefinition.DefaultHorizontalSeparator;
        }

        public char HorizontalSeparator { get; set; }

        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = null;
                border.Top = HorizontalSeparator;
                border.Right = null;
                border.Bottom = HorizontalSeparator;

                border.TopLeft = HorizontalSeparator;
                border.TopRight = HorizontalSeparator;
                border.BottomLeft = HorizontalSeparator;
                border.BottomRight = HorizontalSeparator;

                if (cellDefinition.Row == 0)
                {
                    border.Top = null;
                    border.TopRight = null;
                    border.TopLeft = null;
                }

                if (cellDefinition.Row == grid.RowDefinitions.Count - 1)
                {
                    border.Bottom = null;
                    border.BottomLeft = null;
                    border.BottomRight = null;
                }
            }
        }
    }
}