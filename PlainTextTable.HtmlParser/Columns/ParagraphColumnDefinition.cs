using HtmlAgilityPack;
using PlainTextTable.HtmlParser.Columns.Basic;

namespace PlainTextTable.HtmlParser.Columns
{
    public class ParagraphColumnDefinition : BasicColumnDefinition
    {
        public ParagraphColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}