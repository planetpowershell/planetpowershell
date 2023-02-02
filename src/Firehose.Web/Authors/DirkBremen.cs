using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class DirkBremen : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Dirk";
        public string LastName => "Bremen";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Automation lover";
        public string StateOrRegion => "Ireland";
        public string EmailAddress => "rescueme@planetpowershell.com";
        public string TwitterHandle => "powershellone";
        public string MastodonHandle => "";
        public string GravatarHash => "fc95464388c9f41d7da43a6618fb04bd";
        public string GitHubHandle => "dbremen";
        public GeoPosition Position => new GeoPosition(53.338389, -6.258877);
        public Uri WebSite => new Uri("https://powershellone.wordpress.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://powershellone.wordpress.com/rss"); } }
        public bool Filter(SyndicationItem item)
        {
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
