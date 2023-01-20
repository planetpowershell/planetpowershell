using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KamalFarmer : IAmACommunityMember
    {
        public string FirstName => "Kamal";
        public string LastName => "Farmer";
        public string ShortBioOrTagLine => "Microsoft and VMware Technical Specialist  /  PowerShell Automation / NV1 Security Cleared";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "kamal.farmer@gmail.com";
        public string TwitterHandle => "";
        public string MastodonHandle => "";
        public string GravatarHash => "f3db3bc85b78d71cb9a76e8039466dfa";
        public string GitHubHandle => "";
        public GeoPosition Position => new GeoPosition(-37.8142, 144.9632);
        public Uri WebSite => new Uri("https://hkeylocalmachine.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://hkeylocalmachine.com/?feed=rss2"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
