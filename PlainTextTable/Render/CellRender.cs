using PlainTextTable.Enums;
using PlainTextTable.Extensions;
using PlainTextTable.Grid;

namespace PlainTextTable.Render
{
    public class CellRender
    {
        private readonly CellDefinition _cellDefinition;

        public CellRender(CellDefinition cellDefinition)
        {
            _cellDefinition = cellDefinition;
        }

        private BorderDefinition Border => _cellDefinition.Border;

        public void Draw(char[,] table, int startRow, int endRow, int startColumn, int endColumn)
        {
            DrawCorners(table, startRow, endRow, startColumn, endColumn);
            DrawEdges(table, startRow, endRow, startColumn, endColumn);
            DrawBody(table, startRow, endRow, startColumn, endColumn);
        }

        private void DrawCorners(char[,] table, int startRow, int endRow, int startColumn, int endColumn)
        {
            if (Border.TopLeft.HasValue)
                table[startRow, startColumn] = Border.TopLeft.Value;

            if (Border.TopRight.HasValue)
                table[startRow, endColumn] = Border.TopRight.Value;

            if (Border.BottomLeft.HasValue)
                table[endRow, startColumn] = Border.BottomLeft.Value;

            if (Border.BottomRight.HasValue)
                table[endRow, endColumn] = Border.BottomRight.Value;
        }

        private void DrawEdges(char[,] table, int startRow, int endRow, int startColumn, int endColumn)
        {
            for (var column = startColumn + 1; Border.Top.HasValue && column < endColumn; column++)
                table[startRow, column] = Border.Top.Value;

            for (var column = startColumn + 1; Border.Bottom.HasValue && column < endColumn; column++)
                table[endRow, column] = Border.Bottom.Value;

            for (var row = startRow + 1; Border.Left.HasValue && row < endRow; row++)
                table[row, startColumn] = Border.Left.Value;

            for (var row = startRow + 1; Border.Right.HasValue && row < endRow; row++)
                table[row, endColumn] = Border.Right.Value;
        }

        private void DrawBody(char[,] table, int startRow, int endRow, int startColumn, int endColumn)
        {
            if (Border.Top.HasValue)
                startRow++;

            if (Border.Bottom.HasValue)
                endRow--;

            if (Border.Left.HasValue)
                startColumn++;

            if (Border.Right.HasValue)
                endColumn--;

            var columnSize = endColumn - startColumn + 1;
            var numberOfRows = endRow - startRow + 1;

            var keepWordsTogether = _cellDefinition.HorizontalAlign != HorizontalAlign.Justified;
            var values = _cellDefinition.Value.Wrap(columnSize, keepWordsTogether);

            for (var i = 0; i < values.Count; i++)
                values[i] = values[i].Align(columnSize, _cellDefinition.HorizontalAlign, _cellDefinition.PadValue ?? ' ');

            values = values.Align(numberOfRows, _cellDefinition.VerticalAlign);

            for (var row = startRow; row <= endRow && _cellDefinition.PadValue.HasValue; row++)
            for (var column = startColumn; column <= endColumn; column++)
                table[row, column] = _cellDefinition.PadValue.Value;

            for (var row = startRow; row <= endRow && row - startRow < values.Count; row++)
            for (var column = startColumn; column <= endColumn && column - startColumn < values[row - startRow].Length; column++)
                table[row, column] = values[row - startRow][column - startColumn];
        }
    }
}