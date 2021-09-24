using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// An interface for casting to get the Validation properties
    /// </summary>
    public interface IValidation
    {
        string InputConstraint { get; set; }
        string ValidationMessage { get; set; }
        string TypeConstraint { get; set; }
    }
}
