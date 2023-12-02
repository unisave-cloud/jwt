using System;

namespace JWT.Serializers
{
    public sealed class DefaultJsonSerializerFactory : IJsonSerializerFactory
    {
        public IJsonSerializer Create()
        {
            throw new InvalidOperationException(
                "UnisaveJWT has no default JSON serializer. You need to use " +
                "the LightJson serializer from the Unisave Framework."
            );
        }
    }
}