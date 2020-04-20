using System;
using PlainTextTable.Enums;

namespace PlainTextTable.Grid
{
    public class CellDefinition
    {
        private string _value;

        public CellDefinition()
        {
            Row = 0;
            Column = 0;
            Border = new BorderDefinition();
            HorizontalAlign = HorizontalAlign.Justified;
            VerticalAlign = VerticalAlign.Top;
            Value = string.Empty;
            PadValue = null;
        }

        public int Row { get; set; }
        public int Column { get; set; }
        public BorderDefinition Border { get; set; }
        public HorizontalAlign HorizontalAlign { get; set; }
        public VerticalAlign VerticalAlign { get; set; }

        public string Value
        {
            get => _value;
            set => _value = value?.Trim().Trim(Environment.NewLine.ToCharArray()).Replace(Environment.NewLine, " ");
        }

        public char? PadValue { get; set; }
    }
}