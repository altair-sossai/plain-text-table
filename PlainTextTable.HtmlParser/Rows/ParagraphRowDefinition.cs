using HtmlAgilityPack;
using PlainTextTable.HtmlParser.Rows.Basic;

namespace PlainTextTable.HtmlParser.Rows
{
    public class ParagraphRowDefinition : BasicRowDefinition
    {
        public ParagraphRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}