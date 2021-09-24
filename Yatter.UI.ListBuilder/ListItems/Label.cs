using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// A list item that displays a single line of text, or wrapped lines of text.
    /// </summary>
    public class Label : TextBase
    {
        public string Text { get; set; }

        private string _lineBreakMode;
        public string LineBreakMode
        {
            get
            {
                return _lineBreakMode;
            }

            set
            {
                if
                (value.Equals("normal")
                 || value.Equals("nowrap")
                )
                {
                    _lineBreakMode = value;
                }
                else
                {
                    _lineBreakMode = "normal";
                }
            }
        }

        public Label() : base(margin: "10px 10px 10px 10px")
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public Label(string margin) : base(margin)
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public Label(string margin, string padding) : base(margin, padding)
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public Label(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public Label(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public Label(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public Label(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = "Label";
            Visibility = "visible";
            LineBreakMode = "normal";
        }
    }
}
