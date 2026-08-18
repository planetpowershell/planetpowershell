using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KetanKamble : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Ketan";
        public string LastName => "Kamble";
        public string Pronouns => "";
        public string ShortBioOrTagLine =>
            "Read-only Intune, Entra and Microsoft Graph tooling built in the open — PowerShell runbooks and Power BI, explained underneath the portal";
        public string StateOrRegion => "Finland";
        public string EmailAddress => "";
        public string TwitterHandle => "";
        public string MastodonHandle => "";
        public string GitHubHandle => "KetanKamble3894";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(60.1699, 24.9384);
        public Uri WebSite => new Uri("https://ketankamble.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://ketankamble.com/feed_rss_created.xml"); }
        }
        public string FeedLanguageCode => "en";

        // Only surface the PowerShell-driven posts. Every runbook-backed post
        // on the blog is tagged "PowerShell"; the few explainer posts that
        // ship no PowerShell script are left out. Match the tag in the item's
        // categories or the title.
        public bool Filter(SyndicationItem item)
        {
            var inCategories = item.Categories?.Any(c =>
            {
                var name = c.Name?.ToLowerInvariant() ?? string.Empty;
                return name.Contains("powershell") || name.Contains("pwsh");
            }) ?? false;

            var title = item.Title?.Text?.ToLowerInvariant() ?? string.Empty;
            var inTitle = title.Contains("powershell") || title.Contains("pwsh");

            return inCategories || inTitle;
        }
    }
}
