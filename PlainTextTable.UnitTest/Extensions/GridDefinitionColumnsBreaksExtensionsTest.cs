using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Extensions;

namespace PlainTextTable.UnitTest.Extensions
{
    [TestClass]
    public class GridDefinitionColumnsBreaksExtensionsTest
    {
        [TestMethod]
        public void Case_01()
        {
            var columnsSize = new[] { 0, 0, 0, 0, 0 };
            var columnsBreaks = columnsSize.ColumnsBreaks();

            Assert.AreEqual(0, columnsBreaks[0].Start);
            Assert.AreEqual(0, columnsBreaks[0].End);

            Assert.AreEqual(0, columnsBreaks[1].Start);
            Assert.AreEqual(0, columnsBreaks[1].End);

            Assert.AreEqual(0, columnsBreaks[2].Start);
            Assert.AreEqual(0, columnsBreaks[2].End);

            Assert.AreEqual(0, columnsBreaks[3].Start);
            Assert.AreEqual(0, columnsBreaks[3].End);

            Assert.AreEqual(0, columnsBreaks[4].Start);
            Assert.AreEqual(0, columnsBreaks[4].End);
        }

        [TestMethod]
        public void Case_02()
        {
            var columnsSize = new[] { 1, 0, 0, 0, 0 };
            var columnsBreaks = columnsSize.ColumnsBreaks();

            Assert.AreEqual(0, columnsBreaks[0].Start);
            Assert.AreEqual(1, columnsBreaks[0].End);

            Assert.AreEqual(1, columnsBreaks[1].Start);
            Assert.AreEqual(1, columnsBreaks[1].End);

            Assert.AreEqual(1, columnsBreaks[2].Start);
            Assert.AreEqual(1, columnsBreaks[2].End);

            Assert.AreEqual(1, columnsBreaks[3].Start);
            Assert.AreEqual(1, columnsBreaks[3].End);

            Assert.AreEqual(1, columnsBreaks[4].Start);
            Assert.AreEqual(1, columnsBreaks[4].End);
        }

        [TestMethod]
        public void Case_03()
        {
            var columnsSize = new[] { 1, 1, 1, 1, 1 };
            var columnsBreaks = columnsSize.ColumnsBreaks();

            Assert.AreEqual(0, columnsBreaks[0].Start);
            Assert.AreEqual(1, columnsBreaks[0].End);

            Assert.AreEqual(1, columnsBreaks[1].Start);
            Assert.AreEqual(2, columnsBreaks[1].End);

            Assert.AreEqual(2, columnsBreaks[2].Start);
            Assert.AreEqual(3, columnsBreaks[2].End);

            Assert.AreEqual(3, columnsBreaks[3].Start);
            Assert.AreEqual(4, columnsBreaks[3].End);

            Assert.AreEqual(4, columnsBreaks[4].Start);
            Assert.AreEqual(4, columnsBreaks[4].End);
        }

        [TestMethod]
        public void Case_04()
        {
            var columnsSize = new[] { 4, 5, 10, 10, 9 };
            var columnsBreaks = columnsSize.ColumnsBreaks();

            Assert.AreEqual(0, columnsBreaks[0].Start);
            Assert.AreEqual(4, columnsBreaks[0].End);

            Assert.AreEqual(4, columnsBreaks[1].Start);
            Assert.AreEqual(9, columnsBreaks[1].End);

            Assert.AreEqual(9, columnsBreaks[2].Start);
            Assert.AreEqual(19, columnsBreaks[2].End);

            Assert.AreEqual(19, columnsBreaks[3].Start);
            Assert.AreEqual(29, columnsBreaks[3].End);

            Assert.AreEqual(29, columnsBreaks[4].Start);
            Assert.AreEqual(37, columnsBreaks[4].End);
        }
    }
}