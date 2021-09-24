using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// The base class of image items.
    /// </summary>
    public class ImageBase : ListItemBase
    {
        private string _altText;
        public string AltText
        {
            get
            {
                if (string.IsNullOrEmpty(_altText))
                {
                    _altText = string.Empty;
                }
                return _altText;
            }

            set
            {
                _altText = value;
            }

        }

        public ImageBase() : base("0px 0px 0px 0px")
        {
            AltText = string.Empty;
        }

        public ImageBase(string margin) : base(margin)
        {
            AltText = string.Empty;
        }

        public ImageBase(string margin, string padding) : base(margin, padding)
        {
            AltText = string.Empty;
        }

        public ImageBase(string margin, string padding, string altText) : base(margin, padding)
        {
            AltText = altText;
        }

        public ImageBase(string marginTop, string marginRight, string marginBottom, string marginLeft) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft}")
        {
            AltText = string.Empty;
        }

        public ImageBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string altText) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft}")
        {
            AltText = altText;
        }

        public ImageBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft} {paddingTop} {paddingRight} {paddingBottom} {paddingLeft}")
        {
            AltText = string.Empty;
        }

        public ImageBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string altText) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft} {paddingTop} {paddingRight} {paddingBottom} {paddingLeft}")
        {
            AltText = altText;
        }
    }
}
