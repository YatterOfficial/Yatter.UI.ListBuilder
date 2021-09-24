using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// A list item that displays and image that is in Base64, either jpg or png.
    /// </summary>
    public class Base64Image : ImageBase
    {
        public string Base64 { get; set; }

        private string _imagetype { get; set; }
        public string ImageType
        {
            get
            {
                return _imagetype;
            }
            set
            {
                if
                (value.Equals("png")
                 || value.Equals("jpg")
                )
                {
                    _imagetype = value;
                }
                else
                {
                    _imagetype = "png";
                }
            }
        }

        public Base64Image() : base(margin: "0px 0px 0px 0px")
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }

        public Base64Image(string margin) : base(margin)
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }

        public Base64Image(string margin, string padding) : base(margin, padding)
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }

        public Base64Image(string marginTop, string marginRight, string marginBottom, string marginLeft) : base(marginTop, marginRight, marginBottom, marginLeft)
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }

        public Base64Image(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, textColor)
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }

        public Base64Image(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft)
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }

        public Base64Image(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base(marginTop, marginRight, marginBottom, marginLeft, paddingTop, paddingRight, paddingBottom, paddingLeft, textColor)
        {
            DataType = "Base64Image";
            Visibility = "visible";
        }
    }
}
