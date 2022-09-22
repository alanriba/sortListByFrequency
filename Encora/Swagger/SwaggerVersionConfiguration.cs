using System.Diagnostics.CodeAnalysis;

namespace Encora.Swagger
{
    [ExcludeFromCodeCoverage]
    public class SwaggerVersionConfiguration
    {
        public string Version { get; set; }
        public string EndpointUrl { get; set; }
        public string EndpointDescription { get; set; }
    }
}