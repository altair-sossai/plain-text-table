using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.HtmlParser.Renders;

namespace PlainTextTable.HtmlParser.UnitTest.Renders
{
    [TestClass]
    public class ParagraphGridRenderTest
    {
        [TestMethod]
        public void Simple()
        {
            const string html = "<p>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "Oi, tudo bem?                                            ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Simple_LongText()
        {
            const string html = "<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Lorem Ipsum is simply dummy text of the printing and type" + Environment.NewLine +
                "setting industry. Lorem Ipsum has been the industry's sta" + Environment.NewLine +
                "ndard dummy text ever since the 1500s, when an unknown pr" + Environment.NewLine +
                "inter took a galley of type and scrambled it to make a ty" + Environment.NewLine +
                "pe specimen book. It has survived not only five centuries" + Environment.NewLine +
                ", but also the leap into electronic typesetting, remainin" + Environment.NewLine +
                "g essentially unchanged. It was popularised in the 1960s " + Environment.NewLine +
                "with the release of Letraset sheets containing Lorem Ipsu" + Environment.NewLine +
                "m passages, and more recently with desktop publishing sof" + Environment.NewLine +
                "tware like Aldus PageMaker including versions of Lorem Ip" + Environment.NewLine +
                "sum.                                                     ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadValue()
        {
            const string html = "<p pad-value='?'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "Oi, tudo bem?????????????????????????????????????????????";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadValue_LongText()
        {
            const string html = "<p pad-value='?'>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Lorem Ipsum is simply dummy text of the printing and type" + Environment.NewLine +
                "setting industry. Lorem Ipsum has been the industry's sta" + Environment.NewLine +
                "ndard dummy text ever since the 1500s, when an unknown pr" + Environment.NewLine +
                "inter took a galley of type and scrambled it to make a ty" + Environment.NewLine +
                "pe specimen book. It has survived not only five centuries" + Environment.NewLine +
                ", but also the leap into electronic typesetting, remainin" + Environment.NewLine +
                "g essentially unchanged. It was popularised in the 1960s?" + Environment.NewLine +
                "with the release of Letraset sheets containing Lorem Ipsu" + Environment.NewLine +
                "m passages, and more recently with desktop publishing sof" + Environment.NewLine +
                "tware like Aldus PageMaker including versions of Lorem Ip" + Environment.NewLine +
                "sum.?????????????????????????????????????????????????????";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextCenter()
        {
            const string html = "<p text-center>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "                      Oi, tudo bem?                      ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextCenter_LongText()
        {
            const string html = "<p text-center>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "  Lorem Ipsum is simply dummy text of the printing and   " + Environment.NewLine +
                "typesetting industry. Lorem Ipsum has been the industry's" + Environment.NewLine +
                "standard dummy text ever since the 1500s, when an unknown" + Environment.NewLine +
                "printer took a galley of type and scrambled it to make a " + Environment.NewLine +
                "    type specimen book. It has survived not only five    " + Environment.NewLine +
                "centuries, but also the leap into electronic typesetting," + Environment.NewLine +
                " remaining essentially unchanged. It was popularised in  " + Environment.NewLine +
                "the 1960s with the release of Letraset sheets containing " + Environment.NewLine +
                "  Lorem Ipsum passages, and more recently with desktop   " + Environment.NewLine +
                "   publishing software like Aldus PageMaker including    " + Environment.NewLine +
                "                versions of Lorem Ipsum.                 ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextRight()
        {
            const string html = "<p text-right>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "                                            Oi, tudo bem?";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextRight_LongText()
        {
            const string html = "<p text-right>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "     Lorem Ipsum is simply dummy text of the printing and" + Environment.NewLine +
                "typesetting industry. Lorem Ipsum has been the industry's" + Environment.NewLine +
                "standard dummy text ever since the 1500s, when an unknown" + Environment.NewLine +
                " printer took a galley of type and scrambled it to make a" + Environment.NewLine +
                "        type specimen book. It has survived not only five" + Environment.NewLine +
                "centuries, but also the leap into electronic typesetting," + Environment.NewLine +
                "   remaining essentially unchanged. It was popularised in" + Environment.NewLine +
                " the 1960s with the release of Letraset sheets containing" + Environment.NewLine +
                "     Lorem Ipsum passages, and more recently with desktop" + Environment.NewLine +
                "       publishing software like Aldus PageMaker including" + Environment.NewLine +
                "                                 versions of Lorem Ipsum.";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextLeft()
        {
            const string html = "<p text-left>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "Oi, tudo bem?                                            ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextLeft_LongText()
        {
            const string html = "<p text-left>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Lorem Ipsum is simply dummy text of the printing and     " + Environment.NewLine +
                "typesetting industry. Lorem Ipsum has been the industry's" + Environment.NewLine +
                "standard dummy text ever since the 1500s, when an unknown" + Environment.NewLine +
                "printer took a galley of type and scrambled it to make a " + Environment.NewLine +
                "type specimen book. It has survived not only five        " + Environment.NewLine +
                "centuries, but also the leap into electronic typesetting," + Environment.NewLine +
                "remaining essentially unchanged. It was popularised in   " + Environment.NewLine +
                "the 1960s with the release of Letraset sheets containing " + Environment.NewLine +
                "Lorem Ipsum passages, and more recently with desktop     " + Environment.NewLine +
                "publishing software like Aldus PageMaker including       " + Environment.NewLine +
                "versions of Lorem Ipsum.                                 ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadJustified()
        {
            const string html = "<p text-justified>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "Oi, tudo bem?                                            ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadJustified_LongText()
        {
            const string html = "<p text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Lorem Ipsum is simply dummy text of the printing and type" + Environment.NewLine +
                "setting industry. Lorem Ipsum has been the industry's sta" + Environment.NewLine +
                "ndard dummy text ever since the 1500s, when an unknown pr" + Environment.NewLine +
                "inter took a galley of type and scrambled it to make a ty" + Environment.NewLine +
                "pe specimen book. It has survived not only five centuries" + Environment.NewLine +
                ", but also the leap into electronic typesetting, remainin" + Environment.NewLine +
                "g essentially unchanged. It was popularised in the 1960s " + Environment.NewLine +
                "with the release of Letraset sheets containing Lorem Ipsu" + Environment.NewLine +
                "m passages, and more recently with desktop publishing sof" + Environment.NewLine +
                "tware like Aldus PageMaker including versions of Lorem Ip" + Environment.NewLine +
                "sum.                                                     ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextLeft_TextTop()
        {
            const string html = "<p height='5' text-left text-top>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Lorem Ipsum.                                             " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextJustified_TextTop()
        {
            const string html = "<p height='5' text-justified text-top>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Lorem Ipsum.                                             " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextCenter_TextTop()
        {
            const string html = "<p height='5' text-center text-top>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                      Lorem Ipsum.                       " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextRight_TextTop()
        {
            const string html = "<p height='5' text-right text-top>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                             Lorem Ipsum." + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextLeft_TextMiddle()
        {
            const string html = "<p height='5' text-left text-middle>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "Lorem Ipsum.                                             " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextJustified_TextMiddle()
        {
            const string html = "<p height='5' text-justified text-middle>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "Lorem Ipsum.                                             " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextCenter_TextMiddle()
        {
            const string html = "<p height='5' text-center text-middle>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                      Lorem Ipsum.                       " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextRight_TextMiddle()
        {
            const string html = "<p height='5' text-right text-middle>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                             Lorem Ipsum." + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextLeft_TextBottom()
        {
            const string html = "<p height='5' text-left text-bottom>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "Lorem Ipsum.                                             ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextJustified_TextBottom()
        {
            const string html = "<p height='5' text-justified text-bottom>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "Lorem Ipsum.                                             ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextCenter_TextBottom()
        {
            const string html = "<p height='5' text-center text-bottom>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                      Lorem Ipsum.                       ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveLines_TextRight_TextBottom()
        {
            const string html = "<p height='5' text-right text-bottom>Lorem Ipsum.</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                             Lorem Ipsum.";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border()
        {
            const string html = "<p border='x'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Corner()
        {
            const string html = "<p corner='.' border='x'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                ".xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx." + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                ".xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Edge()
        {
            const string html = "<p edge='x'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                " xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx " + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                " xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Left()
        {
            const string html = "<p border='x' border-left='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                ".Oi, tudo bem?                                          x" + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Right()
        {
            const string html = "<p border='x' border-right='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                "xOi, tudo bem?                                          ." + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Top()
        {
            const string html = "<p border='x' border-top='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "x.......................................................x" + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Bottom()
        {
            const string html = "<p border='x' border-bottom='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                "x.......................................................x";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Top_Left()
        {
            const string html = "<p border='x' border-top-left='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                ".xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Top_Right()
        {
            const string html = "<p border='x' border-top-right='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx." + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Bottom_Right()
        {
            const string html = "<p border='x' border-bottom-right='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Border_Bottom_Left()
        {
            const string html = "<p border='x' border-bottom-left='.'>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + Environment.NewLine +
                "xOi, tudo bem?                                          x" + Environment.NewLine +
                ".xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllBorders()
        {
            const string html = "<p all-borders>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "+-------------------------------------------------------+" + Environment.NewLine +
                "|Oi, tudo bem?                                          |" + Environment.NewLine +
                "+-------------------------------------------------------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BottomBorder()
        {
            const string html = "<p bottom-border>Oi, tudo bem?</p>";
            var paragraphGridRender = new ParagraphGridRender(html);

            var actual = paragraphGridRender.Render(57);
            var expected =
                "Oi, tudo bem?                                            " + Environment.NewLine +
                "---------------------------------------------------------";

            Assert.AreEqual(expected, actual);
        }
    }
}