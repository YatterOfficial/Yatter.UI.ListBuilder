using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    public class Wasm : ListItemBase, IDataType
    {
        public new string DataType { get; set; }

        public Wasm()
        {
            DataType = GetType().ToString();
            Visibility = "visible";
        }

        public double? HeightWidthRatio { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? IndexBase64 { get; set; }
        public string? WasmBase64 { get; set; }
        public string? DataBase64 { get; set; }
        public string? JavascriptBase64 { get; set; }
    }
}

