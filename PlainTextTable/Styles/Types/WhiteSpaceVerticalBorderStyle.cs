using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class WhiteSpaceVerticalBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = ' ';
                border.Top = null;
                border.Right = ' ';
                border.Bottom = null;

                border.TopLeft = ' ';
                border.TopRight = ' ';
                border.BottomLeft = ' ';
                border.BottomRight = ' ';
            }
        }
    }
}