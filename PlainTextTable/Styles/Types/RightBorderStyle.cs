using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class RightBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                if (cellDefinition.Column == grid.ColumnDefinitions.Count - 1)
                {
                    border.Right = BorderDefinition.DefaultVerticalSeparator;
                    border.TopRight = BorderDefinition.DefaultVerticalSeparator;
                    border.BottomRight = BorderDefinition.DefaultVerticalSeparator;
                }
            }
        }
    }
}