using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class TopBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                if (cellDefinition.Row == 0)
                {
                    border.Top = BorderDefinition.DefaultHorizontalSeparator;
                    border.TopRight = BorderDefinition.DefaultHorizontalSeparator;
                    border.TopLeft = BorderDefinition.DefaultHorizontalSeparator;
                }
            }
        }
    }
}