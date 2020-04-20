using PlainTextTable.Enums;

namespace PlainTextTable.Grid
{
    public class RowDefinition
    {
        public RowDefinition()
        {
            HeightType = HeightType.Auto;
            Height = 1;
        }

        public HeightType HeightType { get; set; }
        public int Height { get; set; }
    }
}