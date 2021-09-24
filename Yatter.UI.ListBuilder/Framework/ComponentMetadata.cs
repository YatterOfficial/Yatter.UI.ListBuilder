using System;
using System.Collections.Generic;

namespace Yatter.UI.ListBuilder.Framework
{
    public class ComponentMetadata
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
    }
}

