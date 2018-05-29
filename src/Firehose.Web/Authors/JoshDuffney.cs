using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JoshDuffney : IAmACommunityMember
    {
        public string FirstName => "Josh";
        public string LastName => "Duffney";
        public string ShortBioOrTagLine => ":DevOps Engineer,Pluralsight Author,Speaker,Blogger,PowerShell Advocate";
        public string StateOrRegion => "Omaha, USA";
        public string TwitterHandle => "joshduffney";
        public string GitHubHandle => "duffney";
        public string GravatarHash => "32a29258aa2649e9ee6167eb12e70bf5";
        public GeoPosition Position => new GeoPosition(41.2524, 95.9980);

        public Uri WebSite => new Uri("http://duffney.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://duffney.io/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
