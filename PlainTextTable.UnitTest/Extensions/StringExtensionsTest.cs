using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.Extensions;

namespace PlainTextTable.UnitTest.Extensions
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void Dont_Keep_Words_Together_Case_01()
        {
            var lines = StringExtensions.Wrap(null, 0, false);

            Assert.AreEqual(0, lines.Count);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_02()
        {
            var lines = "Lorem Ipsum".Wrap(0, false);

            Assert.AreEqual(0, lines.Count);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_03()
        {
            var lines = StringExtensions.Wrap(null, 20, false);

            Assert.AreEqual(0, lines.Count);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_04()
        {
            var lines = "Lorem Ipsum".Wrap(11, false);

            Assert.AreEqual(1, lines.Count);

            Assert.AreEqual("Lorem Ipsum", lines[0]);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_05()
        {
            var lines = "Lorem Ipsum".Wrap(12, false);

            Assert.AreEqual(1, lines.Count);

            Assert.AreEqual("Lorem Ipsum", lines[0]);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_06()
        {
            var lines = "Lorem Ipsum".Wrap(5, false);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_07()
        {
            var lines = "Lorem Ipsum".Wrap(6, false);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_08()
        {
            var lines = "Lorem Ipsum".Wrap(7, false);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem I", lines[0]);
            Assert.AreEqual("psum", lines[1]);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_09()
        {
            var lines = "Lorem Ipsum".Wrap(2, false);

            Assert.AreEqual(6, lines.Count);

            Assert.AreEqual("Lo", lines[0]);
            Assert.AreEqual("re", lines[1]);
            Assert.AreEqual("m", lines[2]);
            Assert.AreEqual("Ip", lines[3]);
            Assert.AreEqual("su", lines[4]);
            Assert.AreEqual("m", lines[5]);
        }

        [TestMethod]
        public void Dont_Keep_Words_Together_Case_10()
        {
            var lines = "Lorem Ipsum".Wrap(10, false);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem Ipsu", lines[0]);
            Assert.AreEqual("m", lines[1]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_01()
        {
            var lines = StringExtensions.Wrap(null, 0, true);

            Assert.AreEqual(0, lines.Count);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_02()
        {
            var lines = "Lorem Ipsum".Wrap(0, true);

            Assert.AreEqual(0, lines.Count);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_03()
        {
            var lines = StringExtensions.Wrap(null, 20, true);

            Assert.AreEqual(0, lines.Count);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_04()
        {
            var lines = "Lorem Ipsum".Wrap(11, true);

            Assert.AreEqual(1, lines.Count);

            Assert.AreEqual("Lorem Ipsum", lines[0]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_05()
        {
            var lines = "Lorem Ipsum".Wrap(12, true);

            Assert.AreEqual(1, lines.Count);

            Assert.AreEqual("Lorem Ipsum", lines[0]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_06()
        {
            var lines = "Lorem Ipsum".Wrap(5, true);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_07()
        {
            var lines = "Lorem Ipsum".Wrap(6, true);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_08()
        {
            var lines = "Lorem Ipsum".Wrap(7, true);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_09()
        {
            var lines = "Lorem Ipsum".Wrap(2, true);

            Assert.AreEqual(6, lines.Count);

            Assert.AreEqual("Lo", lines[0]);
            Assert.AreEqual("re", lines[1]);
            Assert.AreEqual("m", lines[2]);
            Assert.AreEqual("Ip", lines[3]);
            Assert.AreEqual("su", lines[4]);
            Assert.AreEqual("m", lines[5]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_10()
        {
            var lines = "Lorem Ipsum".Wrap(10, true);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }

        [TestMethod]
        public void Keep_Words_Together_Case_11()
        {
            var lines = "         Lorem          Ipsum       ".Wrap(10, true);

            Assert.AreEqual(2, lines.Count);

            Assert.AreEqual("Lorem", lines[0]);
            Assert.AreEqual("Ipsum", lines[1]);
        }
    }
}