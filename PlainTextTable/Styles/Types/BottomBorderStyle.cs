using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class BottomBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                if (cellDefinition.Row == grid.RowDefinitions.Count - 1)
                {
                    border.Bottom = BorderDefinition.DefaultHorizontalSeparator;
                    border.BottomRight = BorderDefinition.DefaultHorizontalSeparator;
                    border.BottomLeft = BorderDefinition.DefaultHorizontalSeparator;
                }
            }
        }
    }
}