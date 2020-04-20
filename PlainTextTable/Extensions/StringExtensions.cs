using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlainTextTable.Enums;

namespace PlainTextTable.Extensions
{
    public static class StringExtensions
    {
        public static bool IsDigitsOnly(this string value)
        {
            return !string.IsNullOrEmpty(value) && value.All(char.IsDigit);
        }

        public static List<string> Wrap(this string value, int maximumLineLength, bool keepWordsTogether)
        {
            if (string.IsNullOrEmpty(value) || maximumLineLength <= 0)
                return new List<string>();

            return keepWordsTogether
                ? SplitByLengthAndKeepWordsTogether(value, maximumLineLength)
                : SplitByLength(value, maximumLineLength);
        }

        private static List<string> SplitByLengthAndKeepWordsTogether(string value, int maximumLineLength)
        {
            var words = new List<string>();

            foreach (var word in value.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                words.AddRange(SplitByLength(word, maximumLineLength));

            var lines = new List<string>();
            var currentLine = new StringBuilder();

            foreach (var word in words)
            {
                if (currentLine.Length == 0)
                {
                    currentLine.Append(word);
                    continue;
                }

                var lineLength = currentLine.Length + word.Length + 1;

                if (lineLength > maximumLineLength)
                {
                    lines.Add(currentLine.ToString().Trim());
                    currentLine.Clear();
                    currentLine.Append(word);
                }
                else
                    currentLine.Append($" {word}");
            }

            if (currentLine.Length != 0)
                lines.Add(currentLine.ToString().Trim());

            return lines;
        }

        private static List<string> SplitByLength(string value, int maximumLineLength)
        {
            var lines = new List<string>();
            var currentLine = new StringBuilder();

            foreach (var currentChar in value)
            {
                if (currentLine.Length == maximumLineLength)
                {
                    lines.Add(currentLine.ToString().Trim());
                    currentLine.Clear();
                }

                if (currentLine.Length == 0 && currentChar == ' ')
                    continue;

                currentLine.Append(currentChar);
            }

            if (currentLine.Length != 0)
                lines.Add(currentLine.ToString().Trim());

            return lines;
        }

        public static string Align(this string source, int columnSize, HorizontalAlign horizontalAlign, char padValue)
        {
            return horizontalAlign switch
            {
                HorizontalAlign.Center => source.PadCenter(columnSize, padValue),
                HorizontalAlign.Right => source.PadLeft(columnSize, padValue),
                _ => source.PadRight(columnSize, padValue)
            };
        }

        private static string PadCenter(this string source, int length, char padValue)
        {
            var spaces = length - source.Length;
            var padLeft = spaces / 2 + source.Length;

            return source.PadLeft(padLeft, padValue).PadRight(length, padValue);
        }

        public static List<string> Align(this List<string> lines, int numberOfRows, VerticalAlign verticalAlign)
        {
            return verticalAlign switch
            {
                VerticalAlign.Middle => lines.AlignMiddle(numberOfRows),
                VerticalAlign.Bottom => lines.AlignBottom(numberOfRows),
                _ => lines
            };
        }

        private static List<string> AlignMiddle(this List<string> lines, int numberOfRows)
        {
            for (var toggle = true; lines.Count < numberOfRows; toggle = !toggle)
                if (toggle)
                    lines.Insert(0, string.Empty);
                else
                    lines.Add(string.Empty);

            return lines;
        }

        private static List<string> AlignBottom(this List<string> lines, int numberOfRows)
        {
            while (lines.Count < numberOfRows)
                lines.Insert(0, string.Empty);

            return lines;
        }
    }
}