using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class LeftBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                if (cellDefinition.Column == 0)
                {
                    border.Left = BorderDefinition.DefaultVerticalSeparator;
                    border.TopLeft = BorderDefinition.DefaultVerticalSeparator;
                    border.BottomLeft = BorderDefinition.DefaultVerticalSeparator;
                }
            }
        }
    }
}