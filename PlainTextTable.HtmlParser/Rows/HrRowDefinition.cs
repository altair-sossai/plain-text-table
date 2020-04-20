using HtmlAgilityPack;
using PlainTextTable.Enums;
using PlainTextTable.HtmlParser.Rows.Basic;

namespace PlainTextTable.HtmlParser.Rows
{
    public class HrRowDefinition : BasicRowDefinition
    {
        public HrRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            HeightType = HeightType.Auto;
            Height = 1;
        }
    }
}