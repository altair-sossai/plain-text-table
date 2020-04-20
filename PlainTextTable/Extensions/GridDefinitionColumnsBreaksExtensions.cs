using PlainTextTable.ValueObjects;

namespace PlainTextTable.Extensions
{
    public static class GridDefinitionColumnsBreaksExtensions
    {
        public static Interval[] ColumnsBreaks(this int[] columnsSize)
        {
            var breaks = new Interval[columnsSize.Length];

            for (var column = 0; column < columnsSize.Length; column++)
            {
                var interval = breaks[column] = new Interval();

                interval.Start = column == 0 ? 0 : breaks[column - 1].End;
                interval.End = interval.Start + columnsSize[column];

                if (column == columnsSize.Length - 1)
                    interval.End--;
            }

            return breaks;
        }
    }
}