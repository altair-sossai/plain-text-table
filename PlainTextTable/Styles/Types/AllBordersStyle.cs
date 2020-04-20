using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class AllBordersStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                border.Left = BorderDefinition.DefaultVerticalSeparator;
                border.Top = BorderDefinition.DefaultHorizontalSeparator;
                border.Right = BorderDefinition.DefaultVerticalSeparator;
                border.Bottom = BorderDefinition.DefaultHorizontalSeparator;

                border.TopLeft = BorderDefinition.DefaultCrossSeparator;
                border.TopRight = BorderDefinition.DefaultCrossSeparator;
                border.BottomRight = BorderDefinition.DefaultCrossSeparator;
                border.BottomLeft = BorderDefinition.DefaultCrossSeparator;
            }
        }
    }
}