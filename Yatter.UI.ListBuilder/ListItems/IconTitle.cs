using System;
using Newtonsoft.Json;

namespace Yatter.UI.ListBuilder.ListItems
{
    public class IconTitle : TextBase, IDataType
    {
        public new string DataType { get; set; }

        public string IconBase64 { get; set; }
        public string ImageType { get; set; }


        public string Text { get; set; }
        public string TextMargin
        {
            get
            {
                return $"{MarginTop} {MarginRight} {MarginBottom} {MarginLeft}";
            }
            set
            {
                value = value.Trim();
                if (!value.Contains(",") && value.Contains("px"))
                {
                    var split = value.Split(" ");
                    if (split.Length == 4)
                    {
                        MarginTop = split[0];
                        MarginRight = split[1];
                        MarginBottom = split[2];
                        MarginLeft = split[3];
                    }
                }
            }
        }

        private string _headingType = "h1";
        public string HeadingType
        {
            get
            {
                return _headingType;
            }
            set
            {
                if(value.ToLower().Equals("h1")|| value.ToLower().Equals("h2") || value.ToLower().Equals("h3") || value.ToLower().Equals("h4") || value.ToLower().Equals("h5"))
                {
                    _headingType = value.ToLower();
                }
            }
        }

        private string _textVerticalAlign = "middle";
        public string TextVerticalAlign
        {
            get
            {
                return _textVerticalAlign;
            }
            set
            {
                if(value.ToLower().Equals("top")||value.ToLower().Equals("middle")||value.ToLower().Equals("bottom"))
                {
                    _textVerticalAlign = value.ToLower();
                }
            }

        }



        public IconTitle() : base(margin: "10px 10px 10px 10px")
        {
            DataType = GetType().ToString();
            Visibility = "visible";
        }

        [JsonIgnore]
        public string MarginLeft { get; set; } = "10px";
        [JsonIgnore]
        public string MarginRight { get; set; } = "10px";
        [JsonIgnore]
        public string MarginTop { get; set; } = "0px";
        [JsonIgnore]
        public string MarginBottom { get; set; } = "0px";
    }
}

