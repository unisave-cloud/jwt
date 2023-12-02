using System;

namespace JWT.Serializers
{
    internal class JsonNetSerializer : IJsonSerializer
    {
        // exists just so that I don't have to modify the
        // JwtBuilder.GetPropName method
        
        // is not used

        public string Serialize(object obj)
            => throw new InvalidOperationException("Dummy class, not implemented.");

        public object Deserialize(Type type, string json)
            => throw new InvalidOperationException("Dummy class, not implemented.");
    }
}