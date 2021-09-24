using System;
using Newtonsoft.Json;

namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// The base class of Text Items
    /// </summary>
    public class TextBase : ListItemBase
    {
        public string TextColor { get; set; }

        public TextBase()
        {
            TextColor = "#000000";
        }

        public TextBase(string margin) : base(margin)
        {
            TextColor = "#000000";
        }

        public TextBase(string margin, string padding) : base(margin, padding)
        {
            TextColor = "#000000";
        }

        public TextBase(string margin, string padding, string textColor) : base(margin, padding)
        {
            TextColor = textColor;
        }

        public TextBase(string marginTop, string marginRight, string marginBottom, string marginLeft) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft}")
        {
            TextColor = "#000000";
        }

        public TextBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft}")
        {
            TextColor = textColor;
        }

        public TextBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft} {paddingTop} {paddingRight} {paddingBottom} {paddingLeft}")
        {
            TextColor = "#000000";
        }

        public TextBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft} {paddingTop} {paddingRight} {paddingBottom} {paddingLeft}")
        {
            TextColor = textColor;
        }
    }
}
