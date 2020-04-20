using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class NoBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = null;
                border.Top = null;
                border.Right = null;
                border.Bottom = null;

                border.TopLeft = null;
                border.TopRight = null;
                border.BottomLeft = null;
                border.BottomRight = null;
            }
        }
    }
}