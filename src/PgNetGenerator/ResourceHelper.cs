using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PgNetGenerator
{
    public static class ResourceHelper
    {
        public static async Task<string> GetString(string resourceName)
        {
            var assembly = Assembly.GetEntryAssembly();
            
            var resourceStream = assembly.GetManifestResourceStream($"{typeof(ResourceHelper).Namespace}.{resourceName}");
            
            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}