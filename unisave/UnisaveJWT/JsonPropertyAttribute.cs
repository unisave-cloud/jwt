using System;

namespace Newtonsoft.Json
{
    internal class JsonPropertyAttribute : Attribute
    {
        // exists just so that I don't have to modify the
        // JwtBuilder.GetPropName method
        
        // is not used
        
        public string PropertyName { get; }
    }
}