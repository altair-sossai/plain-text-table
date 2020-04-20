using System;
using System.Collections.Generic;
using System.Text;
using PlainTextTable.Grid;
using PlainTextTable.Render;
using PlainTextTable.ValueObjects;

namespace PlainTextTable.Extensions
{
    public static class TableExtensions
    {
        public static void Init(this char[,] table, int rows, int columns, char value = ' ')
        {
            for (var row = 0; row < rows; row++)
            for (var column = 0; column < columns; column++)
                table[row, column] = value;
        }

        public static string Print(this char[,] table, int rows, int columns)
        {
            var stringBuilder = new StringBuilder();

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                    stringBuilder.Append(table[row, column]);

                if (row != rows - 1)
                    stringBuilder.AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());

            return stringBuilder.ToString();
        }

        public static void DrawCell(this char[,] table, CellDefinition cellDefinition, IReadOnlyList<Interval> rowsBreaks, IReadOnlyList<Interval> columnsBreaks)
        {
            var columnInterval = columnsBreaks[cellDefinition.Column];
            var rowInterval = rowsBreaks[cellDefinition.Row];

            var cellRender = new CellRender(cellDefinition);
            cellRender.Draw(table, rowInterval.Start, rowInterval.End, columnInterval.Start, columnInterval.End);
        }
    }
}