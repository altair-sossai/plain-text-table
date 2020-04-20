namespace PlainTextTable.Grid
{
    public class BorderDefinition
    {
        public const char DefaultVerticalSeparator = '|';
        public const char DefaultHorizontalSeparator = '-';
        public const char DefaultCrossSeparator = '+';
        public const char DefaultLeft = DefaultVerticalSeparator;
        public const char DefaultTop = DefaultHorizontalSeparator;
        public const char DefaultRight = DefaultVerticalSeparator;
        public const char DefaultBottom = DefaultHorizontalSeparator;
        public const char DefaultTopLeft = DefaultCrossSeparator;
        public const char DefaultTopRight = DefaultCrossSeparator;
        public const char DefaultBottomRight = DefaultCrossSeparator;
        public const char DefaultBottomLeft = DefaultCrossSeparator;

        public BorderDefinition()
        {
            Left = DefaultLeft;
            Top = DefaultTop;
            Right = DefaultRight;
            Bottom = DefaultBottom;
            TopLeft = DefaultTopLeft;
            TopRight = DefaultTopRight;
            BottomRight = DefaultBottomRight;
            BottomLeft = DefaultBottomLeft;
        }

        public char? Left { get; set; }
        public char? Top { get; set; }
        public char? Right { get; set; }
        public char? Bottom { get; set; }
        public char? TopLeft { get; set; }
        public char? TopRight { get; set; }
        public char? BottomRight { get; set; }
        public char? BottomLeft { get; set; }

        public static BorderDefinition Empty => new BorderDefinition
        {
            Left = null,
            Top = null,
            Right = null,
            Bottom = null,
            TopLeft = null,
            TopRight = null,
            BottomRight = null,
            BottomLeft = null
        };
    }
}