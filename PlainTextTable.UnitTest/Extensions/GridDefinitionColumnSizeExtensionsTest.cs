using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Enums;
using PlainTextTable.Extensions;
using PlainTextTable.Grid;

namespace PlainTextTable.UnitTest.Extensions
{
    [TestClass]
    public class GridDefinitionColumnSizeExtensionsTest
    {
        [TestMethod]
        public void Only_Fixed_Case_01()
        {
            const int width = 32;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 10},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 7},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 3},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 12}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(10, columnsSize[0]);
            Assert.AreEqual(7, columnsSize[1]);
            Assert.AreEqual(3, columnsSize[2]);
            Assert.AreEqual(12, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Fixed_Case_02()
        {
            const int width = 35;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 10},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 7},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 3},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 12}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(11, columnsSize[0]);
            Assert.AreEqual(8, columnsSize[1]);
            Assert.AreEqual(4, columnsSize[2]);
            Assert.AreEqual(12, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Fixed_Case_03()
        {
            const int width = 30;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 10},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 7},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 3},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 12}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(9, columnsSize[0]);
            Assert.AreEqual(6, columnsSize[1]);
            Assert.AreEqual(3, columnsSize[2]);
            Assert.AreEqual(12, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Auto_Case_01()
        {
            const int width = 15;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcd"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(2, columnsSize[0]);
            Assert.AreEqual(3, columnsSize[1]);
            Assert.AreEqual(4, columnsSize[2]);
            Assert.AreEqual(6, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Auto_Case_02()
        {
            const int width = 17;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcd"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(3, columnsSize[0]);
            Assert.AreEqual(4, columnsSize[1]);
            Assert.AreEqual(4, columnsSize[2]);
            Assert.AreEqual(6, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Auto_Case_03()
        {
            const int width = 15;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcdef"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(1, columnsSize[0]);
            Assert.AreEqual(2, columnsSize[1]);
            Assert.AreEqual(4, columnsSize[2]);
            Assert.AreEqual(8, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Star_Case_01()
        {
            const int width = 20;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcd"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(5, columnsSize[0]);
            Assert.AreEqual(5, columnsSize[1]);
            Assert.AreEqual(5, columnsSize[2]);
            Assert.AreEqual(5, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Star_Case_02()
        {
            const int width = 20;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 2},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 2},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcd"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(4, columnsSize[0]);
            Assert.AreEqual(6, columnsSize[1]);
            Assert.AreEqual(6, columnsSize[2]);
            Assert.AreEqual(4, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Star_Case_03()
        {
            const int width = 100;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 30},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 20},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 49},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcd"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(30, columnsSize[0]);
            Assert.AreEqual(21, columnsSize[1]);
            Assert.AreEqual(47, columnsSize[2]);
            Assert.AreEqual(2, columnsSize[3]);
        }

        [TestMethod]
        public void Only_Star_Case_04()
        {
            const int width = 100;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 20},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 49},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 30}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "a"},
                    new CellDefinition {Column = 1, Value = "ab"},
                    new CellDefinition {Column = 2, Value = "abc"},
                    new CellDefinition {Column = 3, Value = "abcd"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(2, columnsSize[0]);
            Assert.AreEqual(21, columnsSize[1]);
            Assert.AreEqual(47, columnsSize[2]);
            Assert.AreEqual(30, columnsSize[3]);
        }

        [TestMethod]
        public void Mixed_Case_01()
        {
            const int width = 57;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 2},
                    new ColumnDefinition {WidthType = WidthType.Star},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "01"},
                    new CellDefinition {Column = 1, Value = "Refeição"},
                    new CellDefinition {Column = 2, Value = "0.545 kg"},
                    new CellDefinition {Column = 3, Value = "R$ 15.00"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(3, columnsSize[0]);
            Assert.AreEqual(35, columnsSize[1]);
            Assert.AreEqual(9, columnsSize[2]);
            Assert.AreEqual(10, columnsSize[3]);
        }

        [TestMethod]
        public void Mixed_Case_02()
        {
            const int width = 57;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 10},
                    new ColumnDefinition {WidthType = WidthType.Star},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 500}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "01"},
                    new CellDefinition {Column = 1, Value = "Refeição"},
                    new CellDefinition {Column = 2, Value = "0.545 kg"},
                    new CellDefinition {Column = 3, Value = "R$ 15.00"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(1, columnsSize[0]);
            Assert.AreEqual(1, columnsSize[1]);
            Assert.AreEqual(1, columnsSize[2]);
            Assert.AreEqual(54, columnsSize[3]);
        }

        [TestMethod]
        public void Mixed_Case_03()
        {
            const int width = 57;

            var gridDefinition = new GridDefinition
            {
                ColumnDefinitions = new List<ColumnDefinition>(),
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition {Column = 0, Value = "01"},
                    new CellDefinition {Column = 1, Value = "Refeição"},
                    new CellDefinition {Column = 2, Value = "0.545 kg"},
                    new CellDefinition {Column = 3, Value = "R$ 15.00"}
                }
            };

            var columnsSize = gridDefinition.ColumnsSize(width);

            Assert.AreEqual(0, columnsSize.Length);
        }
    }
}