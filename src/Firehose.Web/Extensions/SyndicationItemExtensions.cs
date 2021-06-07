using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Extensions
{
    public static class SyndicationItemExtensions
    {
        public static bool ApplyDefaultFilter(this SyndicationItem item)
        {
            if (item == null)
                return false;

            var hasPowerShellCategory = false;
            var hasPowerShellKeywords = false;

            if (item.Categories.Count > 0)
            {
                hasPowerShellCategory = item.Categories.Any(category =>
                    category.Name.ToLowerInvariant().Contains("powershell"));
            }

            if (item.ElementExtensions.Count > 0)
            {
                var element = item.ElementExtensions.FirstOrDefault(e => e.OuterName == "keywords");
                if (element != null)
                {
                    var keywords = element.GetObject<string>();
                    hasPowerShellKeywords = keywords.ToLowerInvariant().Contains("powershell");
                }
            }

            var hasPowerShellTitle = item.Title?.Text.ToLowerInvariant().Contains("powershell") ?? false;

            return hasPowerShellTitle || hasPowerShellCategory || hasPowerShellKeywords;
        }

		public static string ToHtml(this SyndicationContent content)
		{
			var textSyndicationContent = content as TextSyndicationContent;
			if (textSyndicationContent != null)
			{
				return textSyndicationContent.Text;
			}

			return content.ToString();
		}
	}
}