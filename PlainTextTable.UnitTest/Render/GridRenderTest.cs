using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Enums;
using PlainTextTable.Extensions;
using PlainTextTable.Grid;
using PlainTextTable.Render;
using PlainTextTable.Styles.Types;

namespace PlainTextTable.UnitTest.Render
{
    [TestClass]
    public class GridRenderTest
    {
        [TestMethod]
        public void Case_01()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition
                    {
                        Value = "Lorem Ipsum!",
                        Border = BorderDefinition.Empty
                    }
                }
            };

            var gridRender = new GridRender(grid);

            var actual = gridRender.Render(20);

            Assert.AreEqual("Lorem Ipsum!        ", actual);
        }

        [TestMethod]
        public void Case_02()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition
                    {
                        Row = 0,
                        Value = "Lorem Ipsum!",
                        HorizontalAlign = HorizontalAlign.Right,
                        Border = BorderDefinition.Empty
                    },
                    new CellDefinition
                    {
                        Row = 1,
                        Value = "Dolor!",
                        HorizontalAlign = HorizontalAlign.Center,
                        Border = BorderDefinition.Empty
                    }
                }
            };

            var gridRender = new GridRender(grid);
            var actual = gridRender.Render(20);

            var expected =
                "        Lorem Ipsum!" + Environment.NewLine +
                "       Dolor!       ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Case_03()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition
                    {
                        Row = 0,
                        Column = 0,
                        Value = "Lorem Ipsum!",
                        HorizontalAlign = HorizontalAlign.Right,
                        Border = BorderDefinition.Empty
                    },
                    new CellDefinition
                    {
                        Row = 1,
                        Column = 0,
                        Value = "Dolor!",
                        HorizontalAlign = HorizontalAlign.Center,
                        Border = BorderDefinition.Empty
                    },

                    new CellDefinition
                    {
                        Row = 0,
                        Column = 1,
                        Value = "Lorem Ipsum!",
                        HorizontalAlign = HorizontalAlign.Right,
                        Border = BorderDefinition.Empty
                    },
                    new CellDefinition
                    {
                        Row = 1,
                        Column = 1,
                        Value = "Dolor!",
                        HorizontalAlign = HorizontalAlign.Center,
                        Border = BorderDefinition.Empty
                    }
                }
            };

            var gridRender = new GridRender(grid);
            var actual = gridRender.Render(40);

            var expected =
                "         Lorem Ipsum        Lorem Ipsum!" + Environment.NewLine +
                "       Dolor!              Dolor!       ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Case_04()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1},
                    new RowDefinition {HeightType = HeightType.Fixed, Height = 1}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1}
                },
                CellDefinitions = new List<CellDefinition>
                {
                    new CellDefinition
                    {
                        Row = 0,
                        Column = 0,
                        Value = "Lorem Ipsum!",
                        HorizontalAlign = HorizontalAlign.Right
                    },
                    new CellDefinition
                    {
                        Row = 1,
                        Column = 0,
                        Value = "Dolor!",
                        HorizontalAlign = HorizontalAlign.Center
                    },

                    new CellDefinition
                    {
                        Row = 0,
                        Column = 1,
                        Value = "Lorem Ipsum!",
                        HorizontalAlign = HorizontalAlign.Right
                    },
                    new CellDefinition
                    {
                        Row = 1,
                        Column = 1,
                        Value = "Dolor!",
                        HorizontalAlign = HorizontalAlign.Center
                    }
                }
            };

            var gridRender = new GridRender(grid);
            gridRender.AddStyle(new InsideBordersStyle());

            var actual = gridRender.Render(40);

            var expected =
                "        Lorem Ipsum!|       Lorem Ipsum!" + Environment.NewLine +
                "--------------------+-------------------" + Environment.NewLine +
                "       Dolor!       |      Dolor!       ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Case_05()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                }
            };

            grid
                .AddCell("Produto", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Valor", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Qtd.", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Total", horizontalAlign: HorizontalAlign.Center);

            grid
                .AddCell("Refeição")
                .AddCell("R$ 44,90")
                .AddCell("0,000 kg")
                .AddCell("R$ 8,89");

            grid
                .AddCell("Refrigerantes")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell("Sucos")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            var gridRender = new GridRender(grid);

            var actual = gridRender.Render(57);

            var expected =
                "+-----------------------------+--------+--------+-------+" + Environment.NewLine +
                "|           Produto           | Valor  |  Qtd.  | Total |" + Environment.NewLine +
                "+-----------------------------+--------+--------+-------+" + Environment.NewLine +
                "|Refeição                     |R$ 44,90|0,000 kg|R$ 8,89|" + Environment.NewLine +
                "+-----------------------------+--------+--------+-------+" + Environment.NewLine +
                "|Refrigerantes                |        |        |       |" + Environment.NewLine +
                "+-----------------------------+--------+--------+-------+" + Environment.NewLine +
                "|Sucos                        |        |        |       |" + Environment.NewLine +
                "+-----------------------------+--------+--------+-------+" + Environment.NewLine +
                "|                             |        |        |       |" + Environment.NewLine +
                "+-----------------------------+--------+--------+-------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Case_06()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Fixed, Width = 8}
                }
            };

            grid
                .AddCell("Produto", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Valor", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Qtd.", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Total", horizontalAlign: HorizontalAlign.Center);

            grid
                .AddCell("Refeição", horizontalAlign: HorizontalAlign.Right, verticalAlign: VerticalAlign.Middle)
                .AddCell("R$ 44,90")
                .AddCell("0,000 kg")
                .AddCell("R$ 167.008,89");

            grid
                .AddCell("Refrigerantes")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell("Sucos")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            var gridRender = new GridRender(grid);

            var actual = gridRender.Render(57);

            var expected =
                "+----------------------------+--------+--------+--------+" + Environment.NewLine +
                "|          Produto           | Valor  |  Qtd.  | Total  |" + Environment.NewLine +
                "+----------------------------+--------+--------+--------+" + Environment.NewLine +
                "|                            |R$ 44,90|0,000 kg|R$      |" + Environment.NewLine +
                "|                    Refeição|        |        |167.008,|" + Environment.NewLine +
                "|                            |        |        |89      |" + Environment.NewLine +
                "+----------------------------+--------+--------+--------+" + Environment.NewLine +
                "|Refrigerantes               |        |        |        |" + Environment.NewLine +
                "+----------------------------+--------+--------+--------+" + Environment.NewLine +
                "|Sucos                       |        |        |        |" + Environment.NewLine +
                "+----------------------------+--------+--------+--------+" + Environment.NewLine +
                "|                            |        |        |        |" + Environment.NewLine +
                "+----------------------------+--------+--------+--------+";

            Assert.AreEqual(expected, actual);
        }
    }
}