using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Extensions
{
    public static class SyndicationItemExtensions
    {
        public static bool ApplyDefaultFilter(this SyndicationItem item)
        {
            var hasPowerShellCategory = false;

            if (item.Categories.Count > 0)
                hasPowerShellCategory = item.Categories.Any(category =>
                    category.Name.ToLowerInvariant().Contains("powershell"));

            var hasPowerShellTitle = item.Title?.Text.ToLowerInvariant().Contains("powershell") ?? false;

            return hasPowerShellTitle || hasPowerShellCategory;
        }
    }
}