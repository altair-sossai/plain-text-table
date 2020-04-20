using System.Collections.Generic;

namespace PlainTextTable.Grid
{
    public class GridDefinition
    {
        public GridDefinition()
        {
            RowDefinitions = new List<RowDefinition>();
            ColumnDefinitions = new List<ColumnDefinition>();
            CellDefinitions = new List<CellDefinition>();
        }

        public List<RowDefinition> RowDefinitions { get; set; }
        public List<ColumnDefinition> ColumnDefinitions { get; set; }
        public List<CellDefinition> CellDefinitions { get; set; }
    }
}