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
            var hasPWSHCategory = false;
            var hasPWSHKeywords = false;

            if (item.Categories.Count > 0)
            {
                hasPowerShellCategory = item.Categories.Any(category =>
                    category.Name.ToLowerInvariant().Contains("powershell"));

                hasPWSHCategory = item.Categories.Any(category =>
                    category.Name.ToLowerInvariant().Contains("pwsh"));
            }

            if (item.ElementExtensions.Count > 0)
            {
                var element = item.ElementExtensions.FirstOrDefault(e => e.OuterName == "keywords");
                if (element != null)
                {
                    var keywords = element.GetObject<string>();
                    hasPowerShellKeywords = keywords.ToLowerInvariant().Contains("powershell");
                    hasPWSHKeywords = keywords.ToLowerInvariant().Contains("pwsh");
                }
            }

            var hasPowerShellTitle = item.Title?.Text.ToLowerInvariant().Contains("powershell") ?? false;
            var hasPWSHTitle = item.Title?.Text.ToLowerInvariant().Contains("pwsh") ?? false;

            return hasPowerShellTitle || hasPowerShellCategory || hasPowerShellKeywords || hasPWSHTitle || hasPWSHCategory || hasPWSHKeywords;
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