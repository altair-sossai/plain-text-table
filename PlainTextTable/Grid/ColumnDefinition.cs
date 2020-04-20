using PlainTextTable.Enums;

namespace PlainTextTable.Grid
{
    public class ColumnDefinition
    {
        public ColumnDefinition()
        {
            WidthType = WidthType.Star;
            Width = 1;
        }

        public WidthType WidthType { get; set; }
        public int Width { get; set; }
    }
}