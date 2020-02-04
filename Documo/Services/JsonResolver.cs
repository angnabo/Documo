using Pather.CSharp;

namespace Documo.Services
{
    public static class JsonResolver
    {
        public static object Resolve(object jsonData, string path)
        {
            var resolver = new Resolver();
            return resolver.Resolve(jsonData, path);
        }
    }
}