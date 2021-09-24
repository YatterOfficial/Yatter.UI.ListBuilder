using System;

namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// A single line textbox for entering text.
    /// </summary>
    public class Entry : TextInputBase, IDataType
    {
        public new string DataType { get; set; }

        public string Text { get; set; }
        public string Placeholder { get; set; }

        public Entry() : base(margin: "10px 10px 10px 10px")
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }

        public Entry(string margin) : base(margin)
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }

        public Entry(string margin, string padding) : base(margin, padding)
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }

        public Entry(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }

        public Entry(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }

        public Entry(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }

        public Entry(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            Placeholder = string.Empty;
        }
    }
}
