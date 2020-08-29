using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DanTsekhanskiy : IAmACommunityMember
    {
        public string FirstName => "Dan";
        public string LastName => "Tsekhanskiy";
        public string ShortBioOrTagLine => "SRE from a Windows Guy";
        public string StateOrRegion => "New York, NY";
        public string EmailAddress => dan@tsknet.com
        public string TwitterHandle => "tseknet";
        public string GravatarHash => "fc477805e58b913f5082111d3dcdbe90";
        public string GitHubHandle => "tseknet";
        public GeoPosition Position => new GeoPosition(40.740764, -74.002003);
        public Uri WebSite => new Uri("https://tseknet.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://tseknet.com/feed.xml"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
        public string FeedLanguageCode => "en";
    }
}
