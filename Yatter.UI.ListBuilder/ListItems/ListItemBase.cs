using System;
using Newtonsoft.Json;

namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// The base class of all List Items.
    /// </summary>
    public abstract class ListItemBase : IListItemBase
    {
        #region IListBase
        public string DataType { get; set; }

        [JsonIgnore]
        public string Margin
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
        [JsonIgnore]
        public string MarginLeft { get; set; }
        [JsonIgnore]
        public string MarginRight { get; set; }
        [JsonIgnore]
        public string MarginTop { get; set; }
        [JsonIgnore]
        public string MarginBottom { get; set; }

        [JsonIgnore]
        public string Padding
        {
            get
            {
                return $"{PaddingTop} {PaddingRight} {PaddingBottom} {PaddingLeft}";
            }
            set
            {
                value = value.Trim();
                if (!value.Contains(",") && value.Contains("px"))
                {
                    var split = value.Split(" ");
                    if (split.Length == 4)
                    {
                        PaddingTop = split[0];
                        PaddingRight = split[1];
                        PaddingBottom = split[2];
                        PaddingLeft = split[3];
                    }
                }
            }
        }
        [JsonIgnore]
        public string PaddingLeft { get; set; }
        [JsonIgnore]
        public string PaddingRight { get; set; }
        [JsonIgnore]
        public string PaddingTop { get; set; }
        [JsonIgnore]
        public string PaddingBottom { get; set; }

        private string _visibility;
        public string Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                if
                (value.Equals("visible")
                 || value.Equals("collapse")
                 || value.Equals("hidden")
                 || value.Equals("initial")
                 || value.Equals("inherit")
                )
                {
                    _visibility = value;
                }
                else
                {
                    _visibility = "visible";
                }
            }
        }

        #endregion

        public ListItemBase()
        {
            Margin = "10px 0px 10px 0px";
            Padding = "0px 0px 0px 0px";
        }

        public ListItemBase(string margin)
        {
            if (!margin.Contains(",") && margin.Contains("px"))
            {
                Margin = margin;
            }
        }

        public ListItemBase(string margin, string padding)
        {
            if (!margin.Contains(",") && margin.Contains("px"))
            {
                Margin = margin;
            }

            if (!padding.Contains(",") && padding.Contains("px"))
            {
                Padding = padding;
            }
        }

        public ListItemBase(string marginTop, string marginRight, string marginBottom, string marginLeft)
        {
            if (marginTop.Contains("px") && marginRight.Contains("px") && marginBottom.Contains("px") && marginLeft.Contains("px"))
            {
                MarginTop = marginTop;
                MarginRight = marginRight;
                MarginBottom = marginBottom;
                MarginLeft = marginLeft;
            }
        }

        public ListItemBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft)
        {
            if (marginTop.Contains("px") && marginRight.Contains("px") && marginBottom.Contains("px") && marginLeft.Contains("px") && paddingTop.Contains("px") && paddingRight.Contains("px") && paddingBottom.Contains("px") && paddingLeft.Contains("px"))
            {
                MarginTop = marginTop;
                MarginRight = marginRight;
                MarginBottom = marginBottom;
                MarginLeft = marginLeft;

                PaddingTop = paddingTop;
                PaddingRight = paddingRight;
                PaddingBottom = paddingBottom;
                PaddingLeft = paddingLeft;
            }
        }
    }
}
