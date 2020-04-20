using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.HtmlParser.Renders;

namespace PlainTextTable.HtmlParser.UnitTest.Renders
{
    [TestClass]
    public class TableGridRenderTest
    {
        [TestMethod]
        public void Simple_Table()
        {
            const string html = @"<table>
	                                  <tr>
		                                  <td>Produto</td>
		                                  <td>Unit.</td>
		                                  <td>Qtd.</td>
		                                  <td>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td>Refeição</td>
		                                  <td>R$ 39.90</td>
		                                  <td>0.450 kg</td>
		                                  <td>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Produto      |Unit.        |Qtd.         |Total        |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Refeição     |R$ 39.90     |0.450 kg     |R$ 17.95     |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|             |             |             |             |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|             |             |             |             |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadValue_Table()
        {
            const string html = @"<table pad-value='?'>
	                                  <tr>
		                                  <td>Produto</td>
		                                  <td>Unit.</td>
		                                  <td>Qtd.</td>
		                                  <td>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td>Refeição</td>
		                                  <td>R$ 39.90</td>
		                                  <td>0.450 kg</td>
		                                  <td>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Produto??????|Unit.????????|Qtd.?????????|Total????????|" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Refeição?????|R$ 39.90?????|0.450 kg?????|R$ 17.95?????|" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|?????????????|?????????????|?????????????|?????????????|" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|?????????????|?????????????|?????????????|?????????????|" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadValue_Row()
        {
            const string html = @"<table>
	                                  <tr>
		                                  <td>Produto</td>
		                                  <td>Unit.</td>
		                                  <td>Qtd.</td>
		                                  <td>Total</td>
	                                  </tr>
	                                  <tr pad-value='?'>
		                                  <td>Refeição</td>
		                                  <td>R$ 39.90</td>
		                                  <td>0.450 kg</td>
		                                  <td>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Produto      |Unit.        |Qtd.         |Total        |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Refeição?????|R$ 39.90?????|0.450 kg?????|R$ 17.95?????|" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|             |             |             |             |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|             |             |             |             |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadValue_Cell()
        {
            const string html = @"<table>
	                                  <tr>
		                                  <td>Produto</td>
		                                  <td>Unit.</td>
		                                  <td>Qtd.</td>
		                                  <td>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td>Refeição</td>
		                                  <td>R$ 39.90</td>
		                                  <td>0.450 kg</td>
		                                  <td>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td pad-value='?'></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Produto      |Unit.        |Qtd.         |Total        |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|Refeição     |R$ 39.90     |0.450 kg     |R$ 17.95     |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|             |?????????????|             |             |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+" + Environment.NewLine +
                "|             |             |             |             |" + Environment.NewLine +
                "+-------------+-------------+-------------+-------------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_AllBorders()
        {
            const string html = @"<table all-borders>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|         Produto         |   Unit.   |   Qtd.   |Total |" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|.................Refeição|   R$ 39.90|0.450 kg  |R$    |" + Environment.NewLine +
                "|.........................|           |          |17.95 |" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|Lorem Ipsum is simply dum|           |          |      |" + Environment.NewLine +
                "|my text of the printing a|           |          |      |" + Environment.NewLine +
                "|nd typesetting industry  |           |          |      |" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|Lorem Ipsum is simply dum|           |          |Lorem |" + Environment.NewLine +
                "|my text of               |           |Lorem Ipsu|Ipsum |" + Environment.NewLine +
                "|                         |Lorem Ipsum|m is  type|is sim|" + Environment.NewLine +
                "|                         |           |setting in|ply du|" + Environment.NewLine +
                "|                         |           |dustry    |mmy te|" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|Lorem Ipsum is simply dum|Lorem      |Lorem Ipsu|Lorem |" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|Lorem Ipsum is simply dum|Lorem I    |Lorem Ipsu|Lorem |" + Environment.NewLine +
                "|my text of the printing a|           |m Printing|Ipsum |" + Environment.NewLine +
                "|nd typesetting industry  |           |and typese|is sim|" + Environment.NewLine +
                "|                         |           |tting indu|ply du|" + Environment.NewLine +
                "|                         |           |stry      |mmy te|" + Environment.NewLine +
                "|                         |           |          |xt of |" + Environment.NewLine +
                "|                         |           |          |the pr|" + Environment.NewLine +
                "|                         |           |          |inting|" + Environment.NewLine +
                "|                         |           |          |and ty|" + Environment.NewLine +
                "|                         |           |          |pesett|" + Environment.NewLine +
                "|                         |           |          |ing in|" + Environment.NewLine +
                "|                         |           |          |dustry|" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+" + Environment.NewLine +
                "|                         |           |          |      |" + Environment.NewLine +
                "|                         |           |          |      |" + Environment.NewLine +
                "|                         |           |          |      |" + Environment.NewLine +
                "|                         |           |   Oi!    |      |" + Environment.NewLine +
                "|                         |           |          |      |" + Environment.NewLine +
                "|                         |           |          |      |" + Environment.NewLine +
                "|                         |           |          |      |" + Environment.NewLine +
                "+-------------------------+-----------+----------+------+";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_BottomBorder()
        {
            const string html = @"<table white-space-border bottom-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "          Produto             Unit.       Qtd.    Total  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " .................Refeição    R$ 39.90 0.450 kg   R$     " + Environment.NewLine +
                " .........................                        17.95  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum                               " + Environment.NewLine +
                " my text of the printing a                               " + Environment.NewLine +
                " nd typesetting industry                                 " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum                        Lorem  " + Environment.NewLine +
                " my text of                            Lorem Ipsu Ipsum  " + Environment.NewLine +
                "                           Lorem Ipsum m is  type is sim " + Environment.NewLine +
                "                                       setting in ply du " + Environment.NewLine +
                "                                       dustry     mmy te " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem  " + Environment.NewLine +
                " my text of the printing a             m Printing Ipsum  " + Environment.NewLine +
                " nd typesetting industry               and typese is sim " + Environment.NewLine +
                "                                       tting indu ply du " + Environment.NewLine +
                "                                       stry       mmy te " + Environment.NewLine +
                "                                                  xt of  " + Environment.NewLine +
                "                                                  the pr " + Environment.NewLine +
                "                                                  inting " + Environment.NewLine +
                "                                                  and ty " + Environment.NewLine +
                "                                                  pesett " + Environment.NewLine +
                "                                                  ing in " + Environment.NewLine +
                "                                                  dustry " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                          Oi!            " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "---------------------------------------------------------";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_InsideBorders()
        {
            const string html = @"<table inside-borders>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "          Produto          |   Unit.   |   Qtd.   |Total " + Environment.NewLine +
                "---------------------------+-----------+----------+------" + Environment.NewLine +
                "...................Refeição|   R$ 39.90|0.450 kg  |R$    " + Environment.NewLine +
                "...........................|           |          |17.95 " + Environment.NewLine +
                "---------------------------+-----------+----------+------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy|           |          |      " + Environment.NewLine +
                "text of the printing and ty|           |          |      " + Environment.NewLine +
                "pesetting industry         |           |          |      " + Environment.NewLine +
                "---------------------------+-----------+----------+------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy|           |          |Lorem " + Environment.NewLine +
                "text of                    |           |Lorem Ipsu|Ipsum " + Environment.NewLine +
                "                           |Lorem Ipsum|m is  type|is sim" + Environment.NewLine +
                "                           |           |setting in|ply du" + Environment.NewLine +
                "                           |           |dustry    |mmy te" + Environment.NewLine +
                "---------------------------+-----------+----------+------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy|Lorem      |Lorem Ipsu|Lorem " + Environment.NewLine +
                "---------------------------+-----------+----------+------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy|Lorem I    |Lorem Ipsu|Lorem " + Environment.NewLine +
                "text of the printing and ty|           |m Printing|Ipsum " + Environment.NewLine +
                "pesetting industry         |           |and typese|is sim" + Environment.NewLine +
                "                           |           |tting indu|ply du" + Environment.NewLine +
                "                           |           |stry      |mmy te" + Environment.NewLine +
                "                           |           |          |xt of " + Environment.NewLine +
                "                           |           |          |the pr" + Environment.NewLine +
                "                           |           |          |inting" + Environment.NewLine +
                "                           |           |          |and ty" + Environment.NewLine +
                "                           |           |          |pesett" + Environment.NewLine +
                "                           |           |          |ing in" + Environment.NewLine +
                "                           |           |          |dustry" + Environment.NewLine +
                "---------------------------+-----------+----------+------" + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |   Oi!    |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_InsideHorizontalBorder()
        {
            const string html = @"<table white-space-border inside-horizontal-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "           Produto              Unit.      Qtd.    Total " + Environment.NewLine +
                "---------------------------------------------------------" + Environment.NewLine +
                "......................Refeiçã    R$ 39.90.450 kg  R$     " + Environment.NewLine +
                "..............................                    17.95  " + Environment.NewLine +
                "---------------------------------------------------------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy te                           " + Environment.NewLine +
                "xt of the printing and typeset                           " + Environment.NewLine +
                "ting industry                                            " + Environment.NewLine +
                "---------------------------------------------------------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy te                    Lorem I" + Environment.NewLine +
                "xt of                                   Lorem Ipsupsum is" + Environment.NewLine +
                "                             Lorem Ipsumis  typesesimply " + Environment.NewLine +
                "                                        ting indusdummy t" + Environment.NewLine +
                "                                        ry        ext of " + Environment.NewLine +
                "---------------------------------------------------------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy tLorem      Lorem IpsuLorem I" + Environment.NewLine +
                "---------------------------------------------------------" + Environment.NewLine +
                "Lorem Ipsum is simply dummy tLorem I    Lorem IpsuLorem I" + Environment.NewLine +
                "xt of the printing and typeset          Printing apsum is" + Environment.NewLine +
                "ting industry                           d typesettsimply " + Environment.NewLine +
                "                                        ng industrdummy t" + Environment.NewLine +
                "                                                  ext of " + Environment.NewLine +
                "                                                  the pri" + Environment.NewLine +
                "                                                  nting a" + Environment.NewLine +
                "                                                  nd type" + Environment.NewLine +
                "                                                  setting" + Environment.NewLine +
                "                                                  industr" + Environment.NewLine +
                "                                                  y      " + Environment.NewLine +
                "---------------------------------------------------------" + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                            Oi!          " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_InsideVerticalBorder()
        {
            const string html = @"<table white-space-border inside-vertical-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "          Produto          |   Unit.   |   Qtd.   |Total " + Environment.NewLine +
                "...................Refeição|   R$ 39.90|0.450 kg  |R$    " + Environment.NewLine +
                "...........................|           |          |17.95 " + Environment.NewLine +
                "Lorem Ipsum is simply dummy|           |          |      " + Environment.NewLine +
                "text of the printing and ty|           |          |      " + Environment.NewLine +
                "pesetting industry         |           |          |      " + Environment.NewLine +
                "Lorem Ipsum is simply dummy|           |          |Lorem " + Environment.NewLine +
                "text of                    |           |          |Ipsum " + Environment.NewLine +
                "                           |           |Lorem Ipsu|is sim" + Environment.NewLine +
                "                           |Lorem Ipsum|m is  type|ply du" + Environment.NewLine +
                "                           |           |setting in|mmy te" + Environment.NewLine +
                "Lorem Ipsum is simply dummy|Lorem      |Lorem Ipsu|Lorem " + Environment.NewLine +
                "Lorem Ipsum is simply dummy|Lorem I    |Lorem Ipsu|Lorem " + Environment.NewLine +
                "text of the printing and ty|           |m Printing|Ipsum " + Environment.NewLine +
                "pesetting industry         |           |and typese|is sim" + Environment.NewLine +
                "                           |           |tting indu|ply du" + Environment.NewLine +
                "                           |           |stry      |mmy te" + Environment.NewLine +
                "                           |           |          |xt of " + Environment.NewLine +
                "                           |           |          |the pr" + Environment.NewLine +
                "                           |           |          |inting" + Environment.NewLine +
                "                           |           |          |and ty" + Environment.NewLine +
                "                           |           |          |pesett" + Environment.NewLine +
                "                           |           |          |ing in" + Environment.NewLine +
                "                           |           |          |dustry" + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |   Oi!    |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      " + Environment.NewLine +
                "                           |           |          |      ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_LeftBorder()
        {
            const string html = @"<table white-space-border left-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "|                                                        " + Environment.NewLine +
                "|         Produto             Unit.       Qtd.    Total  " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|.................Refeição    R$ 39.90 0.450 kg   R$     " + Environment.NewLine +
                "|.........................                        17.95  " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|Lorem Ipsum is simply dum                               " + Environment.NewLine +
                "|my text of the printing a                               " + Environment.NewLine +
                "|nd typesetting industry                                 " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|Lorem Ipsum is simply dum                        Lorem  " + Environment.NewLine +
                "|my text of                            Lorem Ipsu Ipsum  " + Environment.NewLine +
                "|                          Lorem Ipsum m is  type is sim " + Environment.NewLine +
                "|                                      setting in ply du " + Environment.NewLine +
                "|                                      dustry     mmy te " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem  " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem  " + Environment.NewLine +
                "|my text of the printing a             m Printing Ipsum  " + Environment.NewLine +
                "|nd typesetting industry               and typese is sim " + Environment.NewLine +
                "|                                      tting indu ply du " + Environment.NewLine +
                "|                                      stry       mmy te " + Environment.NewLine +
                "|                                                 xt of  " + Environment.NewLine +
                "|                                                 the pr " + Environment.NewLine +
                "|                                                 inting " + Environment.NewLine +
                "|                                                 and ty " + Environment.NewLine +
                "|                                                 pesett " + Environment.NewLine +
                "|                                                 ing in " + Environment.NewLine +
                "|                                                 dustry " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                         Oi!            " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                                        " + Environment.NewLine +
                "|                                                        ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_NoBorder()
        {
            const string html = @"<table no-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "           Produto              Unit.      Qtd.    Total " + Environment.NewLine +
                "......................Refeiçã    R$ 39.90.450 kg  R$     " + Environment.NewLine +
                "..............................                    17.95  " + Environment.NewLine +
                "Lorem Ipsum is simply dummy te                           " + Environment.NewLine +
                "xt of the printing and typeset                           " + Environment.NewLine +
                "ting industry                                            " + Environment.NewLine +
                "Lorem Ipsum is simply dummy te                    Lorem I" + Environment.NewLine +
                "xt of                                             psum is" + Environment.NewLine +
                "                                        Lorem Ipsusimply " + Environment.NewLine +
                "                             Lorem Ipsumis  typesedummy t" + Environment.NewLine +
                "                                        ting indusext of " + Environment.NewLine +
                "Lorem Ipsum is simply dummy tLorem      Lorem IpsuLorem I" + Environment.NewLine +
                "Lorem Ipsum is simply dummy tLorem I    Lorem IpsuLorem I" + Environment.NewLine +
                "xt of the printing and typeset          Printing apsum is" + Environment.NewLine +
                "ting industry                           d typesettsimply " + Environment.NewLine +
                "                                        ng industrdummy t" + Environment.NewLine +
                "                                                  ext of " + Environment.NewLine +
                "                                                  the pri" + Environment.NewLine +
                "                                                  nting a" + Environment.NewLine +
                "                                                  nd type" + Environment.NewLine +
                "                                                  setting" + Environment.NewLine +
                "                                                  industr" + Environment.NewLine +
                "                                                  y      " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                            Oi!          " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_OutsideBorders()
        {
            const string html = @"<table white-space-border outside-borders>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "---------------------------------------------------------" + Environment.NewLine +
                "|         Produto             Unit.       Qtd.    Total |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|.................Refeição    R$ 39.90 0.450 kg   R$    |" + Environment.NewLine +
                "|.........................                        17.95 |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|Lorem Ipsum is simply dum                              |" + Environment.NewLine +
                "|my text of the printing a                              |" + Environment.NewLine +
                "|nd typesetting industry                                |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|Lorem Ipsum is simply dum                        Lorem |" + Environment.NewLine +
                "|my text of                            Lorem Ipsu Ipsum |" + Environment.NewLine +
                "|                          Lorem Ipsum m is  type is sim|" + Environment.NewLine +
                "|                                      setting in ply du|" + Environment.NewLine +
                "|                                      dustry     mmy te|" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem |" + Environment.NewLine +
                "|my text of the printing a             m Printing Ipsum |" + Environment.NewLine +
                "|nd typesetting industry               and typese is sim|" + Environment.NewLine +
                "|                                      tting indu ply du|" + Environment.NewLine +
                "|                                      stry       mmy te|" + Environment.NewLine +
                "|                                                 xt of |" + Environment.NewLine +
                "|                                                 the pr|" + Environment.NewLine +
                "|                                                 inting|" + Environment.NewLine +
                "|                                                 and ty|" + Environment.NewLine +
                "|                                                 pesett|" + Environment.NewLine +
                "|                                                 ing in|" + Environment.NewLine +
                "|                                                 dustry|" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|                                         Oi!           |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "|                                                       |" + Environment.NewLine +
                "---------------------------------------------------------";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_RightBorder()
        {
            const string html = @"<table white-space-border right-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "                                                        |" + Environment.NewLine +
                "          Produto             Unit.       Qtd.    Total |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                " .................Refeição    R$ 39.90 0.450 kg   R$    |" + Environment.NewLine +
                " .........................                        17.95 |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                " Lorem Ipsum is simply dum                              |" + Environment.NewLine +
                " my text of the printing a                              |" + Environment.NewLine +
                " nd typesetting industry                                |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                " Lorem Ipsum is simply dum                        Lorem |" + Environment.NewLine +
                " my text of                            Lorem Ipsu Ipsum |" + Environment.NewLine +
                "                           Lorem Ipsum m is  type is sim|" + Environment.NewLine +
                "                                       setting in ply du|" + Environment.NewLine +
                "                                       dustry     mmy te|" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem |" + Environment.NewLine +
                " my text of the printing a             m Printing Ipsum |" + Environment.NewLine +
                " nd typesetting industry               and typese is sim|" + Environment.NewLine +
                "                                       tting indu ply du|" + Environment.NewLine +
                "                                       stry       mmy te|" + Environment.NewLine +
                "                                                  xt of |" + Environment.NewLine +
                "                                                  the pr|" + Environment.NewLine +
                "                                                  inting|" + Environment.NewLine +
                "                                                  and ty|" + Environment.NewLine +
                "                                                  pesett|" + Environment.NewLine +
                "                                                  ing in|" + Environment.NewLine +
                "                                                  dustry|" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                          Oi!           |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                                        |" + Environment.NewLine +
                "                                                        |";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_TopBorder()
        {
            const string html = @"<table white-space-border top-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "---------------------------------------------------------" + Environment.NewLine +
                "          Produto             Unit.       Qtd.    Total  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " .................Refeição    R$ 39.90 0.450 kg   R$     " + Environment.NewLine +
                " .........................                        17.95  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum                               " + Environment.NewLine +
                " my text of the printing a                               " + Environment.NewLine +
                " nd typesetting industry                                 " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum                        Lorem  " + Environment.NewLine +
                " my text of                            Lorem Ipsu Ipsum  " + Environment.NewLine +
                "                           Lorem Ipsum m is  type is sim " + Environment.NewLine +
                "                                       setting in ply du " + Environment.NewLine +
                "                                       dustry     mmy te " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem  " + Environment.NewLine +
                " my text of the printing a             m Printing Ipsum  " + Environment.NewLine +
                " nd typesetting industry               and typese is sim " + Environment.NewLine +
                "                                       tting indu ply du " + Environment.NewLine +
                "                                       stry       mmy te " + Environment.NewLine +
                "                                                  xt of  " + Environment.NewLine +
                "                                                  the pr " + Environment.NewLine +
                "                                                  inting " + Environment.NewLine +
                "                                                  and ty " + Environment.NewLine +
                "                                                  pesett " + Environment.NewLine +
                "                                                  ing in " + Environment.NewLine +
                "                                                  dustry " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                          Oi!            " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_WhiteSpaceBorder()
        {
            const string html = @"<table white-space-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "                                                         " + Environment.NewLine +
                "          Produto             Unit.       Qtd.    Total  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " .................Refeição    R$ 39.90 0.450 kg   R$     " + Environment.NewLine +
                " .........................                        17.95  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum                               " + Environment.NewLine +
                " my text of the printing a                               " + Environment.NewLine +
                " nd typesetting industry                                 " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum                        Lorem  " + Environment.NewLine +
                " my text of                            Lorem Ipsu Ipsum  " + Environment.NewLine +
                "                           Lorem Ipsum m is  type is sim " + Environment.NewLine +
                "                                       setting in ply du " + Environment.NewLine +
                "                                       dustry     mmy te " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem  " + Environment.NewLine +
                " my text of the printing a             m Printing Ipsum  " + Environment.NewLine +
                " nd typesetting industry               and typese is sim " + Environment.NewLine +
                "                                       tting indu ply du " + Environment.NewLine +
                "                                       stry       mmy te " + Environment.NewLine +
                "                                                  xt of  " + Environment.NewLine +
                "                                                  the pr " + Environment.NewLine +
                "                                                  inting " + Environment.NewLine +
                "                                                  and ty " + Environment.NewLine +
                "                                                  pesett " + Environment.NewLine +
                "                                                  ing in " + Environment.NewLine +
                "                                                  dustry " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                          Oi!            " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mixed_WhiteSpaceVerticalBorder()
        {
            const string html = @"<table white-space-vertical-border>
	                                  <tr>
		                                  <td text-center width='4*'>Produto</td>
		                                  <td text-center width='auto'>Unit.</td>
		                                  <td text-center width='10'>Qtd.</td>
		                                  <td text-center width='*'>Total</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-right pad-value='.'>Refeição</td>
		                                  <td text-right>R$ 39.90</td>
		                                  <td text-left>0.450 kg</td>
		                                  <td text-left>R$ 17.95</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td></td>
		                                  <td></td>
		                                  <td></td>
	                                  </tr>
	                                  <tr height='5'>
		                                  <td text-top>Lorem Ipsum is simply dummy text of</td>
		                                  <td text-middle>Lorem Ipsum</td>
		                                  <td text-bottom>Lorem Ipsum is  typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='1'>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is</td>
	                                  </tr>
	                                  <tr>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
		                                  <td text-justified>Lorem I</td>
		                                  <td text-justified>Lorem Ipsum Printing and typesetting industry</td>
		                                  <td text-justified>Lorem Ipsum is simply dummy text of the printing and typesetting industry</td>
	                                  </tr>
	                                  <tr height='7'>
		                                  <td></td>
		                                  <td></td>
		                                  <td text-center text-middle>Oi!</td>
		                                  <td></td>
	                                  </tr>
                                  </table>";

            var tableGridRender = new TableGridRender(html);

            var actual = tableGridRender.Render(57);
            var expected =
                "          Produto             Unit.       Qtd.    Total  " + Environment.NewLine +
                " .................Refeição    R$ 39.90 0.450 kg   R$     " + Environment.NewLine +
                " .........................                        17.95  " + Environment.NewLine +
                " Lorem Ipsum is simply dum                               " + Environment.NewLine +
                " my text of the printing a                               " + Environment.NewLine +
                " nd typesetting industry                                 " + Environment.NewLine +
                " Lorem Ipsum is simply dum                        Lorem  " + Environment.NewLine +
                " my text of                                       Ipsum  " + Environment.NewLine +
                "                                       Lorem Ipsu is sim " + Environment.NewLine +
                "                           Lorem Ipsum m is  type ply du " + Environment.NewLine +
                "                                       setting in mmy te " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem       Lorem Ipsu Lorem  " + Environment.NewLine +
                " Lorem Ipsum is simply dum Lorem I     Lorem Ipsu Lorem  " + Environment.NewLine +
                " my text of the printing a             m Printing Ipsum  " + Environment.NewLine +
                " nd typesetting industry               and typese is sim " + Environment.NewLine +
                "                                       tting indu ply du " + Environment.NewLine +
                "                                       stry       mmy te " + Environment.NewLine +
                "                                                  xt of  " + Environment.NewLine +
                "                                                  the pr " + Environment.NewLine +
                "                                                  inting " + Environment.NewLine +
                "                                                  and ty " + Environment.NewLine +
                "                                                  pesett " + Environment.NewLine +
                "                                                  ing in " + Environment.NewLine +
                "                                                  dustry " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                          Oi!            " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";

            Assert.AreEqual(expected, actual);
        }
    }
}