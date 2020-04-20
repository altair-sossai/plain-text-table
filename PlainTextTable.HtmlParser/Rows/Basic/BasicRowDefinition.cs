using HtmlAgilityPack;
using PlainTextTable.Grid;
using PlainTextTable.HtmlParser.Extensions;

namespace PlainTextTable.HtmlParser.Rows.Basic
{
    public class BasicRowDefinition : RowDefinition
    {
        public BasicRowDefinition(HtmlNode htmlNode)
            : this(null, htmlNode)
        {
        }

        public BasicRowDefinition(RowDefinition father, HtmlNode htmlNode)
        {
            HeightType = htmlNode.HeightType(father?.HeightType ?? HeightType);
            Height = htmlNode.Height(father?.Height ?? Height);
        }
    }
}