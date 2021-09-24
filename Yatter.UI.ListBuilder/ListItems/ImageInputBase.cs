using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    /// <summary>
    /// The base class of input image items (for example, images captured by the camera, or similar image input device).
    /// </summary>
    public class ImageInputBase : ImageBase, IValidation
    {
        public string InputConstraint { get; set; }
        public string ValidationMessage { get; set; }
        public string TypeConstraint { get; set; }
    }
}
