using System;
using Newtonsoft.Json;

namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// Heading of First Magnitude
    /// </summary>
    public class H1 : TextBase
    {
        public string Text { get; set; }

        public H1() : base(margin: "10px 10px 10px 10px")
        {
            DataType = "H1";
            Visibility = "visible";
        }

        public H1(string margin) : base(margin)
        {
            DataType = "H1";
            Visibility = "visible";
        }

        public H1(string margin, string padding) : base(margin, padding)
        {
            DataType = "H1";
            Visibility = "visible";
        }

        public H1(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = "H1";
            Visibility = "visible";
        }

        public H1(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = "H1";
            Visibility = "visible";
        }

        public H1(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = "H1";
            Visibility = "visible";
        }

        public H1(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = "H1";
            Visibility = "visible";
        }
    }



}
