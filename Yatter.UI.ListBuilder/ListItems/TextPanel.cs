using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    public class TextPanel : TextBase, IDataType
    {
        public new string DataType { get; set; }

        public string Text { get; set; }
        public string BackgroundColor { get; set; }

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

        public TextPanel() : base(margin: "0px 0px 0px 0px")
        {
            DataType = GetType().ToString();
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public TextPanel(string margin) : base(margin)
        {
            DataType = "TextPanel";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public TextPanel(string margin, string padding) : base(margin, padding)
        {
            DataType = "TextPanel";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public TextPanel(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = "TextPanel";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public TextPanel(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = "TextPanel";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public TextPanel(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = "TextPanel";
            Visibility = "visible";
            LineBreakMode = "normal";
        }

        public TextPanel(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = "TextPanel";
            Visibility = "visible";
            LineBreakMode = "normal";
        }
    }
}

