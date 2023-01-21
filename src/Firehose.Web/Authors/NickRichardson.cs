using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class NickRichardson : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Nick";
        public string LastName => "Richardson";
        public string ShortBioOrTagLine => "PowerShell | Automation | DevOps | VDI";
        public string StateOrRegion => "Omaha, Nebraska";
        public string EmailAddress => "nick@spiderzebra.com";
        public string TwitterHandle => "ChiefNSR";
        public string MastodonHandle => "";
        public string GravatarHash => "e0c2f09bf7f391bcf7aac9efc9325d67";
        public string GitHubHandle => "n2501r";
        public GeoPosition Position => new GeoPosition(41.257160, -95.995102);
        public Uri WebSite => new Uri("https://spiderzebra.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://spiderzebra.com/feed/"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
