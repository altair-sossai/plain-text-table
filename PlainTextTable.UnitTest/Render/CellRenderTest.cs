using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Enums;
using PlainTextTable.Extensions;
using PlainTextTable.Grid;
using PlainTextTable.Render;

namespace PlainTextTable.UnitTest.Render
{
    [TestClass]
    public class CellRenderTest
    {
        [TestMethod]
        public void Case_01_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|        |" + Environment.NewLine +
                "|        |" + Environment.NewLine +
                "|        |" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_02_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|        |" + Environment.NewLine +
                "+--------+" + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_03_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 2, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "+--------+" + Environment.NewLine +
                "|        |" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_04_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 4, 9);

            var print = table.Print(rows, columns);
            var expected =
                "    +----+" + Environment.NewLine +
                "    |    |" + Environment.NewLine +
                "    |    |" + Environment.NewLine +
                "    |    |" + Environment.NewLine +
                "    +----+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_05_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 5);

            var print = table.Print(rows, columns);
            var expected =
                "+----+    " + Environment.NewLine +
                "|    |    " + Environment.NewLine +
                "|    |    " + Environment.NewLine +
                "|    |    " + Environment.NewLine +
                "+----+    ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_06_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 0, 7);

            var print = table.Print(rows, columns);
            var expected =
                "+------+  " + Environment.NewLine +
                "|      |  " + Environment.NewLine +
                "+------+  " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_07_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 2, 9);

            var print = table.Print(rows, columns);
            var expected =
                "  +------+" + Environment.NewLine +
                "  |      |" + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_08_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 2, 4, 0, 7);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "+------+  " + Environment.NewLine +
                "|      |  " + Environment.NewLine +
                "+------+  ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_09_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 2, 4, 2, 9);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "  |      |" + Environment.NewLine +
                "  +------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_10_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 1, 3, 2, 9);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "  |      |" + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_11_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 3, 2, 6);

            var print = table.Print(rows, columns);
            var expected =
                "  +---+   " + Environment.NewLine +
                "  |   |   " + Environment.NewLine +
                "  |   |   " + Environment.NewLine +
                "  +---+   " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_12_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 1, 2, 6);

            var print = table.Print(rows, columns);
            var expected =
                "  +---+   " + Environment.NewLine +
                "  +---+   " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_13_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 1, 2, 3);

            var print = table.Print(rows, columns);
            var expected =
                "  ++      " + Environment.NewLine +
                "  ++      " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_14_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 1, 2, 2);

            var print = table.Print(rows, columns);
            var expected =
                "  +       " + Environment.NewLine +
                "  +       " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_15_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 0, 2, 3);

            var print = table.Print(rows, columns);
            var expected =
                "  ++      " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_16_Comum_Border_Without_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition();
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 0, 2, 2);

            var print = table.Print(rows, columns);
            var expected =
                "  +       " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_02_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "+--------+" + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_03_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 2, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "+--------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_04_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 4, 9);

            var print = table.Print(rows, columns);
            var expected =
                "    +----+" + Environment.NewLine +
                "    |Lore|" + Environment.NewLine +
                "    |m Ip|" + Environment.NewLine +
                "    |sum |" + Environment.NewLine +
                "    +----+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_05_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 5);

            var print = table.Print(rows, columns);
            var expected =
                "+----+    " + Environment.NewLine +
                "|Lore|    " + Environment.NewLine +
                "|m Ip|    " + Environment.NewLine +
                "|sum |    " + Environment.NewLine +
                "+----+    ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_06_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 0, 7);

            var print = table.Print(rows, columns);
            var expected =
                "+------+  " + Environment.NewLine +
                "|Lorem |  " + Environment.NewLine +
                "+------+  " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_07_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 2, 9);

            var print = table.Print(rows, columns);
            var expected =
                "  +------+" + Environment.NewLine +
                "  |Lorem |" + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_08_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 2, 4, 0, 7);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "+------+  " + Environment.NewLine +
                "|Lorem |  " + Environment.NewLine +
                "+------+  ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_09_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 2, 4, 2, 9);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "  |Lorem |" + Environment.NewLine +
                "  +------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_10_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 1, 3, 2, 9);

            var print = table.Print(rows, columns);
            var expected =
                "          " + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "  |Lorem |" + Environment.NewLine +
                "  +------+" + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_11_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 3, 2, 6);

            var print = table.Print(rows, columns);
            var expected =
                "  +---+   " + Environment.NewLine +
                "  |Lor|   " + Environment.NewLine +
                "  |em |   " + Environment.NewLine +
                "  +---+   " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_12_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 1, 2, 6);

            var print = table.Print(rows, columns);
            var expected =
                "  +---+   " + Environment.NewLine +
                "  +---+   " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_13_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 1, 2, 3);

            var print = table.Print(rows, columns);
            var expected =
                "  ++      " + Environment.NewLine +
                "  ++      " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_14_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 1, 2, 2);

            var print = table.Print(rows, columns);
            var expected =
                "  +       " + Environment.NewLine +
                "  +       " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_15_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 0, 2, 3);

            var print = table.Print(rows, columns);
            var expected =
                "  ++      " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_16_Comum_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition {Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry"};
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 0, 2, 2);

            var print = table.Print(rows, columns);
            var expected =
                "  +       " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_Left_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition {Left = null}
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "Lorem Ips|" + Environment.NewLine +
                "um is sim|" + Environment.NewLine +
                "ply dummy|" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_Right_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition {Right = null}
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem Ips" + Environment.NewLine +
                "|um is sim" + Environment.NewLine +
                "|ply dummy" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_Left_And_Right_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    Left = null,
                    Right = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "Lorem Ipsu" + Environment.NewLine +
                "m is simpl" + Environment.NewLine +
                "y dummy te" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_Top_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    Top = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+Lorem Ip+" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                "|mmy text|" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_Bottom_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    Bottom = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                "+mmy text+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_TopLeft_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    TopLeft = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                " --------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_TopRight_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    TopRight = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+-------- " + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                "+--------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_BottomLeft_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    BottomLeft = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                " --------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Case_01_Without_BottomRight_Border_With_Value()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Border = new BorderDefinition
                {
                    BottomRight = null
                }
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 4, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem Ip|" + Environment.NewLine +
                "|sum is s|" + Environment.NewLine +
                "|imply du|" + Environment.NewLine +
                "+-------- ";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Left_Top()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Left,
                VerticalAlign = VerticalAlign.Top
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|simp      |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Left_Top_PadValue()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Left,
                VerticalAlign = VerticalAlign.Top,
                PadValue = '?'
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|simp??????|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Center_Top()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Center,
                VerticalAlign = VerticalAlign.Top
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|   simp   |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Right_Top()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Right,
                VerticalAlign = VerticalAlign.Top
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|      simp|" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Left_Middle()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Left,
                VerticalAlign = VerticalAlign.Middle
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|simp      |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Center_Middle()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Center,
                VerticalAlign = VerticalAlign.Middle
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|   simp   |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Center_Middle_PadValue()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Center,
                VerticalAlign = VerticalAlign.Middle,
                PadValue = '?'
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|???simp???|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Right_Middle()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Right,
                VerticalAlign = VerticalAlign.Middle
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|      simp|" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Left_Bottom()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Left,
                VerticalAlign = VerticalAlign.Bottom
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|simp      |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Center_Bottom()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Center,
                VerticalAlign = VerticalAlign.Bottom
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|   simp   |" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Right_Bottom()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Right,
                VerticalAlign = VerticalAlign.Bottom
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|          |" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|      simp|" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void Align_Right_Bottom_With_PadValue()
        {
            const int rows = 7;
            const int columns = 12;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lor Ips is simp",
                HorizontalAlign = HorizontalAlign.Right,
                VerticalAlign = VerticalAlign.Bottom,
                PadValue = '?'
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 6, 0, 11);

            var print = table.Print(rows, columns);
            var expected =
                "+----------+" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|??????????|" + Environment.NewLine +
                "|Lor Ips is|" + Environment.NewLine +
                "|??????simp|" + Environment.NewLine +
                "+----------+";

            Assert.AreEqual(expected, print);
        }

        [TestMethod]
        public void With_PadValue()
        {
            const int rows = 5;
            const int columns = 10;

            var table = new char[rows, columns];
            table.Init(rows, columns);

            var cellDefinition = new CellDefinition
            {
                Value = "Lorem",
                PadValue = '?'
            };
            var cellRender = new CellRender(cellDefinition);

            cellRender.Draw(table, 0, 2, 0, 9);

            var print = table.Print(rows, columns);
            var expected =
                "+--------+" + Environment.NewLine +
                "|Lorem???|" + Environment.NewLine +
                "+--------+" + Environment.NewLine +
                "          " + Environment.NewLine +
                "          ";

            Assert.AreEqual(expected, print);
        }
    }
}