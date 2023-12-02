namespace JWT.Builder
{
    /// <summary>
    /// JWT header model (without JSON serialization annotations),
    /// The Unisave Framework Light Json JWT serializer will translate
    /// the field names properly.
    /// </summary>
    public class JwtHeader
    {
        public string Type { get; set; }
        public string ContentType { get; set; }
        public string Algorithm { get; set; }
        public string KeyId { get; set; }
        public string X5u { get; set; }
        public string[] X5c { get; set; }
        public string X5t { get; set; }
    }
}