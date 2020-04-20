using PlainTextTable.Grid;

namespace PlainTextTable.Styles.Types
{
    public class OutsideBordersStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            var styles = new IBorderStyle[]
            {
                new LeftBorderStyle(),
                new RightBorderStyle(),
                new TopBorderStyle(),
                new BottomBorderStyle()
            };

            foreach (var style in styles)
                style.Apply(grid);
        }
    }
}