using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ShaneONeill : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Shane";
        public string LastName => "O'Neill";
        public string ShortBioOrTagLine => "DBA. Food, Coffee, Whiskey (not necessarily in that order)... ";
        public string StateOrRegion => "Ireland";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "SOZDBA";
        public string MastodonHandle => "";
        public string GravatarHash => "0440d5d8f1b51b4765e3d48aec441510";
        public string GitHubHandle => "shaneis";
        public GeoPosition Position => new GeoPosition(53.2707, -9.0568);

        public Uri WebSite => new Uri("https://nocolumnname.blog/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://nocolumnname.blog/feed/"); } }

        public bool Filter(SyndicationItem item)
        {         
            // This filters out only the posts that have the "PowerShell" category
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
