using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    public class WebPage : TextBase, IDataType
    {
        public string Url { get; set; }

        public WebPage()
        {
            DataType = GetType().ToString();
        }
    }
}

