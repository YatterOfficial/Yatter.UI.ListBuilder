using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// Heading of Second Magnitude
    /// </summary>
    public class H2 : TextBase
    {
        public string Text { get; set; }

        public H2() : base(margin: "10px 10px 10px 10px")
        {
            DataType = "H2";
            Visibility = "visible";
        }

        public H2(string margin) : base(margin)
        {
            DataType = "H2";
            Visibility = "visible";
        }

        public H2(string margin, string padding) : base(margin, padding)
        {
            DataType = "H2";
            Visibility = "visible";
        }

        public H2(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = "H2";
            Visibility = "visible";
        }

        public H2(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = "H2";
            Visibility = "visible";
        }

        public H2(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = "H2";
            Visibility = "visible";
        }

        public H2(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = "H2";
            Visibility = "visible";
        }
    }
}
