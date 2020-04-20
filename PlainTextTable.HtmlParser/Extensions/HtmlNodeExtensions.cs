using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using PlainTextTable.Enums;
using PlainTextTable.Extensions;
using PlainTextTable.HtmlParser.Styles;
using PlainTextTable.Styles;

namespace PlainTextTable.HtmlParser.Extensions
{
    public static class HtmlNodeExtensions
    {
        public static char? PadValue(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("pad-value", defaultValue);
        }

        public static HorizontalAlign HorizontalAlign(this HtmlNode htmlNode, HorizontalAlign defaultValue)
        {
            if (htmlNode.ContainsAttributes("text-justified"))
                return Enums.HorizontalAlign.Justified;

            if (htmlNode.ContainsAttributes("text-left"))
                return Enums.HorizontalAlign.Left;

            if (htmlNode.ContainsAttributes("text-center"))
                return Enums.HorizontalAlign.Center;

            if (htmlNode.ContainsAttributes("text-right"))
                return Enums.HorizontalAlign.Right;

            return defaultValue;
        }

        public static VerticalAlign VerticalAlign(this HtmlNode htmlNode, VerticalAlign defaultValue)
        {
            if (htmlNode.ContainsAttributes("text-top"))
                return Enums.VerticalAlign.Top;

            if (htmlNode.ContainsAttributes("text-middle"))
                return Enums.VerticalAlign.Middle;

            if (htmlNode.ContainsAttributes("text-bottom"))
                return Enums.VerticalAlign.Bottom;

            return defaultValue;
        }

        public static WidthType WidthType(this HtmlNode htmlNode, WidthType defaultValue)
        {
            if (!htmlNode.ContainsAttributes("width"))
                return defaultValue;

            var attribute = htmlNode.Attributes["width"];
            if (string.IsNullOrEmpty(attribute.Value))
                return defaultValue;

            if (attribute.Value.Equals("auto", StringComparison.CurrentCultureIgnoreCase))
                return Enums.WidthType.Auto;

            if (attribute.Value.IsDigitsOnly())
                return Enums.WidthType.Fixed;

            if (attribute.Value.Contains('*'))
                return Enums.WidthType.Star;

            return defaultValue;
        }

        public static int Width(this HtmlNode htmlNode, int defaultValue)
        {
            if (!htmlNode.ContainsAttributes("width"))
                return defaultValue;

            var attribute = htmlNode.Attributes["width"];
            if (string.IsNullOrEmpty(attribute.Value))
                return defaultValue;

            if (attribute.Value.Equals("auto", StringComparison.CurrentCultureIgnoreCase))
                return 1;

            if (attribute.Value.IsDigitsOnly())
                return int.Parse(attribute.Value);

            if (attribute.Value.Contains('*'))
            {
                var numbers = attribute.Value.Where(char.IsDigit);
                var value = string.Join(string.Empty, numbers);

                return string.IsNullOrEmpty(value) ? 1 : int.Parse(value);
            }

            return defaultValue;
        }

        public static HeightType HeightType(this HtmlNode htmlNode, HeightType defaultValue)
        {
            if (!htmlNode.ContainsAttributes("height"))
                return defaultValue;

            var attribute = htmlNode.Attributes["height"];
            if (string.IsNullOrEmpty(attribute.Value))
                return defaultValue;

            if (attribute.Value.Equals("auto", StringComparison.CurrentCultureIgnoreCase))
                return Enums.HeightType.Auto;

            if (attribute.Value.IsDigitsOnly())
                return Enums.HeightType.Fixed;

            return defaultValue;
        }

        public static int Height(this HtmlNode htmlNode, int defaultValue)
        {
            if (!htmlNode.ContainsAttributes("height"))
                return defaultValue;

            var attribute = htmlNode.Attributes["height"];
            if (string.IsNullOrEmpty(attribute.Value))
                return defaultValue;

            if (attribute.Value.Equals("auto", StringComparison.CurrentCultureIgnoreCase))
                return 1;

            if (attribute.Value.IsDigitsOnly())
                return int.Parse(attribute.Value);

            return defaultValue;
        }

        public static char? Border(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border", defaultValue);
        }

        public static char? Corner(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("corner", defaultValue);
        }

        public static char? Edge(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("edge", defaultValue);
        }

        public static char? BorderLeft(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-left", defaultValue);
        }

        public static char? BorderTop(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-top", defaultValue);
        }

        public static char? BorderRight(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-right", defaultValue);
        }

        public static char? BorderBottom(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-bottom", defaultValue);
        }

        public static char? BorderTopLeft(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-top-left", defaultValue);
        }

        public static char? BorderTopRight(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-top-right", defaultValue);
        }

        public static char? BorderBottomRight(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-bottom-right", defaultValue);
        }

        public static char? BorderBottomLeft(this HtmlNode htmlNode, char? defaultValue)
        {
            return htmlNode.CharValue("border-bottom-left", defaultValue);
        }

        public static IEnumerable<IBorderStyle> BorderStyles(this HtmlNode htmlNode)
        {
            var styles = new List<IBorderStyle>();

            if (htmlNode?.Attributes == null)
                return styles;

            foreach (var attribute in htmlNode.Attributes)
            {
                if (StylesDictionary.Contains(attribute.Name))
                    styles.Add(StylesDictionary.Get(attribute.Name));
            }

            return styles;
        }

        private static char? CharValue(this HtmlNode htmlNode, string attributeName, char? defaultValue)
        {
            if (!htmlNode.ContainsAttributes(attributeName))
                return defaultValue;

            var attribute = htmlNode.Attributes[attributeName];

            return string.IsNullOrEmpty(attribute.Value) ? defaultValue : attribute.Value.First();
        }

        private static bool ContainsAttributes(this HtmlNode htmlNode, string attributeName)
        {
            return htmlNode?.Attributes != null && htmlNode.Attributes.Contains(attributeName);
        }

        public static List<HtmlNode> Nodes(this HtmlNode htmlNode, string tag)
        {
            return htmlNode.ChildNodes
                .Where(w => w.Name.Equals(tag, StringComparison.CurrentCultureIgnoreCase))
                .ToList();
        }

        public static HtmlNode FirstOrDefault(this HtmlNode htmlNode, string tag)
        {
            return htmlNode.ChildNodes
                .FirstOrDefault(w => w.Name.Equals(tag, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}