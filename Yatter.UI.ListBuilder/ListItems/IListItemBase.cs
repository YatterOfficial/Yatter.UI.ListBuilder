using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// An interface for casting to get the properties of a ListItemBase
    /// </summary>
    public interface IListItemBase
    {
        string DataType { get; set; }
        string Visibility { get; set; }
    }
}
