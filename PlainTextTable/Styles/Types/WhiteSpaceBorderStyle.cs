using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class WhiteSpaceBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = ' ';
                border.Top = ' ';
                border.Right = ' ';
                border.Bottom = ' ';

                border.TopLeft = ' ';
                border.TopRight = ' ';
                border.BottomLeft = ' ';
                border.BottomRight = ' ';
            }
        }
    }
}