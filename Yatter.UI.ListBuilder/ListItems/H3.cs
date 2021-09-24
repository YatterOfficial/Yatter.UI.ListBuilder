using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// Heading of Third Magnitude
    /// </summary>
    public class H3 : TextBase
    {
        public string Text { get; set; }

        public H3() : base(margin: "10px 10px 10px 10px")
        {
            DataType = "H3";
            Visibility = "visible";
        }

        public H3(string margin) : base(margin)
        {
            DataType = "H3";
            Visibility = "visible";
        }

        public H3(string margin, string padding) : base(margin, padding)
        {
            DataType = "H3";
            Visibility = "visible";
        }

        public H3(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = "H3";
            Visibility = "visible";
        }

        public H3(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = "H3";
            Visibility = "visible";
        }

        public H3(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = "H3";
            Visibility = "visible";
        }

        public H3(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = "H3";
            Visibility = "visible";
        }
    }
}
