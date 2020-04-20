using PlainTextTable.ValueObjects;

namespace PlainTextTable.Extensions
{
    public static class GridDefinitionRowsBreaksExtensions
    {
        public static Interval[] RowsBreaks(this int[] rowsSize)
        {
            var breaks = new Interval[rowsSize.Length];

            for (var row = 0; row < rowsSize.Length; row++)
            {
                var interval = breaks[row] = new Interval();

                interval.Start = row == 0 ? 0 : breaks[row - 1].End;
                interval.End = interval.Start + rowsSize[row];

                if (row == rowsSize.Length - 1)
                    interval.End--;
            }

            return breaks;
        }
    }
}