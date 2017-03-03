using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JoshDuffney : IAmACommunityMember
    {
        public string FirstName => "Josh";
        public string LastName => "Duffney";
        public string ShortBioOrTagLine => ":DevOps Engineer,Pluralsight Author,Speaker,Blogger,PowerShell Advocate";
        public string StateOrRegion => "Omaha, USA";
        public string EmailAddress => "duffney@outlook.com";
        public string TwitterHandle => "joshduffney";
        public string GitHubHandle => "duffney";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(41.2524, 95.9980);

        public Uri WebSite => new Uri("http://duffney.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://duffney.io/feed.xml"); } }
    }
}
