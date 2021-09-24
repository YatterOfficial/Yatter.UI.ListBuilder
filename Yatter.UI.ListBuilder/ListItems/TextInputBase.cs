using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// The base class of Text Input Items.
    /// </summary>
    public class TextInputBase : TextBase, IValidation
    {
        public string InputConstraint { get; set; }
        public string ValidationMessage { get; set; }
        public string TypeConstraint { get; set; }

        public TextInputBase()
        {
            TextColor = "#FFFFFF";
        }

        public TextInputBase(string margin) : base(margin)
        {
            TextColor = "#FFFFFF";
        }

        public TextInputBase(string margin, string padding) : base(margin, padding)
        {
            TextColor = "#FFFFFF";
        }

        public TextInputBase(string margin, string padding, string textColor) : base(margin, padding, textColor)
        {

        }

        public TextInputBase(string marginTop, string marginRight, string marginBottom, string marginLeft) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft}")
        {
            TextColor = "#FFFFFF";
        }

        public TextInputBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string textColor) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft}")
        {
            TextColor = textColor;
        }

        public TextInputBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft} {paddingTop} {paddingRight} {paddingBottom} {paddingLeft}")
        {
            TextColor = "#FFFFFF";
        }

        public TextInputBase(string marginTop, string marginRight, string marginBottom, string marginLeft, string paddingTop, string paddingRight, string paddingBottom, string paddingLeft, string textColor) : base($"{marginTop} {marginRight} {marginBottom} {marginLeft} {paddingTop} {paddingRight} {paddingBottom} {paddingLeft}")
        {
            TextColor = textColor;
        }
    }
}
