using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Extensions;

namespace PlainTextTable.UnitTest.Extensions
{
    [TestClass]
    public class GridDefinitionRowsBreaksExtensionsTest
    {
        [TestMethod]
        public void Case_01()
        {
            var rowsSize = new[] { 0, 0, 0, 0, 0 };
            var rowsBreaks = rowsSize.RowsBreaks();

            Assert.AreEqual(0, rowsBreaks[0].Start);
            Assert.AreEqual(0, rowsBreaks[0].End);

            Assert.AreEqual(0, rowsBreaks[1].Start);
            Assert.AreEqual(0, rowsBreaks[1].End);

            Assert.AreEqual(0, rowsBreaks[2].Start);
            Assert.AreEqual(0, rowsBreaks[2].End);

            Assert.AreEqual(0, rowsBreaks[3].Start);
            Assert.AreEqual(0, rowsBreaks[3].End);

            Assert.AreEqual(0, rowsBreaks[4].Start);
            Assert.AreEqual(0, rowsBreaks[4].End);
        }

        [TestMethod]
        public void Case_02()
        {
            var rowsSize = new[] { 1, 0, 0, 0, 0 };
            var rowsBreaks = rowsSize.RowsBreaks();

            Assert.AreEqual(0, rowsBreaks[0].Start);
            Assert.AreEqual(1, rowsBreaks[0].End);

            Assert.AreEqual(1, rowsBreaks[1].Start);
            Assert.AreEqual(1, rowsBreaks[1].End);

            Assert.AreEqual(1, rowsBreaks[2].Start);
            Assert.AreEqual(1, rowsBreaks[2].End);

            Assert.AreEqual(1, rowsBreaks[3].Start);
            Assert.AreEqual(1, rowsBreaks[3].End);

            Assert.AreEqual(1, rowsBreaks[4].Start);
            Assert.AreEqual(1, rowsBreaks[4].End);
        }

        [TestMethod]
        public void Case_03()
        {
            var rowsSize = new[] { 1, 1, 1, 1, 1 };
            var rowsBreaks = rowsSize.RowsBreaks();

            Assert.AreEqual(0, rowsBreaks[0].Start);
            Assert.AreEqual(1, rowsBreaks[0].End);

            Assert.AreEqual(1, rowsBreaks[1].Start);
            Assert.AreEqual(2, rowsBreaks[1].End);

            Assert.AreEqual(2, rowsBreaks[2].Start);
            Assert.AreEqual(3, rowsBreaks[2].End);

            Assert.AreEqual(3, rowsBreaks[3].Start);
            Assert.AreEqual(4, rowsBreaks[3].End);

            Assert.AreEqual(4, rowsBreaks[4].Start);
            Assert.AreEqual(4, rowsBreaks[4].End);
        }

        [TestMethod]
        public void Case_04()
        {
            var rowsSize = new[] { 4, 5, 10, 10, 9 };
            var rowsBreaks = rowsSize.RowsBreaks();

            Assert.AreEqual(0, rowsBreaks[0].Start);
            Assert.AreEqual(4, rowsBreaks[0].End);

            Assert.AreEqual(4, rowsBreaks[1].Start);
            Assert.AreEqual(9, rowsBreaks[1].End);

            Assert.AreEqual(9, rowsBreaks[2].Start);
            Assert.AreEqual(19, rowsBreaks[2].End);

            Assert.AreEqual(19, rowsBreaks[3].Start);
            Assert.AreEqual(29, rowsBreaks[3].End);

            Assert.AreEqual(29, rowsBreaks[4].Start);
            Assert.AreEqual(37, rowsBreaks[4].End);
        }
    }
}