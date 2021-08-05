namespace Api.Extensions
{
    internal class TokenValidationParameters : Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        public bool ValidateIssuer { get; set; }
        public object ValidIssuer { get; set; }
        public bool ValidateAudience { get; set; }
        public object ValidAudience { get; set; }
        public bool ValidateLifetime { get; set; }
        public object IssuerSigningKey { get; set; }
        public bool ValidateIssuerSigningKey { get; set; }
    }
}