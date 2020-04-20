using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Enums;
using PlainTextTable.Extensions;
using PlainTextTable.Grid;

namespace PlainTextTable.UnitTest.Extensions
{
    [TestClass]
    public class GridDefinitionRowSizeExtensionsTest
    {
        [TestMethod]
        public void Only_Fixed_Without_Cells_Case_01()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1}
                }
            };

            var columnsSize = new[] {5, 10, 15, 1};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(1, rowsSize[0]);
            Assert.AreEqual(1, rowsSize[1]);
            Assert.AreEqual(1, rowsSize[2]);
        }

        [TestMethod]
        public void Only_Fixed_Without_Cells_Case_02()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 3},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 4},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 7}
                }
            };

            var columnsSize = new[] {5, 10, 15, 1};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(3, rowsSize[0]);
            Assert.AreEqual(4, rowsSize[1]);
            Assert.AreEqual(7, rowsSize[2]);
        }

        [TestMethod]
        public void Only_Fixed_With_Cells_Case_01()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Row = 0, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 1, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 2, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"}
                }
            };

            var columnsSize = new[] {5, 10, 15, 1};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(2, rowsSize[0]);
            Assert.AreEqual(2, rowsSize[1]);
            Assert.AreEqual(3, rowsSize[2]);
        }

        [TestMethod]
        public void Only_Fixed_With_Cells_Case_02()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 3},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 4},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 7}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Row = 0, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 1, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 2, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"}
                }
            };

            var columnsSize = new[] {5, 10, 15, 1};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(4, rowsSize[0]);
            Assert.AreEqual(5, rowsSize[1]);
            Assert.AreEqual(9, rowsSize[2]);
        }

        [TestMethod]
        public void Only_Auto_Without_Cells_Case_01()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                }
            };

            var columnsSize = new[] {5, 10, 15, 1};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(1, rowsSize[0]);
            Assert.AreEqual(1, rowsSize[1]);
            Assert.AreEqual(1, rowsSize[2]);
        }

        [TestMethod]
        public void Only_Auto_With_Cells_Case_01()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Row = 0, Column = 0, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 0, Column = 1, Value = "Lorem Ipsum is simply dummy typesetting industry"},
                    new CellDefinition {Row = 0, Column = 2, Value = "The printing and typesetting industry"},

                    new CellDefinition {Row = 1, Column = 0, Value = "Lorem"},
                    new CellDefinition {Row = 1, Column = 1, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 1, Column = 2, Value = "Ipsum is simply dummy text of the printing and typesetting industry"},

                    new CellDefinition {Row = 2, Column = 0, Value = ""},
                    new CellDefinition {Row = 2, Column = 1, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 2, Column = 2, Value = ""}
                }
            };

            var columnsSize = new[] {5, 10, 15};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(19, rowsSize[0]);
            Assert.AreEqual(9, rowsSize[1]);
            Assert.AreEqual(10, rowsSize[2]);
        }

        [TestMethod]
        public void Only_Auto_With_Cells_Case_02()
        {
            var gridDefinition = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition()
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Row = 0, Column = 0, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 0, Column = 1, Value = "Lorem Ipsum is simply dummy typesetting industry"},
                    new CellDefinition {Row = 0, Column = 2, Value = "The printing and typesetting industry"},

                    new CellDefinition {Row = 1, Column = 0, Value = "Lorem"},
                    new CellDefinition {Row = 1, Column = 1, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 1, Column = 2, Value = "Ipsum is simply dummy text of the printing and typesetting industry"},

                    new CellDefinition {Row = 2, Column = 0, Value = ""},
                    new CellDefinition {Row = 2, Column = 1, Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"},
                    new CellDefinition {Row = 2, Column = 2, Value = ""}
                }
            };

            var columnsSize = new[] {5, 10, 15};

            var rowsSize = gridDefinition.RowsSize(columnsSize);

            Assert.AreEqual(3, rowsSize.Length);

            Assert.AreEqual(19, rowsSize[0]);
            Assert.AreEqual(9, rowsSize[1]);
            Assert.AreEqual(10, rowsSize[2]);
        }
    }
}